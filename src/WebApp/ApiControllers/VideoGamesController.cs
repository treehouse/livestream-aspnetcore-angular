using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using Microsoft.AspNetCore.Cors;
using WebApp.Data;
using Microsoft.EntityFrameworkCore;
using WebApp.DTOs;

namespace WebApp.ApiControllers
{
    [Route("api/[controller]")]
    public class VideoGamesController : Controller
    {
        private Context _context = null;

        public VideoGamesController(Context context)
        {
            _context = context;   
        }

        [HttpGet]
        public IActionResult Get()
        {
            var videoGames = _context.VideoGames
                .Include(vg => vg.Platform)
                .OrderBy(vg => vg.Title)
                .ToList();

            // HTTP Status Code 200
            return Ok(videoGames);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var videoGame = _context.VideoGames
                .Where(vg => vg.Id == id)
                .SingleOrDefault();

            if (videoGame == null)
            {
                return NotFound();
            }

            return Ok(videoGame);
        }

        // POST
        [HttpPost]
        public IActionResult Post([FromBody] VideoGameDTO videoGameDTO)
        {
            if (videoGameDTO == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO Switch to using Automapper
            var videoGame = new VideoGame()
            {
                Title = videoGameDTO.Title,
                PublishedOn = videoGameDTO.PublishedOn.Value,
                PlatformId = videoGameDTO.PlatformId.Value
            };

            _context.VideoGames.Add(videoGame);
            _context.SaveChanges();

            // http://localhost:5000/api/videogames/1
            return Created("/api/videogames/" + videoGame.Id, videoGame);
        }

        // PUT

        // DELETE
    }
}

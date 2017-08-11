using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Platform
    {
        public Platform()
        {
            VideoGames = new List<VideoGame>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IList<VideoGame> VideoGames { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class VideoGame
    {
        public int Id { get; set; } // 1, 2, 3, 4, ...
        [Required]
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}
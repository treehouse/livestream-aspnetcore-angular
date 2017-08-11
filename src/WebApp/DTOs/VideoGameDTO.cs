using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.DTOs
{
    public class VideoGameDTO
    {
        public int Id { get; set; } // 1, 2, 3, 4, ...
        [Required]
        [MinLength(3, ErrorMessage = "The Title must be at least 3 characters in length.")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Published On")]
        public DateTime? PublishedOn { get; set; }
        [Required]
        [Display(Name = "Platform")]
        public int? PlatformId { get; set; }
    }
}
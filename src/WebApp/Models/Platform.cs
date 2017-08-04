using System.Collections.Generic;

namespace WebApp.Models
{
    public class Platform
    {
        public Platform()
        {
            VideoGames = new List<VideoGame>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public IList<VideoGame> VideoGames { get; set; }
    }
}

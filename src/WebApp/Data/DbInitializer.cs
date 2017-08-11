using WebApp.Models;
using System;
using System.Linq;

namespace WebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(this Context context)
        {
            var platform1 = new Platform() { Id = 1, Name = "N64" };
            var platform2 = new Platform() { Id = 2, Name = "GameCube" };
            var platform3 = new Platform() { Id = 3, Name = "Wii" };
            var platform4 = new Platform() { Id = 4, Name = "Wii U" };
            var platform5 = new Platform() { Id = 5, Name = "Switch" };
            var platform6 = new Platform() { Id = 6, Name = "PlayStation" };
            var platform7 = new Platform() { Id = 7, Name = "PlayStation 2" };
            var platform8 = new Platform() { Id = 8, Name = "PlayStation 3" };
            var platform9 = new Platform() { Id = 9, Name = "PlayStation 4" };
            var platform10 = new Platform() { Id = 10, Name = "Xbox" };
            var platform11 = new Platform() { Id = 11, Name = "Xbox 360" };
            var platform12 = new Platform() { Id = 12, Name = "Xbox One" };

            AddPlatforms(context, 
                platform1,
                platform2,
                platform3,
                platform4,
                platform5,
                platform6,
                platform7,
                platform8,
                platform9,
                platform10,
                platform11,
                platform12
            );

            var videoGame1 = new VideoGame()
            {
                Id = 1,
                Title = "Super Mario 64",
                PublishedOn = new DateTime(1996, 1, 1),
                PlatformId = 1 // N64
            };

            var videoGame2 = new VideoGame()
            {
                Id = 2,
                Title = "Resident Evil",
                PublishedOn = new DateTime(1994, 1, 1),
                PlatformId = 6 // Playstation
            };

            var videoGame3 = new VideoGame()
            {
                Id = 3,
                Title = "Halo",
                PublishedOn = new DateTime(2000, 1, 1),
                PlatformId = 10 // Xbox
            };

            AddVideoGames(context, 
                videoGame1,
                videoGame2,
                videoGame3);
        }

        private static void AddPlatforms(Context context, params Platform[] platforms)
        {
            foreach (var platform in platforms)
            {
                if (!context.Platforms.Any(p => p.Id == platform.Id))
                {
                    platform.Id = 0;
                    context.Platforms.Add(platform);
                    context.SaveChanges();
                }
            }
        }

        private static void AddVideoGames(Context context, params VideoGame[] videoGames)
        {
            foreach (var videoGame in videoGames)
            {
                if (!context.VideoGames.Any(vg => vg.Id == videoGame.Id))
                {
                    videoGame.Id = 0;
                    context.VideoGames.Add(videoGame);
                    context.SaveChanges();
                }
            }
        }
    }
}

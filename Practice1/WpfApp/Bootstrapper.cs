using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Model;
using WpfApp.ViewModel;

namespace WpfApp
{
    class Bootstrapper
    {
        public Repository Repository { get; set; }

        public Bootstrapper()
        {
            Repository = new Repository();
            CreateTestData();
            CreateTestData();
            CreateTestData();
            CreateTestData();
            CreateTestData();

        }

        private void CreateTestData()
        {
            var album = new Album
            {
                Id = 1,
                Name = "Meine ersten Kinderlieder",
                PublishYear = 1833,
            };
            album.Artists.Add(new Artist
            {
                Id = 1,
                Name = "VA"
            });
            var song1 = new Song
            {
                Id = 1,
                Length = TimeSpan.FromMinutes(3.8),
                Name = "Alle meine Entchen"
            };
            song1.Artists.Add(new Artist
            {
                Id = 2,
                Name = "Unknown"
            });
            var song2 = new Song
            {
                Id = 2,
                Length = TimeSpan.FromMinutes(13.1),
                Name = "Neunte Symphonie"
            };
            song2.Artists.Add(new Artist
            {
                Id = 3,
                Name = "Tobi"
            });

            album.Songs.Add(song1);
            album.Songs.Add(song2);

            //===================

            var album2 = new Album
            {
                Id = 2,
                Name = "Meine erste Porno Soundtracks",
                PublishYear = 1990,
            };
            album2.Artists.Add(new Artist
            {
                Id = 9,
                Name = "VA"
            });
            var song6 = new Song
            {
                Id = 6,
                Length = TimeSpan.FromSeconds(11),
                Name = "Ahhhhh"
            };
            song6.Artists.Add(new Artist
            {
                Id = 7,
                Name = "Gina Wild"
            });
            var song7 = new Song
            {
                Id = 7,
                Length = TimeSpan.FromMinutes(13.1),
                Name = "Uhhhh"
            };
            song7.Artists.Add(new Artist
            {
                Id = 8,
                Name = "Tobi Long"
            });

            album2.Songs.Add(song6);
            album2.Songs.Add(song7);


            Repository.Albums.Add(album);
            Repository.Albums.Add(album2);
        }
    }
}

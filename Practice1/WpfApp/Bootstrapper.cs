using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
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
        }

        private void CreateTestData()
        {

            #region artists
            var artist1 = new Artist
            {
                Id = 1,
                Name = "Detlef Jöcker"
            };
            var artist2 = new Artist
            {
                Id = 2,
                Name = "Volker Rossin"
            };
            var artist3 = new Artist
            {
                Id = 3,
                Name = "Robert Metcalf"
            };
            var artist4 = new Artist
            {
                Id = 4,
                Name = "Alex"
            };
            var artist5 = new Artist
            {
                Id = 5,
                Name = "Sasa"
            };
            var artist6 = new Artist
            {
                Id = 6,
                Name = "Tobi"
            };
            var artist7 = new Artist
            {
                Id = 7,
                Name = "Hans"
            };
            var artist8 = new Artist
            {
                Id = 8,
                Name = "Peter"
            };

            var artist9 = new Artist
            {
                Id = 9,
                Name = "Klaus"
            };
            var artist10 = new Artist
            {
                Id = 10,
                Name = "VA"
            };
            var artist11 = new Artist
            {
                Id = 11,
                Name = "Gina Wild"
            };
            var artist12 = new Artist
            {
                Id = 8,
                Name = "Tobi Long"
            };
            #endregion
            #region songs
            var song1 = new Song
            {
                Id = 1,
                Length = TimeSpan.FromMinutes(3.8),
                Name = "Alle meine Entchen",
                Artists = new List<Artist> { artist4,artist5,artist6}
            };
            var song2 = new Song
            {
                Id = 2,
                Length = TimeSpan.FromMinutes(13.1),
                Name = "Neunte Symphonie",
                Artists = new List<Artist> { artist7,artist8,artist9}
            };

            var song6 = new Song
            {
                Id = 6,
                Length = TimeSpan.FromSeconds(11),
                Name = "Ahhhhh",
                Artists = new List<Artist> { artist11}
            };
            var song7 = new Song
            {
                Id = 7,
                Length = TimeSpan.FromMinutes(13.1),
                Name = "Uhhhh",
                Artists = new List<Artist> { artist12}
            };
            
            #endregion

            #region Erstes Album
            var album = new Album
            {
                Id = 1,
                Name = "Meine ersten Kinderlieder",
                PublishYear = 1833,
            };

            album.Artists.Add(artist1);
            album.Artists.Add(artist2);
            album.Artists.Add(artist3);

            album.Songs.Add(song1.WithTrack(1));
            album.Songs.Add(song2.WithTrack(2));
            #endregion

            #region Zweites Album
            var album2 = new Album
            {
                Id = 2,
                Name = "Mein erster Porno Soundtracks",
                PublishYear = 1990,
            };
            album2.Artists.Add(artist10);

            album2.Songs.Add(song6.WithTrack(1));
            album2.Songs.Add(song7.WithTrack(2));
            #endregion

            Repository.Albums.Add(album);
            Repository.Albums.Add(album2);
            
        }
    }
}

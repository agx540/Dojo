using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class AlbumViewModel : ObservableObject
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private int _publishYear;
        public int PublishYear
        {
            get { return _publishYear; }
            set { SetProperty(ref _publishYear, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private ObservableCollection<ArtistViewModel> _artists;

        public ObservableCollection<ArtistViewModel> Artists
        {
            get { return _artists; }
            set { SetProperty(ref _artists, value); }
        }

        private ObservableCollection<SongViewModel> _songs;

        public ObservableCollection<SongViewModel> Songs
        {
            get { return _songs; }
            set { SetProperty(ref _songs, value); }
        }


        public AlbumViewModel(Album album)
        {
            ID = album.Id;
            PublishYear = album.PublishYear;
            Name = album.Name;
            Artists = new ObservableCollection<ArtistViewModel>(album.Artists.Select(a => new ArtistViewModel(a)));
            Songs = new ObservableCollection<SongViewModel>(album.Songs.Select(s => new SongViewModel(s)));
        }

    }
}

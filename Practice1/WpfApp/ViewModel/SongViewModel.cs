using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class SongViewModel : ObservableObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private TimeSpan _length;
        public TimeSpan Length
        {
            get { return _length; }
            set { SetProperty(ref _length, value); }
        }

        private ObservableCollection<ArtistViewModel> _artists;
        public ObservableCollection<ArtistViewModel> Artists
        {
            get { return _artists; }
            set { SetProperty(ref _artists, value); }
        }

        public SongViewModel(Song song)
        {
            Id = song.Id;
            Name = song.Name;
            Length = song.Length;
            Artists = new ObservableCollection<ArtistViewModel>(song.Artists.Select(a => new ArtistViewModel(a)));
        }
    }
}

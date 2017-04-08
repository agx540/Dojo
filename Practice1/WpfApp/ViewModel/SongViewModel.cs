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

        private ObservableCollection<ArtistViewModel> _artists = new ObservableCollection<ArtistViewModel>();
        public ObservableCollection<ArtistViewModel> Artists
        {
            get { return _artists; }
            set { SetProperty(ref _artists, value); }
        }

        private ArtistViewModel _selectedArtist;
        public ArtistViewModel SelectedArtist
        {
            get { return _selectedArtist; }
            set { SetProperty(ref _selectedArtist, value); }
        }

        public string FormattedLength
        {
            get { return $"{Length:mm}:{Length:ss}"; }
            set
            {
                var dt = DateTime.ParseExact(value, "mm:ss", null);
                Length = new TimeSpan(0, 0, dt.Minute, dt.Second, 0);
            }
        }

        public SongViewModel()
        {
            Id = 1;
            Name = "Songname";
            Length = new TimeSpan(0, 3, 30);
            Artists.Add(new ArtistViewModel(new Artist() { Id = 1, Name = "Bob Dylan" }));
            Artists.Add(new ArtistViewModel(new Artist() { Id = 2, Name = "Bob Marley" }));
        }

        public SongViewModel(Song song)
        {
            Id = song.Id;
            Name = song.Name;
            Length = song.Length;
            Artists = new ObservableCollection<ArtistViewModel>(song.Artists.Select(a => new ArtistViewModel(a)));
            SelectedArtist = Artists?.FirstOrDefault();
        }
    }
}

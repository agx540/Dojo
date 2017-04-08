using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class AlbumListViewModel
    {
        public ObservableCollection<AlbumViewModel> Albums { get; set; }
        public AlbumListViewModel(IEnumerable<Album> albums)
        {
            Albums = new ObservableCollection<AlbumViewModel>(albums.Select(a => new AlbumViewModel(a)));

        }
    }
}

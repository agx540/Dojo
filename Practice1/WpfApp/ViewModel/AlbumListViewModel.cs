﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class AlbumListViewModel : ObservableObject
    {
        private AlbumViewModel _selectedAlbum;

        public AlbumViewModel SelectedAlbum
        {
            get { return _selectedAlbum; }
            set { SetProperty(ref _selectedAlbum, value); }
        }

        public ObservableCollection<AlbumViewModel> Albums { get; set; } = new ObservableCollection<AlbumViewModel>();


        public AlbumListViewModel()
        {
            
        }

        public AlbumListViewModel(IEnumerable<Album> albums)
        {
            Albums = new ObservableCollection<AlbumViewModel>(albums.Select(a => new AlbumViewModel(a)));

            if (Albums.Any())
                SelectedAlbum = Albums.First();
        }
    }
}
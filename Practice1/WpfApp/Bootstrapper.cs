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
        public Repository Repository{ get; set; }
        public AlbumListViewModel Albums{ get; set; }

        public Bootstrapper()
        {
            Repository = new Repository();
            Albums = new AlbumListViewModel(Repository.Albums);
            
        }
    }
}

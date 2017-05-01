using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Album
    {
        public int Id { get; set; }
        public int PublishYear { get; set; }
        public String Name { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}

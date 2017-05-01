using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Song
    {
        public int Id { get; set; }
        public int Track { get; set; }
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public TimeSpan Length { get; set; }
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}

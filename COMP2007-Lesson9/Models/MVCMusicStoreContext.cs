using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2007_Lesson9.Models
{
    class MVCMusicStoreContext : DbContext
    {
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
    }
}

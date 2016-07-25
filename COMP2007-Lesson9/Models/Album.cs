using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2007_Lesson9.Models
{
    public class Album
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Album()
        {

        }
        /// <summary>
        /// This constructoor takes one parameter - Title
        /// </summary>
        /// <param name="Title><param></param>
        public Album(string Title)
        {
            this.Title = Title;
        }

        public int AlbumID { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
}

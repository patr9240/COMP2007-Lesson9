using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2007_Lesson9.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Genre()
        {

        }

        /// <summary>
        /// This constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Genre(string Name)
        {
            this.Name = Name;
        }
        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}

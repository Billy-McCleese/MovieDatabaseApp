using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseApp
{
    internal class MovieEntry
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public MovieEntry(string category, string title)
        {
            Category = category;
            Title = title;
        }
    }
}

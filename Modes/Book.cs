using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeT1.Modes
{
    public class Book
    {
        public string Name { get; set; }

        private int _pageCount;

        public int PageCount
        {
            get { return _pageCount; }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Pagecount mus be more than 10 !");

                }
                else
                {
                    _pageCount = value;
                }
                ;
            }
        }

    }
}

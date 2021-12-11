using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    public class RentalItem
    {
        private int movieNo;
        private string description;
        private string rating;

        public RentalItem()
        {

        }
        public RentalItem(int movieNo, string description, string rating)
        {
            this.movieNo = movieNo;
            this.description = description;
            this.rating = rating;

        }
        public String GetDisplayText(string sep = "\t")
        {
                return movieNo.ToString() + sep + description + sep + rating;
        }
    }
 }

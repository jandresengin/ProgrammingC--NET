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
        private string typeMovie;

        public RentalItem()
        {

        }
        public RentalItem(int movieNo, string description, string rating)
        {
            this.MovieNo = movieNo;
            this.Description = description;
            this.Rating = rating;
            this.Rating = rating;

        }

        public int MovieNo
        {
            get
            {
                return movieNo;
            }
            set
            {
                movieNo = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }

        public String GetDisplayText(string sep = "\t")
        {
                return movieNo.ToString() + sep + description + sep + rating;
        }
    }
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class RentalItemDueDate
    {
        private int movieNo;
        private string description;
        private string rating;
        private string typeMovie;
        private int numberDays;

        public RentalItemDueDate()
        {

        }
        public RentalItemDueDate(int movieNo, string description, string rating, string typeMovie, int numberDays)
        {
            this.MovieNo = movieNo;
            this.Description = description;
            this.Rating = rating;
            this.TypeMovie = typeMovie;
            this.NumberDays = numberDays;
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

        public string TypeMovie
        {
            get
            {
                return typeMovie;
            }
            set
            {
                typeMovie = value;
            }
        }
        public int NumberDays
        {
            get
            {
                return numberDays;
            }
            set
            {
                numberDays = value;
            }
        }
        public String GetDisplayText(string sep = "\t")
        {
            return movieNo.ToString() + sep + description + sep + rating + sep + typeMovie + sep + numberDays;
        }
    }
}

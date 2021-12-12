using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05
{
    public static class RentalItemDB
    {
        private const string dir = @"C:\C# 2015\Files\";
        private const string path = dir + "RentalItem.txt";

		public static void SaveRentalItem(List<RentalItem> rentalItems)
		{
			// create the output stream for a text file that exists
			StreamWriter textOut =
				new StreamWriter(
				new FileStream(path, FileMode.Create, FileAccess.Write));

			// write each rentalItem
			foreach (RentalItem rentalItem in rentalItems)
			{
				textOut.Write(rentalItem.MovieNo + "|");
				textOut.Write(rentalItem.Description + "|");
				textOut.Write(rentalItem.Rating + "|");
				textOut.WriteLine(rentalItem.TypeMovie);
			}

			// write the end of the document
			textOut.Close();
		}
		public static List<RentalItem> GetRentalItem()
		{
			// if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			// create the object for the input stream for a text file
			StreamReader textIn =
				new StreamReader(
					new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

			// create the array list for customers
			List<RentalItem> rentalItems = new List<RentalItem>();

			// read the data from the file and store it in the ArrayList
			while (textIn.Peek() != -1)
			{
				string row = textIn.ReadLine();
				string[] columns = row.Split('|');
				RentalItem rentalItem = new RentalItem();
				//string MovieNoString = rentalItem.MovieNo.ToString();
				//MovieNoString = columns[0];

				rentalItem.MovieNo = Int32.Parse(columns[0]);
				rentalItem.Description = columns[1];
				rentalItem.Rating = columns[2];
				rentalItem.TypeMovie = columns[3];
				rentalItems.Add(rentalItem);
			}

			textIn.Close();

			return rentalItems;
		}
	}
}

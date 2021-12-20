using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************************************************
 * 
 *      CSD2354 Programming C# NET          Instructor: Noah Petrides
 *      Jairo Andres Supelano Rativa        c0812859
 *      3rd Exam
 * 
 **************************************************************************************************************/



namespace InventoryMaintenance
{
    public class Plant : InvItem ///* inheritance */
    {
        private string size;

        public Plant()
        {

        }

        public Plant(int itemNo, string description, decimal price, string size) : base(itemNo, description, price) ///* inheritance */
        {
            this.size = size;
        }
        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        /* overridable inheritance */
        public override string GetDisplayText() => base.ItemNo + "    " + this.size + " " + base.Description + " (" + base.Price.ToString("c") + ")";
         

    }
}

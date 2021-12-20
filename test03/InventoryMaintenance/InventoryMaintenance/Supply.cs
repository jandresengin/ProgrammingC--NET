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


/* New Class created*/


namespace InventoryMaintenance
{
    public class Supply : InvItem ///* inheritance */
    {
        private string manufacturer;
        public Supply()
        {

        }
        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price)///* inheritance */
        {
            this.manufacturer = manufacturer;
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        /* overridable inheritance */
        public override string GetDisplayText() => base.ItemNo + "    " + this.manufacturer + " " + base.Description + " (" + base.Price.ToString("c") + ")";



    }




}

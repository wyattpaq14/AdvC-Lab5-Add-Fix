using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryCalculator : Calculator
    {
        //variable to hold the memory
        private static decimal memoryStorage;
        private static string dispValue;

        public MemoryCalculator(decimal memory)
        {

            this.MemoryStorage = memory;
        }

        //added string constructor to get the display value from form1
        //this will allow me to add what ever is inputed to be added to memoryStorage (MemoryAdd function)
        public MemoryCalculator(string displayValue)
        {

            this.DisplayValue = displayValue;
        }

        public string DisplayValue
        {
            get
            {
                return dispValue;
            }
            set
            {
                dispValue = value;
            }
        }

        public decimal MemoryStorage
        {
            get
            {
                return memoryStorage;
            }
            set
            {
                memoryStorage = value;
            }
        }

        public decimal memoryStore()
        {
            //save memoryStorage
            memoryStorage = this.MemoryStorage;

            //going to return this to put in the txtMemory text box

            return memoryStorage;
        }

        public decimal memoryAdd()
        {
            //declare array to define what numbers to add 

            decimal[] addens = { Convert.ToDecimal(this.DisplayValue), memoryStorage };
            //add memoryStorage and current value
            memoryStorage = addens.Sum();
            return memoryStorage;

        }
        public void memoryClear()
        {
            //set memoryStorage to 0
            memoryStorage = 0;
        }


        public decimal memoryRecall()
        {
            // return memoryStorage
            return memoryStorage;

        }


    }
}

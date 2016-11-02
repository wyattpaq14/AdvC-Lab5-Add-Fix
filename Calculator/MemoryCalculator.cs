using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MemoryCalculator : Calculator
    {
        private static decimal memoryStorage;

        public MemoryCalculator(decimal memoryStorage)
        {

            this.MemoryStorage = memoryStorage;
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

        public void memoryStore()
        {
            //save memoryStorage
        }

        public void memoryAdd()
        {
            //add memoryStorage and current value
        }
        public void memoryClear()
        {
            //set memoryStorage to 0
            memoryStorage = 0;
        }


        public void memoryRecall()
        {
            // return memoryStorage
        }


    }
}

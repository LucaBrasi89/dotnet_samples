using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomType
    {
        string lastField;
        string middleField;
        string firstField;

        public CustomType()
        {
            this.lastField = "3";
            this.middleField = "2";
            this.firstField = "1";
        }

        public string LastField { get => lastField; set => lastField = value; }
        public string MiddleField { get => middleField; set => middleField = value; }
        public string FirstField { get => firstField; set => firstField = value; }
    

    
    }
}

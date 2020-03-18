using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DescriptionItem
    {
        string property;
        string excelName;
        string value;

        public DescriptionItem(string property, string excelName, string value)
        {
            this.Property = property;
            this.ExcelName = excelName;
            this.Value = value;
        }

        public string Property { get => property; set => property = value; }
        public string ExcelName { get => excelName; set => excelName = value; }
        public string Value { get => value; set => this.value = value; }
    }
}

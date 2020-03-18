using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DescriptionBlock
    {
        
        List<DescriptionItem> descriptionItems = new List<DescriptionItem>();

        public DescriptionBlock()
        {
            this.makeEmptyItems();
            this.fillItemsFromRun();
        }

        void makeEmptyItems()
        {
            descriptionItems.Add(new DescriptionItem("","Esb name", null));
            descriptionItems.Add(new DescriptionItem("", "Airplane_Model", null));
            descriptionItems.Add(new DescriptionItem("", "Airplane_Number", null));
            descriptionItems.Add(new DescriptionItem("", "Cond_End_time", null));
            descriptionItems.Add(new DescriptionItem("", "Cond_No REEL", null));
            descriptionItems.Add(new DescriptionItem("", "Cond_Seq_Number", null));
            descriptionItems.Add(new DescriptionItem("", "Cond_Start_Date", null));
            descriptionItems.Add(new DescriptionItem("", "Cond_Start_Time", null));
            descriptionItems.Add(new DescriptionItem("", "Data_Request_No", null));
            descriptionItems.Add(new DescriptionItem("", "FTE_Analyst", null));
            descriptionItems.Add(new DescriptionItem("", "FT_TI_Code", null));
            descriptionItems.Add(new DescriptionItem("", "Job_Date", null));
            descriptionItems.Add(new DescriptionItem("", "Job_Time", null));
            descriptionItems.Add(new DescriptionItem("", "Test_Date", null));
            descriptionItems.Add(new DescriptionItem("", "Test_Number", null));
            descriptionItems.Add(new DescriptionItem("", "Time_Reference", null));
        }

        void fillItemsFromRun()
        {
            Random rand = new Random();
            foreach (DescriptionItem item in this.descriptionItems)
            {
                item.Value = rand.Next(1, 100).ToString();
            }
        }

        public override string ToString()
        {
            string data = "";
            foreach (DescriptionItem item in this.descriptionItems)
            {
                string row = String.Format("{0,-20}: {1}\n",item.ExcelName,item.Value);
                data = data + row;
            }

            return data;

        }
    }
}

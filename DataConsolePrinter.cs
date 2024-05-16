using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LV5
{
    class DataConsolePrinter
    {
        
        public void Print(IDataset dataset)
        {
            ReadOnlyCollection<List<string>> data = dataset.GetData();
            if (data == null) { return; }

            foreach (var list in data)
            {
                foreach (var str in list)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

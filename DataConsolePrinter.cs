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
        ReadOnlyCollection<List<string>> data;
        public void Print(IDataset dataset)
        {
            data = dataset.GetData();
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

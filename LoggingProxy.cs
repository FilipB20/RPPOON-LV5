using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class LoggingProxy : IDataset
    {
        IDataset data;
        public LoggingProxy(IDataset data)
        {
            this.data = data;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            ConsoleLogger.GetInstance().Log("Pristup podacima:"+DateTime.Now+"\n");
            return data.GetData();
        }
    }
}

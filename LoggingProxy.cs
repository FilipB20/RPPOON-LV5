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
        ConsoleLogger consoleLogger = ConsoleLogger.GetInstance();

        public LoggingProxy(IDataset data)
        {
            this.data = data;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            consoleLogger.Log("Pristup podacima:",DateTime.Now);
            return data.GetData();
        }
    }
}

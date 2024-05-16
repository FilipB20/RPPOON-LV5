using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class GroupNote : Note
    {
        List<string> names;

        public GroupNote(string message,ITheme theme) : base(message,theme)
        {
            names=new List<string>();
        }

        public void Add(string name)
        {
            names.Add(name);
        }

        public void Remove(string name)
        {
            names.Remove(name);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.Write($"Group:");
            foreach(string name in names)
            {
                Console.Write(name+" ");
            }
            Console.Write("\n");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}

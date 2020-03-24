using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Timenote : Note
    {
        DateTime time = DateTime.Now;


        public Timenote() : base() { this.time = DateTime.Now; }

        public Timenote(String text, String author, int importance, DateTime time)
            : base(text, author, importance)
        {
            this.time = time;
        }

        public DateTime Time
        {

            get { return this.time; }
            set { this.time = value; }


        }
        public override string ToString()
        {
            return base.ToString() + this.time;
        }
    }
}

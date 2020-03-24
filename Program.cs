using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note();
            Note First = new Note("Petar Preradovic", "pocetak", 5);
            Note Second = new Note("Tin ujevic", "kraj");
            Console.WriteLine(First.Importance);
            Console.WriteLine(note.Author);
            Console.WriteLine(Second.Importance);
            Console.WriteLine(note.ToString());

            Timenote time = new Timenote();
            Console.WriteLine(time.Time);
            Console.WriteLine(time.ToString());


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    class Note
    {
        private String text;
        private String author;
        private int importance;

        int getValue() { return importance; }
        void setValue(int value) { importance = value; }

        public int Importance
        {
            get { return importance; }
            set { this.importance = value; }
        }

        public String Text
        {
            get { return text; }
            set { this.text = value; }
        }

        public String Author
        {
            get { return author; }
        }

        public Note() { this.author = "Luka"; this.importance = 0; this.text = "Ide gas"; }
        public Note(String text, String author, int importance) { this.text = text; this.author = author; this.importance = importance; }
        public Note(String text, String author) { this.text = text; this.author = author; this.importance = 0; }


        public override string ToString()
        {
            return (this.author + this.importance);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_Assignment4
{
    class Program
    {//C0731847 gagandeep Kaur Waraich
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();

        }
        public void Run()
        { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            //Read file using StreamReader. reads file line by line
            using (StreamReader file = new StreamReader("c:/area51/beowulf.text"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }

    }
}

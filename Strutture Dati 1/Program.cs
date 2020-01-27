using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Strutture_Dati_1
{
    class Program
    {
        private const string file = @"file.txt";
        private const string file_finito = @"filefinito.txt";

        static void Main(string[] args) 
        {
            List<double> numeri = new List<double>();
            using (StreamReader rfile = new StreamReader(file))
            {
                string sline;
                while ((sline = rfile.ReadLine()) != null)
                {
                    double d = Convert.ToDouble(sline);
                    numeri.Add(d);
                }
            }
            using (StreamWriter swfile = new StreamWriter(file_finito, true))
            {
                for (int i = numeri.Count - 1; i >= 0; i--)
                {
                    swfile.WriteLine(numeri[i]);
                }
            }
        }
    }
}

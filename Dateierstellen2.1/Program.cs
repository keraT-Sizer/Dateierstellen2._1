using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace Dateierstellen2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = File.Open("Book1.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadLine());
                string s = sr.ReadLine();
                string[] array = s.Split(',');
                //foreach (var item in array)
                //{
                    string s1 = array[0];
                    string s2 = array[1];

                //}
                Console.WriteLine("{0} {1}",s1,s2);
                double zahl = Convert.ToDouble(s2);
                Console.WriteLine(zahl*2);
                fs.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Es ist ein Fehler auufgetreten");
            }
            finally
            {
                Console.WriteLine("Ich werde immer ausgegeben, ob Fehler gibts oder nicht");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    internal class Student
    {
        public string ati;
        public int jili;
        public string tamamlagan;
        public string kayjerge;
        public int kirgenjili; 
        public string fakultet;    



        public void maglumat(string name, int date, string tamam, /*int tamam1*/string kirgenoxiw,int jilikirgen,string faq)
        {

            Console.WriteLine($"{ati} {jili} tuwilgan,{tamam}-sanli mektepti tamamlagan, {kayjerge} {jilikirgen} {faq} fakultetine kirgen" );
        }
    }
}

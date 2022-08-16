using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    internal class Class
    {
        static void Main(string[] args)
        {
            Student kaijerge = new Student();    
            kaijerge.ati = "Abat Erjanov";
            kaijerge.jili = 2003;
            kaijerge.tamamlagan = "21";
            kaijerge.kayjerge = "Qaraqalpaq mamleketlik universiteti";
            kaijerge.kirgenjili = 2022;
            kaijerge.fakultet = "Matematika";

            kaijerge.maglumat(kaijerge.ati,kaijerge.jili,kaijerge.tamamlagan,kaijerge.kayjerge,kaijerge.kirgenjili,kaijerge.fakultet );
           
            Console.ReadKey();
        }         
    }
}

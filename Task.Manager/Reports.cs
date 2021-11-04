using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Manager
{
    class Reports
    {   
        public Reports(string grade,string name ) 
        {
            if(grade.Equals("да")) 
            {
                Console.Write(name+", отчет принят,ты умничка!  ");
                Tasks task = new Tasks(" выполнена");
            }
            else 
            {
                Console.WriteLine(name+", твой отчет - это нечто... Марш переделывать!");
                

               Remake(name);

            }
        }
        public void Remake(string name) 
        {
            Console.Write("Извините,сейчас переделаю" +"\n"+ "*Переделывает*"+"\n"+ "Молодец,"+name+",хорошая работа  ");
            Tasks task = new Tasks(" выполнена");

        }
    }
}

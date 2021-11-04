using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task.Manager
{
    class Program
    {       
        static void Filling__in_projects() 
        {
            Project project = new Project("Проект");
            Project project1 =new Project("Гафуров Ильшат Рафкатович-инициатор ", "Антон Приползин-тимлид");
            project.Description("Необходимо создать социальную сеть для студентов КФУ");
            project.Data();
        }
        static void Filling_in_reports() 
        {
            string[] names = File.ReadAllLines("имена.txt");
            /* string[] answer =  {"да","нет" };
             Random random = new Random();
             for (int i = 0; i < names.Length; i++) 
             {

                 int index = random.Next(0, answer.Length-1);
                 string word = answer[index];
                 Employer employer = new Employer(word,names[i]);

             }*/
            
            Employer employer = new Employer("да", names[0]);
            Employer employer1 = new Employer("да", names[1]);
            Employer employer2 = new Employer("нет", names[2]);
            Employer employer3 = new Employer("да", names[3]);
            Employer employer4 = new Employer("нет", names[4]);
            Employer employer5 = new Employer("да", names[5]);
            Employer employer6 = new Employer("да", names[6]);
            Employer employer7 = new Employer("да", names[7]);
            Employer employer8 = new Employer("да", names[8]);
            Employer employer9 = new Employer("нет", names[9]);           
        }
        static void Report() 
        {
            string[] reports = File.ReadAllLines("отчеты.txt");
            string[] names = File.ReadAllLines("имена.txt");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] +": "+ reports[i]);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Создается проект");
            Filling__in_projects();
            Project project = new Project("Исполняется");
            Console.WriteLine("Создаем задачи..."+"\n");
            Project project2 = new Project();          
            project2.Give_tasks();     
            Console.WriteLine("\n");
            Console.WriteLine("Отчеты");
            Report();
            Console.WriteLine("\n");
            Tasks task2 = new Tasks("На проверке");
            Filling_in_reports();
            Project project3 = new Project("Закрыт");
        }
    }
}

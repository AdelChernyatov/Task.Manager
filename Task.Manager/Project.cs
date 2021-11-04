using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task.Manager
{
    class Project
    {
        private string condition;
        private string initiator;
        private string teamlead;
        public Project(string condition)
        {
            this.condition = condition;
            Console.WriteLine("Статус проекта : "+this.condition);
        }
        public Project(string initiator, string teamlead)
        {
            this.initiator = initiator;
            this.teamlead = teamlead;
            Console.WriteLine(this.initiator+"\n"+ this.teamlead);         
        }
        public Project()
        {
        }
        public void Description(string text) 
        {
            Console.WriteLine("Описание проекта " + text);
        }
        public void Data() 
        {
            Console.WriteLine("Сроки создания : 05.11.2021 - 31.12.2021");
        }
        public List<string> tasks = new List<string>() { };
       // public List<string> employers = new List<string>() { };
        public void Give_tasks() 
        {
            string[] task = File.ReadAllLines("задачи.txt");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(task[i]);
            }
            Console.WriteLine("");
            Tasks task2 = new Tasks("Задачи назначены");
            Console.WriteLine(""); // Если сотрудник отказывается,то он переходит на следующую 
              Employer employer1= new Employer("Михаил", "да", task[0],12);
              Employer employer2 = new Employer("Леонид","да", task[1],12);
              Employer employer3 = new Employer("Алексей", "да", task[2],13);
              Employer employer4 = new Employer("Владимир","да", task[3],16);
              Employer employer5 = new Employer("Адель", "нет", task[5],13);
              Employer employer6 = new Employer("Данил", "да", task[6],12);
              Employer employer7 = new Employer("Артур", "нет", task[8],14);
              Employer employer8 = new Employer("Максим", "да", task[9],11);
              Employer employer9 = new Employer("Саша", "да", task[10],19);
              Employer employer10 = new Employer("Влад", "да", task[11],17);
        }

    }
}

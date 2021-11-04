using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Manager
{
    class Tasks:Project
    {
       private string task_condition;
        
        public  string Remove(string task_condition) 
        {
            return  task_condition;
        }
        public void Data_task(int data)        
        {
            Console.WriteLine("Сроки выполнения задачи" +data + "12.2021");
        }
        public Tasks(string name) 
        {
            task_condition = name;
            Console.WriteLine("Статус задачи: "+task_condition);
        }
    }
}

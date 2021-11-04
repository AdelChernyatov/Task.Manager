using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Manager
{
    class Employer
    {
        private string name;
        private string task;
        private int data;
        private string word;
        public Employer(string name,string get,string task,int data)
        {
            this.name = name;
            this.task = task;
            this.data = data;

            Console.Write(this.name + ":" + this.task + " ," + this.data +".12.2021 ");              
            Tasks task2 = new Tasks("В работе");
        }
        public Employer(string word,string name_1) 
        {
            name = name_1;
            this.word = word;
            Reports reports = new Reports(word,name);
        }
    }
}

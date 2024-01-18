using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDo
    {
        public List<string> ToDoList { get; set; }
        public ToDo()
        {
            this.ToDoList = new List<string>();
        }

        public void Add(string item)
        {
            this.ToDoList.Add(item);
        }


        public void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", this.ToDoList[i]);
            }
            Console.WriteLine();
        }

        public void PrintAll()
        {
            this.Print(this.ToDoList.Count);
        }

        public void Done(string item)
        {
            if (this.ToDoList.IndexOf(item) == -1)
            {
                throw new ArgumentException("item not in list");
            }
            this.ToDoList.Remove(item);
        }

        public void Reorder(string item, int priority)
        {
            int currentPriority = this.ToDoList.IndexOf(item);
            if (currentPriority == -1)
            {
                throw new ArgumentException("Item is not present");
            }

            if (priority < currentPriority)
            {
                string prev = item;
                for (int i = priority; i < currentPriority + 1; i++)
                {
                    string t = this.ToDoList[i];
                    this.ToDoList[i] = prev;
                    prev = t;

                }
            }
            else
            {
                string prev = item;
                for (int i = priority; i >= currentPriority; i--)
                {
                    string t = this.ToDoList[i];
                    this.ToDoList[i] = prev;
                    prev = t;

                }
            }

        }

    }
}

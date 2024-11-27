using System.Linq;
using System.Collections.Generic;
using data;
using System.Collections;
namespace project_1_tasks
{
    internal class Program
    {
       //static List<string> Ts = new List<string>();
      // static List<bool>dotask=new List<bool>();
      static List<d>tasks=new List<d> ();

     enum chooce :byte
     {
            a=1,b,c,d,e,f,g
     }
        public static void Addtask()
        {
            Console.Write("Enter your task: ");
           // chect if task is exit
           string temp=Console.ReadLine();
            Console.Write("Enter your day task: ");
            string da = Console.ReadLine();
            bool c=false;
            d te=new d();
            te.t = temp;
            te.day = da;
            te.done = c;

            if (tasks.Contains(te))
            {
                Console.WriteLine("The task already exists");
            }
           else
            {
                
                tasks.Add(new d( temp,c,da));
                //Ts.Add(temp);
               // dotask.Add(false);
            }
            //Ts.Add( Console.ReadLine());
          
            Console.WriteLine("task added successfully");
        }
        public static void set_complete_task()
        {
            show_all_task();
            Console.Write("Enter the id of the task complete it: ");
            int i=int.Parse(Console.ReadLine());
            //Task[i].done = true;
            d temp = tasks[i];
            temp.done = true;
            tasks[i]= temp;
           // dotask[i] = true;
        }
        public static void Delet_task()
        {
            show_all_task();
            
            int i;
            do
            {
                Console.Write("Enter the id of the task want delet it : ");
                i=int.Parse(Console.ReadLine());
            } while((i<0)|| (i>tasks.Count));
            tasks.RemoveAt(i);
            //dotask.RemoveAt(i);
            //Console.WriteLine("delet succ");
        }
        public static void show_all_task()
        {
            /*Console.WriteLine("\t id \t name task \tdone\t");
            for (int i = 0; i <Ts.Count; i++)
            {
                Console.WriteLine($"\t {i} \t {Ts[i]} \t\t {dotask[i]} \t");
            }*/
            int c = 0;
            foreach (var item in tasks)
            {
                Console.WriteLine($"id: {c++}\t\t ,Task name:\t {item.t}\t\t ,Done: {item.done}\t\t ,Day: {item.day}");
            }
        }
        public static void show_complete_task()
        {
           // Console.WriteLine("\t id \t name task \t done\t");
            int c = 0;
            foreach (var item in tasks)
            {
                if(item.done==true)
                    Console.WriteLine($"Task:\t {item.t}\t\t ,Done: {item.done}\t\t ,Day: {item.day}");
            }


        }
        public static void show_not_complete_task()
        {
            //Console.WriteLine("\t id \t name task \tdone \t");
            foreach (var item in tasks)
            {
                if (item.done == false)
                    Console.WriteLine($"Task:\t {item.t}\t\t ,Done: {item.done}\t\t ,Day: {item.day}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t Welcom my  first project : ");
            Console.WriteLine();
            Console.WriteLine("\t\t =====================================");
            Console.WriteLine(" \t \t to Add task \t  \t choose 1");
            Console.WriteLine();
            Console.WriteLine(" \t \t to Delete task  \t choose 2");
            Console.WriteLine();
            Console.WriteLine(" \t \t to show all tasks \t choose 3");
            Console.WriteLine();
            Console.WriteLine(" \t \t to Show done task \t choose 4");
            Console.WriteLine();
            Console.WriteLine(" \t \t to Show not done task   choose 5");
            Console.WriteLine();
            Console.WriteLine(" \t \t to shading   done task  choose 6");
            Console.WriteLine();
            Console.WriteLine("\t \t to Exit \t \t choose 7");
            Console.WriteLine();
            int cho;
            chooce c;
            do
            {
                Console.Write("Enter your chooce:  ");
                c=(chooce)int.Parse(Console.ReadLine());
                switch (c)
                {
                    case chooce.a:
                        Addtask();
                        break;
                    case chooce.b:
                        Delet_task();
                        break;
                    case chooce.c:
                        show_all_task();
                        break;
                    case chooce.d:
                        show_complete_task();
                        break;
                    case chooce.e:
                        show_not_complete_task();
                        break;
                    case chooce.f:
                        set_complete_task();
                        break;
                    case chooce.g:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("wrong chooce ");
                        break;

                }

            } while ((int)c != 7);
            

        }
    }
}

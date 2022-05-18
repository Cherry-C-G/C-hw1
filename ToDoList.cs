using System;
using System.Collections.Generic;

namespace todolist
{
    class ToDo
    {
        public void ListItems()
        {
            Console.WriteLine("Welcome to the Simple To Do List");
            Console.WriteLine("Commands: 'exit', 'show', '--', '+some item', '-some item'\n");

            var toDoList = new List<string>();
            var appRunning = true;

            while (appRunning == true)
            {
                Console.WriteLine("Please enter a list item to add or a command to perform:");
                //read in what the user types
                var input = Console.ReadLine();

                switch (input)
                {
                    //close the program
                    case string a when a.Equals("exit"):
                        appRunning = false;
                        break;
                    //show the list
                    case string b when b.StartsWith("show"):
                        Console.WriteLine("\n------To Do List-----");
                        foreach (var task in toDoList)
                        {
                            Console.WriteLine(task);
                        }
                        Console.WriteLine("---------------------\n");
                        break;
                    //clear the list
                    case string c when c.Equals("--"):
                        toDoList.Clear();
                        Console.WriteLine("To Do List cleared\n");
                        break;
                    //add item to the To Do list
                    case string d when d.StartsWith("+"):
                        var index = d.IndexOf("+");
                        var add_item = d.Substring(index + 1);
                        toDoList.Add(add_item);
                        Console.WriteLine("Added {0} \n", add_item, "\n");
                        break;
                    //delete item from the To Do list
                    case string e when e.StartsWith("-"):
                        var startIndex = e.IndexOf("-");
                        var item = e.Substring(startIndex + 1);
                        if (toDoList.Contains(item))
                        {
                            toDoList.Remove(item);
                            Console.WriteLine("Removed {0} \n", item);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not currently in the list, it cannot be removed", item, "\n");
                        }
                        break;
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var todolist = new ToDo();
            todolist.ListItems();
        }
    }
}
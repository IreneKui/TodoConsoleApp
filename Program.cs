using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();
            while(true)
            {
            Console.Clear();
            Console.WriteLine("-------Min Todo-App--------");
            Console.WriteLine("--Välj vad du vill göra genom att välja bokstav--");
            Console.WriteLine("[L]ägga till Todo");
            Console.WriteLine("[V]ad har jag att göra i Todo-lista?");
            Console.WriteLine("[M]arkera Todo som klar");
            Console.WriteLine("[T]a bort en Todo");
            Console.WriteLine("[A]vsluta Todo");
            Console.WriteLine("---------------------------");

            string input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "L":
                    Console.WriteLine("Skriv in i Todo-lista:");
                    todoManager.AddTodoItem(Console.ReadLine());
                    
                //Test-code
                    todoManager.AddTodoItem("Rasta hunden");
                    todoManager.AddTodoItem("Rasta den andra hunden");
                    todoManager.AddTodoItem("Rasta papegojan");
                    
                    WriteListToConsole(todoManager.ListTodoItems());
                    Console.ReadLine();
                    break;

                case "V":
                    WriteListToConsole(todoManager.ListTodoItems());
                    Console.WriteLine("Tryck enter");
                    Console.ReadLine();
                    break;
                    
                case "M":
                    //todoManager.ListOfTodoItems[1].CompleteTodo();
                    WriteListToConsole(todoManager.ListTodoItems());
                    Console.WriteLine("Vilken Todo är du klar med?");
                    todoManager.CompleteTodo(Convert.ToInt32(Console.ReadLine()));
                    break;

                case "T":
                    Console.WriteLine("Vilken Todo vill du ta bort?");
                    todoManager.RemoveTodoIitem(Convert.ToInt32(Console.ReadLine()));
                    break;
                    
                case "A":
                    Console.WriteLine("Avslutar Todo-app");
                    return;
                    
                default:
                    Console.WriteLine("Invalid input...");
                    break;
            }
            }


            
            // todoManager.SetTodoItem(0, true);
            // todoManager.RemoveTodoItem(1);
        }
        private static void WriteListToConsole(List<string> listString)
        {
            // foreach (string toWrite in listString )
            for (int i = 0; i < listString.Count; i++)
            {
                Console.WriteLine((i+1) + " " + listString[i]);
            }
        }
        
    }
}
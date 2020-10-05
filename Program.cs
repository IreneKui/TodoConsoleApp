using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main()
        {
            TodoManager todoManager = new TodoManager();

            //Test-code, add user interface here later
            Console.WriteLine("Skriv in i Todo-lista:");
            todoManager.AddTodoItem(Console.ReadLine());
            todoManager.AddTodoItem("Rasta hunden");
            todoManager.AddTodoItem("Rasta den andra hunden");
            todoManager.AddTodoItem("Rasta papegojan");

            // WriteListToConsole(todoManager.ListTodoItems());
            //todoManager.ListOfTodoItems[1].CompleteTodo();
            WriteListToConsole(todoManager.ListTodoItems());
            Console.WriteLine("Vilken Todo är du klar med?");
            todoManager.CompleteTodo(Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("Vilken Todo vill du ta bort?");
            todoManager.RemoveTodoIitem(Convert.ToInt32(Console.ReadLine()));
            WriteListToConsole(todoManager.ListTodoItems());
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
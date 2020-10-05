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
            todoManager.AddTodoItem("Rasta hunden");
            todoManager.AddTodoItem("Rasta den andra hunden");
            todoManager.AddTodoItem("Rasta papegojan");

            WriteListToConsole(todoManager.ListTodoItems());

            // todoManager.SetTodoItem(0, true);
            // todoManager.RemoveTodoItem(1);
        }
        private static void WriteListToConsole(List<string> listString)
        {
            foreach (string toWrite in listString )
            {
                Console.WriteLine(toWrite);
            }
        }
    }
}
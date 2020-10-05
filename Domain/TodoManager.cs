using System.Collections.Generic;
class TodoManager
{
    List<Todo> ListOfTodoItems = new List<Todo>();
    public void AddTodoItem(string item)
    {   
        Todo newTodoItem = new Todo(item);  //Sends to constructor
        /*newTodoItem.Title = item; //can use this instead of constructor*/
        ListOfTodoItems.Add(newTodoItem);   //Creates a new object
    }
    public List<string> ListTodoItems()
    {  
        List<string> returnList = new List<string>();
        foreach (Todo todo in ListOfTodoItems)
        {
            returnList.Add(todo.ToString());
        }
        return returnList;
    } 
}
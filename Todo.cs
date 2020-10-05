class Todo
{
    //Property
    public string Title 
    {
        get; set;
    }
    public bool isDone = false;

    public Todo(string title)   //Constructor
    {
        Title = title;
    }
    public void CompleteTodo()
    {
        isDone = true;
    }

    public override string ToString()
    {
        if(isDone)
        {
            return Title + "| är klar";
        }
        else
        {
            return Title + "| inte klar";
        }
    }
}
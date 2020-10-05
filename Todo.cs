class Todo
{
    //Property
    public string Title 
    {
        get; set;
    }
    public bool isDone;

    public Todo(string title)   //Constructor
    {
        Title = title;
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
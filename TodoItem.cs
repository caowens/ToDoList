class TodoItem
{
    public int Id { get; set;}
    public string Description { get; set;}
    public bool IsCompleted {get; set;}

    public TodoItem(int id, string description)
    {
        Description = description;
        IsCompleted = false;
        Id = id;
    }

    override public string ToString()
    {
        return $"{Id} {(IsCompleted ? "[X]" : "[ ]" )} {Description}";
    }
}
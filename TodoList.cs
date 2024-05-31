class TodoList
{
    public List<TodoItem> Items;
    public int NextId { get; set; }

    public TodoList()
    {
        Items = new List<TodoItem>();
        NextId = 1;
    }

    public void AddItem(TodoItem item)
    {
        Items.Add(item);
        NextId++;
    }

    public void DisplayItems()
    {
        foreach (TodoItem item in Items)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void RemoveItem(int id)
    {
        TodoItem? item = Items.Find(i => i.Id == id);

        if (item != null)
        {
            Items.Remove(item);
        }
        else
        {
            Console.WriteLine("A task does not exist at that Id.");
        }
    }

    public void MarkItemAsCompleted(int id)
    {
        TodoItem? item = Items.Find(i => i.Id == id);
        
        if (item != null)
        {
            item.IsCompleted = true;
        }
    }
}
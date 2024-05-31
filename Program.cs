TodoList todoList = new TodoList();

TodoItem item = new TodoItem(todoList.NextId, "Walk the dog");
todoList.AddItem(item);

item = new TodoItem(todoList.NextId, "Take out the trash");
todoList.AddItem(item);

item = new TodoItem(todoList.NextId, "Take out the trash");
todoList.AddItem(item);

todoList.MarkItemAsCompleted(item.Id);

todoList.DisplayItems();
string? readResult;
bool validEntry = false;
string menuSelection = "";
TodoList todoList = new TodoList();

do
{
    Console.Clear();

    Console.WriteLine("Welcome to the To-do List app. Your main menu options are:");
    Console.WriteLine(" 1. Display all tasks");
    Console.WriteLine(" 2. Add a new task");
    Console.WriteLine(" 3. Remove a task");
    Console.WriteLine(" 4. Mark a task as completed");
    Console.WriteLine(" 5. Edit a task");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        // Display To-do List
        case "1":
            Console.WriteLine();
            Console.WriteLine("ID\tTask");
            Console.WriteLine("--\t----");
            todoList.DisplayItems();

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
        
        // Add a new task
        case "2":
            do 
            {
                Console.WriteLine("Enter a description for this task: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    TodoItem item = new TodoItem(todoList.NextId, readResult);
                    todoList.AddItem(item);
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            } while (validEntry != true);

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
        
        // Remove a task
        case "3":
            do 
            {
                Console.WriteLine("Enter the ID of the task you want to remove: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    validEntry = int.TryParse(readResult, out int id);
                    if (validEntry != false)
                    {
                        todoList.RemoveItem(id);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter a valid integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            } while (validEntry == false);

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
        
        // Mark a task as completed
        case "4":
            do 
            {
                Console.WriteLine("Enter the ID of the task you want to complete: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    validEntry = int.TryParse(readResult, out int id);
                    if (validEntry != false)
                    {
                        todoList.MarkItemAsCompleted(id);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter a valid integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            } while (validEntry == false);

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
        
        // Edit a task
        case "5":
            do 
            {
                Console.WriteLine("Enter the ID of the task you want to edit: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    validEntry = int.TryParse(readResult, out int id);
                    if (validEntry != false)
                    {
                        Console.WriteLine("Please enter the new description:");
                        bool validDescription = false;
                        do 
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                todoList.EditItem(id, readResult);
                                Console.WriteLine($"The task description at Id {id} is now \"{readResult}\" ");
                                validDescription = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry. Please try again.");
                            }
                        } while (validDescription == false);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter a valid integer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            } while (validEntry == false);

            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;
        default:
            break;
    }
} while (menuSelection != "exit");
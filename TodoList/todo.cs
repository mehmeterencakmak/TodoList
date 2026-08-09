Console.WriteLine("Hello");

var todos = new List<string>();

bool shalExit = false;
while (!shalExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userInput = Console.ReadLine().ToUpper();
    Console.WriteLine(userInput);


    if(userInput == "S")
    {
        SeeAllTodos();
    }
    else if(userInput == "A")
    {
        addToDo();
    }
    else if(userInput == "R")
    {
        RemoveTodo();
    }
    else if(userInput == "E")
    {
        shalExit = true;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}

Console.ReadKey();

void addToDo()
{
    bool isValidDescription = false;
    while (!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description:");
        var description = Console.ReadLine() ;    

        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("The description connot be empty.");
        }
        else if(todos.Contains(description))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            isValidDescription = true;
            todos.Add(description);
            Console.WriteLine("TODO succesfully added: " + description);            
        }
        
    }
    
}

void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet. ");
    }
    else
    {
        for(int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }
    }
}

void RemoveTodo()
{
    if(todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet. ");
        return;
    }
    bool isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine("Select the index of the TODO you want to remove: ");
        SeeAllTodos();
        var userInput = Console.ReadLine();
        if(userInput == "")
        {
            Console.WriteLine("Selected index connot be empty");
            continue;
        }
        if(int.TryParse(userInput, out int index) && 
            index >= 1 &&
            index <= todos.Count)
        {
            var indexOfToDo = index -1;
            var todoToBeRemoved = todos[indexOfToDo];
            todos.RemoveAt(indexOfToDo);
            isIndexValid = true;
            Console.WriteLine("TODO removed:" + todoToBeRemoved);
        }
        else
        {
            Console.WriteLine("The given index is not valid.");
        }
    }
    
}
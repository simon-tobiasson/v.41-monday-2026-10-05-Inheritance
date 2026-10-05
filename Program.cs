/*
 * TodoApp
 * 1. Visa sina todos (läs in en fil med olika todos)
 * 2. Lägga till en ny todo
 * 3. Ändra en todo
 * 4. Ta bort en todo */

using System.Text.Json;
using ToDoApp;

string jsonFile = File.ReadAllText("todos.json");

Console.WriteLine($"Läser/skriver till: {Path.GetFullPath("todos.json")}");
//Console.WriteLine(jsonFile);

List<ToDo> todos = JsonSerializer.Deserialize<List<ToDo>>(jsonFile);

while (true)
{
    Console.WriteLine("----- ToDoApp -----");
    Console.WriteLine("1. Visa dina todos");
    Console.WriteLine("2. Lägg till en ny todo");
    Console.WriteLine("3. Ta bort en todo");
    Console.WriteLine("4. Avsluta");

    Console.Write("Välj ett alternativ: ");

    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        foreach (ToDo todo in todos)
        {
            Console.WriteLine($"---- Todo {todo.Id} ----");
            Console.WriteLine($"Text: {todo.Text}");
            Console.WriteLine($"Är klar: {todo.Done}\n");
        }
    }

    else if (choice == 2)
    {
        Console.WriteLine("Vad vill du lägga till i din todo list?");
        string text = Console.ReadLine();
        todos.Add(new ToDo
        {
            Id = todos.Count + 1,
            Text = text,
            Done = false
        });

        string jsonText = JsonSerializer.Serialize(todos, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText("todos.json", jsonText);
    }

    else if (choice == 3)
    {
        foreach (ToDo todo in todos)
        {
            Console.WriteLine($"---- Todo {todo.Id} ----");
            Console.WriteLine($"Text: {todo.Text}");
            Console.WriteLine($"Är klar: {todo.Done}\n");
        }

        Console.WriteLine("Vilken todo vill du ta bort?");
        int numberChoice = int.Parse(Console.ReadLine());
        ToDo toBeRemoved = null;

        foreach (ToDo todo in todos)
        {
            if (todo.Id == numberChoice)
            {
                toBeRemoved = todo;
            }
        }

        todos.Remove(toBeRemoved);
    }

    else if (choice == 4)
    {
        break;
    }

    else
    {
        Console.WriteLine("Ogiltigt val\n");
    }
}




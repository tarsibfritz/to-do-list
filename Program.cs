// TO-DO LIST COM C#
List<string> tasks = new List<string>();
bool exit = false;

while (!exit)
{
    Console.WriteLine("=== Lista de Tarefas ===");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Exibir Tarefas");
    Console.WriteLine("3. Marcar Tarefa como Concluída");
    Console.WriteLine("4. Remover Tarefa");
    Console.WriteLine("5. Sair");

    Console.Write("\nInforme a opção desejada: ");
    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            AddTask();
            break;
        case "2":
            DisplayTasks();
            break;
        case "3":
            MarkTaskAsCompleted();
            break;
        case "4":
            RemoveTask();
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            break;
    }
    Console.WriteLine();
}


void AddTask()
{
    Console.Write("\nDigite uma nova tarefa: ");
    string newTask = Console.ReadLine();

    if (newTask == "")
    {
        Console.WriteLine("Índice inválido. Tente novamente.\n");
    }
    else 
    {
        tasks.Add(newTask);
        Console.WriteLine("Tarefa adicionada com sucesso!\n");

    }
}

void DisplayTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("\nNão há tarefas na lista.");
    }
    else
    {
        Console.WriteLine("\n=== Tarefas ===");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
}

void MarkTaskAsCompleted()
{
    Console.Write("\nDigite o número da tarefa a ser marcada como concluída: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    if (index >= 0 && index < tasks.Count)
    {
        Console.WriteLine($"A tarefa '{tasks[index]}' foi marcada como concluéda.\n");
        tasks.RemoveAt(index);
    }
    else
    {
        Console.WriteLine("Índice inválido. Tente novamente.\n");
    }
}

void RemoveTask()
{
    Console.Write("\nDigite o número da tarefa a ser removida: ");
    int index = int.Parse(Console.ReadLine()) - 1;

    if (index >= 0 && index < tasks.Count)
    {
        Console.WriteLine($"A tarefa '{tasks[index]}' foi removido.\n");
        tasks.RemoveAt(index);
    }
    else
    {
        Console.WriteLine("Índice inválido. Tente novamente.\n");
    }
}

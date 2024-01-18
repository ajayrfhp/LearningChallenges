// See https://aka.ms/new-console-template for more information
using TodoApp;

Console.WriteLine("Welcome to do list app");
ToDo toDo = new ToDo();



string item;
bool run = true;
while(run)
{
    Console.WriteLine("A for add, D for done, V for view, R for reorder, T for top and any key for exit");
    string k = Console.ReadLine();
    switch (k)
    {
        case "A":
            item = Console.ReadLine();
            toDo.Add(item);
            break;
        case "D":
            try
            {
                item = Console.ReadLine();
                toDo.Done(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            break;
        case "V":
            toDo.PrintAll();
            break;
        case "T":
            int n = Int32.Parse(Console.ReadLine());
            toDo.Print(n);
            break;
        case "R":
            item = Console.ReadLine();
            try
            {
                int priority = Int32.Parse(Console.ReadLine());
                toDo.Reorder(item, priority);
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.ToString()); 
            }
                

            break;
        default:
            run = false;
            break;
    }
}

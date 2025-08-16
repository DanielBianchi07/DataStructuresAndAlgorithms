using DataStructures.Collections;

namespace DataStructures.ConsoleDemo.Examples;

public class CollectionExamples
{
    public static void Run()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("------ CollectionExamples -------");
        
        var names = new Collection();
        
        names.Add("David");
        names.Add("Bernica");
        names.Add("Raymond");
        names.Add("Clayton");
        
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        Console.WriteLine("Numero de nomes: " + names.Count());
        
        names.Clear();
        
        Console.WriteLine("Numero de nomes: " + names.Count());

        Console.WriteLine("------------ Generics ------------");
        
        int num1 = 100;
        int num2 = 200;
        
        Console.WriteLine("num1: " + num1);
        Console.WriteLine("num2: " + num2);
        
        Collection.Swap<int>(ref num1, ref num2);
        
        Console.WriteLine("num1: " + num1);
        Console.WriteLine("num2: " + num2);

        string str1 = "Sam";
        string str2 = "Tom";
        
        Console.WriteLine("str1: " + str1);
        Console.WriteLine("str2: " + str2);
        
        Collection.Swap<string>(ref str1, ref str2);

        Console.WriteLine("str1: " + str1);
        Console.WriteLine("str2: " + str2);
        
        Console.WriteLine("--------------------------------");

        Collection.Node<string> node1 = new Collection.Node<string>("Mike", null);
        Collection.Node<string> node2 = new Collection.Node<string>("Raymond", node1);
    }
}
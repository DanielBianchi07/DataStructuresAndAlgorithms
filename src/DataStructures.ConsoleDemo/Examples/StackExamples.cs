using DataStructures.StacksAndQueues;

namespace DataStructures.ConsoleDemo.Examples;

public class StackExamples
{
    public static void Run()
    {
        Stack alist = new Stack();
        string ch;
        string word = "sees";
        bool isPalindrome = true;

        for (int x = 0; x < word.Length; x++)
            alist.push(word.Substring(x,1));
        int pos = 0;
        while (alist.count > 0)
        {
            ch = alist.pop().ToString();
            if (ch != word.Substring(pos, 1))
            {
                isPalindrome = false;
                break;
            }
            pos++;
        }
        if (isPalindrome) 
            Console.WriteLine(word + " is a palindrome");
        else
            Console.WriteLine(word + " not is a palindrome");
        Console.Read();
    }
}
using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    //Write your code here
    Stack<char> temp = new Stack<char>(); // A stack is a Last In First Out (LIFO)
    Queue<char> temp1 = new Queue<char>(); // A Queue is a First in First Out (FIFO)


    /*
    for stack, let assume I have "YES"
        first is Y, second is E, third is S

    when I want to remove/pop, S will be removed first from the very top element
     */

    /*
    for queue, let assume I have "YES"
        first is Y, second is E, third is S

    when I want to remove/enqueue, Y will be removed first because it will remove from the very first element came in
     */

    public void pushCharacter(char ch)
    {
        temp.Push(ch);
    }

    public void enqueueCharacter(char ch)
    {
        temp1.Enqueue(ch);
    }

    public char popCharacter()
    {
        Console.WriteLine(temp.Peek());
        return temp.Pop();
    }

    public char dequeueCharacter()
    {
        Console.WriteLine(temp1.Peek());
        return temp1.Dequeue();
    }


    static void Main(String[] args)
    {
        // read the string s.
        string s = "yes";

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms_For_Interviews
{
    public class StringReverse
    {
        //String Reverse using for loop
        public void ReverseStringForLoop(string name)
        {
            char[] chars = name.ToCharArray();
            string reversedString = string.Empty;
            for (int i = chars.Length - 1; i > -1; i--)
            {
                reversedString += chars[i];
            }
           Console.WriteLine(reversedString);
        }

        public void ReverseStringWhileLoop(string name)
        {
            char[] chars = name.ToCharArray();
            int start = 0;
            int end = name.Length - 1;

            while(start < end)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;

                start++;
                end--;
            }
            Console.WriteLine(chars);
        }

        //String Reverse Using Stack
        public void ReverseUsingStack(string name)
        {
            char[] chars = name.ToCharArray();
            Stack stack = new Stack();
            foreach (char ch in chars)
            {
                stack.Push(ch.ToString());
            }

            string reversedString = string.Empty;
            while (stack.Count > 0)
            {
                reversedString += stack.Pop();
            }

            Console.WriteLine(reversedString);
        }

    }
}

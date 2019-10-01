using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodilityChalanges
{
    public class VerizonTask2
    {
        public int solution(string v)
        {
            int result = -1;

            try {
                string[] ssize = v.Split(new char[0]);
                Stack<int> myStack = new Stack<int>();
                

                for (int i = 0; i < ssize.Length; i++)
                {
                    int number;
                    if (Int32.TryParse(ssize[i], out number))
                    {
                        myStack.Push(number);
                    }
                    else if (ssize[i].ToString().ToUpper().Equals("DUP"))
                    {
                        var value = myStack.Pop();
                        myStack.Push(value);
                        myStack.Push(value);
                    }
                    else if (ssize[i].ToString().ToUpper().Equals("+"))
                    {
                        int value1 = myStack.Pop();
                        int value2 = myStack.Pop();
                        int plusVar = value1 + value2;
                        myStack.Push(plusVar);

                    }
                    else if (ssize[i].ToString().ToUpper().Equals("-"))
                    {
                        int first = myStack.Pop();
                        int second = myStack.Pop();
                        int subtractResult = first - second;
                        myStack.Push(subtractResult);
                    }
                    else if (ssize[i].ToString().ToUpper().Equals("POP"))
                    {
                        myStack.Pop();
                    }
                }

                result = myStack.Pop();

            }
            catch (Exception ex) {

                result = - 1;
            }

            return result;
        }

    }
}
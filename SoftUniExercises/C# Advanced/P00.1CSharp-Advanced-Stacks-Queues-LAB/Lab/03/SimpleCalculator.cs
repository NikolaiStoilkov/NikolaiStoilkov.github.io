using System;
using System.Linq;
using System.Collections.Generic;


namespace _03
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Stack<string> stack = new Stack<string>();
            
            for (int i = 0; i < input.Count; i++)
            {
                stack.Push(input[i]);
            }
            
            //make method
            int sum = SumNumberByOrder(stack);

            Console.WriteLine(Math.Abs(sum));
        }

        private static int SumNumberByOrder(Stack<string> stack)
        {
            // Reverse stack before start to calculate it!
            Stack<string> newStack = new Stack<string>(ReverseStack(stack));


            int sum = 0;

            int countToRotate = newStack.Count();
            int[] additional = new int[countToRotate];

            string expressions = string.Empty;
            int firstNumber = 0;
            string beforeTheNumberOperators = string.Empty;
            string afterTheNumberOperators = string.Empty;
            int secondNumber = 0;
            bool ifIsAdd = false;

            for (int i = 0; i < countToRotate; i++)
            {
                newStack.TryPop(out expressions);

                if (expressions == "-" || expressions == "+")
                {
                    if(ifIsAdd == true)
                    {
                        beforeTheNumberOperators += expressions;
                        secondNumber += int.Parse(newStack.Pop());
                        sum += MakeSum(firstNumber, secondNumber, beforeTheNumberOperators);
                        firstNumber = 0;
                        secondNumber = 0;
                        beforeTheNumberOperators = string.Empty;
                        ifIsAdd = false;
                    }
                    else
                    {
                        if (newStack.Count == 1)
                        {
                            if (afterTheNumberOperators == "+")
                            {
                                sum += int.Parse(newStack.Pop());
                            }
                            else
                            {
                                sum -= int.Parse(newStack.Pop());
                            }

                            return sum;
                        }

                        beforeTheNumberOperators = expressions;
                        newStack.TryPop(out expressions);
                        firstNumber = int.Parse(expressions);
                        newStack.TryPop(out expressions);
                        afterTheNumberOperators = expressions;
                        newStack.TryPop(out expressions);
                        secondNumber = int.Parse(expressions);
                        sum += MakeSum(beforeTheNumberOperators,firstNumber,afterTheNumberOperators,secondNumber);
                        
                    }
                    
                }
                else
                {
                    firstNumber += int.Parse(expressions);
                    ifIsAdd = true;
                    
                }
            }
            return sum;
        }

        private static Stack<string> ReverseStack(Stack<string> stack)
        {
            Stack<string> reversed = new Stack<string>();

            int count = stack.Count;
            string add = string.Empty;
            List<string> emptyRoads = new List<string>();

            for (int i = 0; i < count; i++)
            {
                stack.TryPop(out add);
                emptyRoads.Add(add);

            }

            emptyRoads.Reverse();

            for (int i = 0; i < count; i++)
            {
                reversed.Push(emptyRoads[i]);
            }

            return reversed;
        }

        private static int MakeSum(int firstNumberm, int secondNumber, string operators)
        {
            if (operators == "+")
            {
                return firstNumberm + secondNumber;
            }

            return firstNumberm - secondNumber;
        }
        
        private static int MakeSum(string beforeTheNumberOperators, int firstNumber,string afterTheNumberOperators, int secondNumber)
        {
            int sum;
            int fNum = ConvertCharsToNumber(beforeTheNumberOperators, firstNumber);
            

            if (afterTheNumberOperators == "+")
            {
                sum = fNum + secondNumber;
            }
            else
            {
                sum = fNum - secondNumber;
            }

            return sum;
        }

        private static int ConvertCharsToNumber(string operators,int numberToConcatenate)
        {
            int number = int.Parse(operators + numberToConcatenate.ToString());

            return number;
        }

        

    }
}

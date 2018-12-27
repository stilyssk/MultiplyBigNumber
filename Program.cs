using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string inputString = Console.ReadLine();
            char[] inputArrayChar = inputString.TrimStart('0').ToArray();
            char[] outputArrayChat = new char[inputArrayChar.Length];
            int inputMultiply = int.Parse(Console.ReadLine());
            int carry = 0;
            string outputSring ;

            if (inputString != "0"&&inputMultiply!=0)
            {
                for (int i = inputArrayChar.Length - 1; i >= 0; i--)
                {
                    int resultMultipy = inputMultiply * int.Parse(inputArrayChar[i].ToString()) + carry;
                    if (resultMultipy < 10)
                    {
                        outputArrayChat[i] = char.Parse(resultMultipy.ToString());
                        carry = 0;
                    }
                    else
                    {
                        outputArrayChat[i] = char.Parse((resultMultipy % 10).ToString());
                        carry = resultMultipy / 10;
                
                    }
                
                }
                outputSring = new string(outputArrayChat);
                
                if (carry > 0)
                {
                    outputSring = char.Parse(carry.ToString()) + outputSring;
                }
            }
            else
            {
                outputSring = "0";
            }
            Console.WriteLine(outputSring);
        }
    }
}

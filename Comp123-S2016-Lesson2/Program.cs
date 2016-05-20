using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Patel Rutvik
 * Date: May 17 2016
 * Date Modified: May 17, 2016
 * Description: Advanced Methods Demo for Lesson 2
 * Version:0.0.4 - added ReadUntilEnd - not completed
 */

namespace COMP123_S2016_Lesson2
{
    /**
     * Main Driver Class for Lesson 2
     * 
     * @Class Program
     */

    public class Program
    {
        /**
         * Main Methdo for our drive class
         * 
         * @Constructor Main
         * @param {string[]} args
         */

        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;

            Console.WriteLine(addXandY(x, y));
            Console.WriteLine();
            Console.WriteLine(addYtoX(ref x, ref y));

            Console.WriteLine();

            Console.WriteLine(readUntilEnd());
        }
        /**
         * Simple Methdo to add two values
         * @methdo addXandY
         * @param int firstNumber
         * @param int secondNumebr
         */
        public static int addXandY(int firstNumebr, int secondNumber)
        {
            return firstNumebr + secondNumber;
        }
        /**
         * Simple method to demonstrate pass by ref keyword
         * @method addYtoX
         * @param {ref int} X
         * @param {ref int} Y
         */
        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;
            return X;
        }
        public static string[] readUntilEnd()
        {
            string[] inputs = new string[100];
            int inputCounter = 0;
            do
            {
                Console.WriteLine("Enter a value - ('end' to stop): ");
                inputs[inputCounter] = Console.ReadLine();
                if (inputs[inputCounter] == "end")
                {
                    inputCounter = -1;
                }
                else
                {
                    inputCounter++;
                }

            } while (inputCounter != -1);
            return inputs;
        }
    }
}
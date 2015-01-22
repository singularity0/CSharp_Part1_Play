/*Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */



using System;

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Hey user, enter your unsigned int number now:");
        uint number = uint.Parse(Console.ReadLine());
        //string m = Convert.ToString(number, 2).PadLeft(32, '0');
        //Console.WriteLine(m);
        long number2, numberTrans;  //declaring transformed number - intermediate number
        numberTrans = number;
        for (int i = 3; i <6; i++)
        {
            int mask = 1 << i;
            long nAndMask = number & mask;
            long bit = nAndMask >> i;        
                if (bit == 1)
                {
                    int mask2 = 1 << (21 + i);  // To get 24 in the first cycle, then 25 and then 26
                    long nOrMask = numberTrans | mask2;
                    numberTrans = nOrMask;
                }
                else
                {
                    int mask3 = ~(1 << (21 + i));
                    long nAndMask2 = numberTrans & mask3;
                    numberTrans = nAndMask2;
                    
                }
                //string k = Convert.ToString(numberTrans, 2).PadLeft(32, '0');
                //Console.WriteLine("The new number after play with bit {0} is:{1}",i,k);
                int mask4 = 1 << (21 + i);
                long nAndMask3 = number & mask4;
                long bit2 = nAndMask3 >> (21 + i);
                if (bit2 == 1)
                {
                    int mask5 = 1 << i;
                    long nOrMask2 = numberTrans | mask5;
                    numberTrans = nOrMask2;
                }
                else
                {
                    int mask6 = ~ (1 << i);
                    long nAndMask4 = numberTrans & mask6;
                    numberTrans = nAndMask4;
                }
                //number2 = numberTrans;
                //string l = Convert.ToString(numberTrans, 2).PadLeft(32, '0');
                //Console.WriteLine("The new number after play with bit {0} is:{1}", i, l);
                //string n = Convert.ToString(numberTrans, 2).PadLeft(32, '0');
                //Console.WriteLine("The new number after play with bit {0} is:{1}", i, m);
                //int numebrTrans3 = numberTrans | numberTrans2;
         
        }
        Console.WriteLine("The new number in decimal is:{0}", numberTrans);
      
    }
}


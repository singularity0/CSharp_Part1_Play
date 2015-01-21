                                    //UNDER Developpment //
//UNDER Developpment //
//UNDER Developpment //
/*using System;

class BitExchange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey user, enter your unsigned int number now:");
        uint number = uint.Parse(Console.ReadLine());
        long numberTrans = 0; 
        string m = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine(m);
        int mask1 = 1 << 3;
        long nAndMask = number & mask1;
        long bit1 = nAndMask >> 3;
        Console.WriteLine(bit1);
        int mask2 = 1 << 4;
        long nAndMask2 = number & mask2;
        long bit2 = nAndMask2 >> 4;
        int mask3 = 1 << 5;
        long nAndMask3 = number & mask3;
        long bit3 = nAndMask3 >> 5;
        int mask4 = 1 << 24;
        long nAndMask4 = number & mask4;
        long bit4 = nAndMask4 >> 24;
        int mask5 = 1 << 25;
        long nAndMask5 = number & mask5;
        long bit5 = nAndMask5 >> 25;
        int mask6 = 1 << 26;
        long nAndMask6 = number & mask6;
        long bit6 = nAndMask6 >> 26;
        

        if (bit1 != bit4)
        {
            if (bit1 == 1)
            {
                long mask7 = 1 << 24;
                long nOrMask = number | mask7;
                long mask8 = ~(1 << 3);
                long nAndMask7 = nOrMask & mask8;
                numberTrans = nAndMask7;                  
            }
            else
            {
                long mask9 = ~(1 << 24);
                long nAndMask8 = number & mask9;
                long mask10 = 1 << 3;
                long nOrMask2 = nAndMask8 | mask10;
                numberTrans = nOrMask2;
            }
        }
        if (bit2 != bit5)
        {
            if (bit2 == 1)
            {
                long mask11 = 1 << 25;
                long nOrMask3 = numberTrans | mask11;
                long mask12 = ~(1 << 4);
                long nAndMask9 = nOrMask3 & mask12;
                numberTrans = nAndMask9;                  
            }
            else
            {
                long mask13 = ~(1 << 25);
                long nAndMask10 = numberTrans & mask13;
                long mask14 = 1 << 4;
                long nOrMask4 = nAndMask10 | mask14;
                numberTrans = nOrMask4;
            }
        }
        if (bit3 != bit6)
        {
            if (bit3 == 1)
            {
                Console.WriteLine(numberTrans);
                long mask15 = 1 << 26;
                Console.WriteLine("mask 15 -- {0}", mask15);
                string k = Convert.ToString(mask15, 2).PadLeft(32, '0');
                Console.WriteLine(k);
                long nOrMask5 = numberTrans | mask15;
                Console.WriteLine("nOrMask5 -- {0}", nOrMask5);
                string c = Convert.ToString(nOrMask5, 2).PadLeft(32, '0');
                Console.WriteLine(c);
                long mask16 = ~(1 << 5);
                Console.WriteLine("mask 16 -- {0}", mask16);
                long nAndMask11 = nOrMask5 & mask16;
                Console.WriteLine("nAndMask11 -- ", nAndMask11);
                numberTrans = nAndMask11;
                Console.WriteLine(numberTrans);
            }
            else
            {
                long mask17 = ~(1 << 26);
                long nAndMask12 = numberTrans & mask17;
                long mask18 = 1 << 5;
                long nOrMask6 = nAndMask12 | mask18;
                numberTrans = nOrMask6;
            }
        }

        Console.WriteLine("Numer tranformed is {0}", numberTrans);
    }
}

*/
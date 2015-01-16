/*Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
Submit the source code of your Visual Studio project as part of your homework submission.
*/

/*Comment: Requirements are not enough to select the best types as we are not sure what kind of operations are to be done on the delcted variables. Asumption is the values are not to be increased*/

using System;

class VarDeclare
{
    static void Main()
    {
        
        ushort VarUShort = 52130;
        sbyte VarSbyte= -115;
        uint VarUint= 4825932;
        byte Varbyte = 97;
        int VarInt = -10000;
        Console.WriteLine("Numebrs are: {0} {1} {2} {3} {4}", VarUShort, VarSbyte, VarUint, Varbyte, VarInt);
        

    }
}




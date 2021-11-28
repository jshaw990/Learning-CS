/* 
 * Interger Data Types
 * int = negative and positive, 32 bits
 * uint = positive only, 32 bits
 * byte = negative and positive, 8 bites, -128 to 127
 * sbyte = positive only, 8 bits, 0 to 255
 * long = negative and positive, 64 bits
 * ulong = positive only 64 bits
*/ 

using System;

class EntryPoint
{
    static void Main()
    {
        // Standard interger types can hold to a maximum of 2^32

        int someInterger = 265;
        int intMax = int.MaxValue;
        int intMin = int.MinValue;

        System.Console.WriteLine("Minimum Value: " + intMin);
        System.Console.WriteLine("Maximum Value: " + intMax);

        // Unsigned Intergers => uint can only be positive values 

        uint someUnsignedInt = 5;
        uint uintMin = uint.MinValue;
        uint uintMax = uint.MaxValue;

        System.Console.WriteLine("Minimum Value: " + uintMin);
        System.Console.WriteLine("Maximum Value: " + uintMax);

        // Mathimatical Functions 
        System.Console.WriteLine(Math.Pow(2, 32));

        // Byte Intergers can only calculate 256 bytes
        // Maximum value for this is 255 as 0 is accounted for by the system
        // Only positive numbers can be used

        byte someByteInt = 255;
        byte byteMin = byte.MinValue;
        byte byteMax = byte.MaxValue;

        Console.WriteLine("Minimum Value: " + byteMin);
        Console.WriteLine("Maximum Value: " + byteMax);

        // Sbyte or Short Bytes also calculates 256 bytes, but the range can include negatives

        sbyte sbyteMin = sbyte.MinValue;
        sbyte sbyteMax = sbyte.MaxValue;

        Console.WriteLine("Minimum Value: " + sbyteMin);
        Console.WriteLine("Maximum Value: " + sbyteMax);

        // Long intergers are for holding long interger values
        // It can hold 2^64

        long longMin = long.MinValue;
        long longMax = long.MaxValue;

        Console.WriteLine("Minimum Value: " + longMin);
        Console.WriteLine("Maximum Value: " + longMax);

        // ulong or UnSigned Long intergers can also hold 2^64
        // But can only hold positive values

        ulong ulongMin = ulong.MinValue;
        ulong ulongMax = ulong.MaxValue;

        Console.WriteLine("Minimum Value: " + ulongMin);
        Console.WriteLine("Maximum Value: " + ulongMax);
    }
}
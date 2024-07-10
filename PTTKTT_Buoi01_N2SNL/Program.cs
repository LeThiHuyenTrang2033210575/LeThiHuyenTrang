using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        // Khai báo và khởi tạo hai số nguyên lớn
        BigInteger a = BigInteger.Parse("123456789012345678901234567890");
        BigInteger b = BigInteger.Parse("987654321098765432109876543210");

        // Nhân hai số nguyên lớn
        BigInteger result = BigInteger.Multiply(a, b);

        // In kết quả
        Console.WriteLine("Kết quả của {0} * {1} là {2}", a, b, result);
    }
}


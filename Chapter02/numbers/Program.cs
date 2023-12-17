// unsigned integer means positive whole number
// including 0
uint naturalNumber = 23;

// integer means negative or positive whole number
// including 0
int integerNumber = -23;

// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F; 

// double means double-precision floating point
double anotherRealNumber = 2.3; // double literal

//three variables that store 2 million
///note
//0x for hex  and 0b for binary
//the underscore(_) doesn't affect the number
int decimalNotation = 2000000;//2_000_000
int binaryNotation = 0b000111101000010010000000;//0b_0001_1110_1000_0100_1000_0000
int hexdecimalNotation = 0x001E8480;//0x_001E_8480;

System.Console.WriteLine($"{nameof(decimalNotation)}: {decimalNotation}");
System.Console.WriteLine($"{nameof(binaryNotation)}: {binaryNotation}");
System.Console.WriteLine($"{nameof(hexdecimalNotation)}: {hexdecimalNotation}");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue} to {int.MaxValue}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue} to {decimal.MaxValue}.");
//if i write $"{anything}" and put :N n like "{decimal.MinValue:N0}" means print n number after the float point
//and put , in the numbers


//as we can see the double can store a very big number it could be consist of 300+ digit
//
Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3){
    Console.WriteLine($"{a} + {b} equals 0.3");
}
else{
    Console.WriteLine($"{a} + {b} does NOT equal 0.3");
}
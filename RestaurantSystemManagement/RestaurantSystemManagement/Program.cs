using System;
using System.Runtime.InteropServices;

class Program
{
    // Import the main function from the shared library
    [DllImport("restaurant", CallingConvention = CallingConvention.Cdecl)]
    public static extern int main();

    static void Main(string[] args)
    {
        // Call the C++ main function
        main();
    }
}

using System;

public class Output
{
  public static void Main()
  {
    /*
      Polimorfismo da função Console.WriteLine
    */
    int output_int       = 1;
    char output_char     = '$';
    float output_float   = 1.2f;
    double output_double = 1.2;
    string output_string = "string";

    Console.WriteLine(output_int);
    Console.WriteLine(output_char);
    Console.WriteLine(output_float);
    Console.WriteLine(output_double);
    Console.WriteLine(output_string);
  }
}

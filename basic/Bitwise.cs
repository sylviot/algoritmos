using System;

public class Bitwise
{
  public static void Main()
  {

    /* Número 31(Base 10) = 0001 1111 (base 2) */
    int N = 31;
          
    /*
      0001 1111 (31 base 2)
             << (move 1 bit)
      ---------
      0011 1110 (62 base 2)
    */
    Console.WriteLine(N << 1);
    
    
    /*
      0001 1111 (31 base 2)
             >> (remove 1 bit)
      ---------
      0000 1111 (15 base 2)
    */
    Console.WriteLine(N >> 1);
    
    /*
      0001 1111 (31 base 2)
              & (operador "E" [and])
      0000 0001 (1 base 2)
      ---------
      0000 0001 (1 base 2)
    */
    Console.WriteLine(N & 1);
    
    /*
      0001 1111 (31 base 2)
              | (operador "OU" [or])
      0000 0001 (1 base 2)
      ---------
      0001 1111 (31 base 2)
    */
    Console.WriteLine(N | 1);
    
    /*
      0001 1111 (31 base 2)
              ^ (operador "OU exclusivo" [xor])
      0000 0001 (1 base 2)
      ---------
      0001 1110 (30 base 2)
    */
    Console.WriteLine(N ^ 1);

    /*
      ~0001 1111 (31 base 2)
       ---------
      -0010 0000 (-32 base 2)
    */
    Console.WriteLine(~N);
  }
}

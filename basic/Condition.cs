using System;

public class Condition
{
  public static void Main()
  {
    /*		IF 		*/

    // IF simples (Apenas exemplo)
    if(true)/* Condição booleana */
    {
      // Se a condição for verdadeira.
    }

    // Multiplos IFs com ELSE (Apenas exemplo)
    if(true)
    {
    }
    else if(true)
    {
    }
    else
    {
      // Caso nenhuma condição dos IFs for verdadeira
    }

    // IF ternário
    string v_ou_f = 
    1 + 1 == 2     /* Condição */
    ? "Verdadeiro" /* Caso true */
    : "Falso"      /* Caso false */
    ;


    /*		SWITCH 		*/
    int number = 1;
    switch(number)
    {
      case 1:
        Console.WriteLine("Number 1");
        break;
      case 2:
        Console.WriteLine("Number 2");
        break;
      default:
        Console.WriteLine("Default");
        break;
    }
  }
}

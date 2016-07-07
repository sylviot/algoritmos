import java.util.*;
import java.lang.*;
import java.io.*;
class Condition
{
  public static void main (String[] args) throws java.lang.Exception
  {
    /*		IF 		*/

    // IF simples (Apenas exemplo)
    if(true)/* Condição booleana */
    {
    // Se a condição for verdadeira.
    }

    // Multiplos IFs (Apenas exemplo)
    if(true)
    {
    }
    else if(true)
    {
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

    // Operador ternário
    String v_ou_f = (true) ? "Verdadeiro" : "Falso";


    /*		SWITCH 		*/
    int number = 1;
    switch(number)
    {
      case 1:
      System.out.println("Number 1");
      break;
      case 2:
      System.out.println("Number 2");
      break;
      default:
      System.out.println("Default");
      break;
    }
  }
}

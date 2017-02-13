using System;

public class Loop
{
  public static void Main()
  {
    /*
      Entendendo o for:
      1.(void) Inicializador de variaveis do escopo.
      2.(bool) Condições da repetição.
      3.(void) Incrementador/Decrementador de variaveis
    */

    for(/* Inicializador */ ;  /* Condição */ ; /* Incrementador/Decrementador */){

      // Loop infinito

    }

    /* De 0 a 9 faça: */
    for(int i = 0; i < 10; i++)
    {
    }

    /* De 10 a 1 faça: */
    for(int i = 10; i > 0; i--)
    {
    }

    int i = 0;
    /* De 0 a 9 faça: */
    while(i++ < 10)
    {
      if(1 + 1 == 2)
      {
        continue;
      }

      break;
    }

    i = 10;
    /* Faça enquanto maior que 0 */
    do
    {
      if(1 + 1 == 2)
      {
        continue;
      }

      break;
    } while(--i > 0);
  }
}

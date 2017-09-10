using System;

public class BubbleSort
{
  public static void Main()
  {
    // Array de exemplo.
    int[] array = new int[] { 2, 3, 1, 5, 4 };
    
    // Resultado da ordenação do array de exemplo.
    int[] arraySorted = Bubble(array);
    
    foreach(var item in arraySorted)
    {
      Console.WriteLine(item);
    }
  }
  
  public static int[] Bubble(int[] array)
  {
    // Do primeiro ao penultimo.
    for(int a = 0; a < array.Length - 1; a++)
    {
      // A partir do "A" até o ultimo.
      for(int b = a + 1; b < array.Length; b++)
      {
        // Verificação de necessidade de troca das posição entre A e B.
        if(NeedSwap(array[a], array[b]))
        {
          Swap(array, a, b);
        }
      }
    }
    
    return array;
  }
  
  // Verifica a necessidade da troca de posição entre A e B.
  // a > b	faz com que todos da esquerda tenham que ser menor que o da direita.
  // a < b	faz com que todos da esquerda tenham que ser maior que o da direita.
  public static bool NeedSwap(int a, int b)
  {
    return a > b;
  }
  
  // Realiza a troca de posição entre A e B dentro do array.
  // aux recebe o valor de A
  // A recebe o valor de B
  // B recebe o valor de aux (valor do A antes de ser sobreescrito).
  public static void Swap(int[] array, int a, int b)
  {
    int aux = array[a];
    array[a] = array[b];
    array[b] = aux;
  }
}

using System;

public class ShellSort
{
  public static void Main()
  {
    int[] array = new int[]{3,1,2,5,4};
    int[] result = Shell(array);
    
    foreach(var item in result)
    {
      Console.WriteLine(item);
    }
  }
  
  public static int[] Shell(int[] array)
  {
    bool flag = false;
    int d = array.Length;
    
    while(flag || (d > 1))
    {
      flag = false;
      d = (d + 1) / 2;
      
      for(int i = 0; i < (array.Length - d); i++)
      {
        if(NeedSwap(array[i+d], array[i]))
        {
          Swap(array, i + d, i);
          flag = true;
        }
      }
    }
    
    return array;
  }
  
  public static bool NeedSwap(int a, int b)
  {
    return a > b;
  }
  
  public static void Swap(int[] array, int a, int b)
  {
    int aux = array[a];
    array[a] = array[b];
    array[b] = aux;
  }
}

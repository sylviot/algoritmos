using System;
 
public class Test
{
	public static void Main()
	{
		int[] array = new int[]{3,2,1,5,4};
		int[] result = Select(array);
 
		foreach(var item in result){
			Console.WriteLine(item);
		}
	}
 
	public static int[] Select(int[] array){
		for(int i = 0; i < array.Length - 1; i++ ){
			int min = i;
 
			for(int j = i + 1; j < array.Length; j++){
				if(NeedSwap(array[j], array[min])){
					min = j;
				}
			}
 
			if(min != i){
				Swap(array, i, min);
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
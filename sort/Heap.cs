using System;

public class Test
{
	public static void Main()
	{
		int[] array = new int[]{-1, 2, 1, 4, 5, 3};
		
		int[] heap = Heap(array);
		
		foreach(var item in heap){
			Console.WriteLine(item);
		}
	}
	
	static int[] Heap(int[] array){
		return Heap(array, array.Length-1);
	}
	
	static int[] Heap(int[] array, int n){
		
		BuildHeap(array, n);
		for(int i = n; i >= 2; i--){
			Console.WriteLine(">Heap {0}", i);
			Swap(array, 1, i);	
			PeneiraHeap(array, i - 1);
		}
		
		return array;
	}
	
	static void BuildHeap(int[] array, int m){
		
		for(int i = 1; i < m; i++){
			
			int f = i + 1;
			Console.WriteLine("[{0}] = {1}", f, array[f]);
			// Enquanto f maior que 1
			// Equanto pai menor que filho
			while(f > 1 && array[f / 2] < array[f]){
				Console.WriteLine(">Swap {0} -> {1}", array[f / 2], array[f]);
				Swap(array, f / 2, f);
				f /= 2;
			}
		}
	}
	
	static void PeneiraHeap(int[] array, int m){
		int p = 1, f = 2, t = array[1];

		while(f <= m){
			Console.WriteLine(">Peneira {0}", f);
			if(f < m && array[f] < array[f + 1]) f++;
			if(t >= array[f]) break;
			
			array[p] = array[f];
			p = f;
			f = 2 * p;
		}
		
		array[p] = t;
	}
	
	static void Swap(int[] array, int a, int b){
		int aux = array[a];
		array[a] = array[b];
		array[b] = aux;
	}
}
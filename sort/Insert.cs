using System;

public class InsertSort
{
	public static void Main()
	{
		// Array de exemplo.
		int[] array = new int[] { 2, 3, 1, 5, 4 };
		
		// Resultado da ordenação do array de exemplo.
		int[] arraySorted = Insert(array);
		
		foreach(var item in arraySorted){
			Console.WriteLine(item);
		}
	}
	
	public static int[] Insert(int[] array)
	{
		for(int i = 1; i < array.Length; i++)
		{
			// Point é o número que deve andar para esquerda enquanto precisar trocar (NeedSwap).
			int point = array[i];
			// Cursor é utilizado para sabe onde foi a ultima troca do Point.
			int cursor = i;

			// Enquanto cursor poder andar para esquerda (maior que zero) 
			// e ter a necessida de de trocar de posição (NeedSwap)
			while((cursor > 0) && NeedSwap(array[cursor-1], point))
			{
				// cópia o valor da esquerda para a posição atual do cursor.
				array[cursor] = array[cursor - 1];
				// cursor movendo para esquerda
				cursor--;
			}
			
			// posição até onde o cursor se moveu deve receber o valor do point
			array[cursor] = point;
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
}
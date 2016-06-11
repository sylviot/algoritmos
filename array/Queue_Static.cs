using System;

public class ArrayMain
{
	public static void Main()
	{
		Queue queue = new Queue(5);
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);
		queue.Enqueue(4);
		queue.Enqueue(5);
		queue.Enqueue(6);

		Console.WriteLine("Dequeue > {0}", queue.Dequeue());
		Console.WriteLine("Dequeue > {0}", queue.Dequeue());
		Console.WriteLine("Dequeue > {0}", queue.Dequeue());
		Console.WriteLine("Dequeue > {0}", queue.Dequeue());
		Console.WriteLine("Dequeue > {0}", queue.Dequeue());

		// Gera Exception por não ter mais elementos na fila.
		//Console.WriteLine("Dequeue > {0}", queue.Dequeue());
	}
}

public class Queue
{
	int length, current;
	int[] queue;
	/*
		Método contrutor da fila recebe o tamanho
	*/
	public Queue(int length)
	{
		// Inicia a fila com o tamanho determinado
		queue = new int[length];

		this.length = length;
		current = -1;
	}
	/*
		Verifica se a fila não está cheia e adiciona o elemento.
	*/
	public void Enqueue(int element)
	{
		if(current + 1 == length) return;

		queue[++current] = element;
	}

	/*
		Verifica se ainda tem elementos para retirar da fila 
		e limpa a posição do elemento retirado.
	*/
	public int Dequeue()
	{
		if(current == -1) throw new Exception("Empty");

		int element = queue[0];
		for(int i = 0; i < current;i++) queue[i] = queue[i+1];

		queue[current--] = 0;

		return element;
	}
}
using System;

public class ArrayMain
{
  public static void Main()
  {
    Queue queue = new Queue();

    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);
    queue.Enqueue(4);
    queue.Enqueue(5);

    Console.WriteLine("Dequeue > {0}", queue.Dequeue());
    Console.WriteLine("Dequeue > {0}", queue.Dequeue());
    Console.WriteLine("Dequeue > {0}", queue.Dequeue());
    Console.WriteLine("Dequeue > {0}", queue.Dequeue());
    Console.WriteLine("Dequeue > {0}", queue.Dequeue());
  }
}

public class Queue
{
  int[] queue;

  public Queue()
  {
    /* Inicializando a fila vazia. */
    queue = new int[0];
  }

  /* Altere o tamanho da fila para adicionar o elemento */
  public void Enqueue(int element)
  {
    Array.Resize(ref queue, queue.Length + 1);
    queue[queue.Length - 1] = element;
  }

  /* Guarde o elemento e altere o tamanho da fila */
  public int Dequeue()
  {
    int element = queue[queue.Length - 1];
    Array.Resize(ref queue, queue.Length - 1);

    return element;
  }
}

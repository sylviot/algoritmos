using System;

public class ArrayMain
{
  public class Queue
  {
    int max, current;
    int[] queue;

    /* Método contrutor da fila recebe o tamanho */
    public Queue(int max)
    {
      /* Inicia a fila com o tamanho determinado */
      this.queue = new int[max];

      this.max = max;
      this.current = -1;
    }

    /* Verifica se a fila não está cheia e adiciona o elemento.  */
    public void Enqueue(int element)
    {
      if(this.current + 1 == this.max) return;

      this.queue[++this.current] = element;
    }

    /* Verifica se a fila não está vazia e remove um elemento. */
    public int Dequeue()
    {
      if(this.current == -1) throw new Exception("Empty");

      int element = this.queue[0];
      for(int i = 0; i < this.current;i++)
      {
        this.queue[i] = this.queue[i+1];
      }

      this.queue[this.current--] = 0;

      return element;
    }
  }

  public static void Main()
  {
    Queue queue = new Queue(5);
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

    /* Gera Exception por não ter mais elementos na fila. */
    //Console.WriteLine("Dequeue > {0}", queue.Dequeue());
  }
}

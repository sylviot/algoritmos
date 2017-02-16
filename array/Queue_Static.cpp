#include <bits/stdc++.h>

using namespace std;

class Queue {

  int *queue, max, current;
  public:
    Queue(int max)
    {
      this->queue = new int[max];

      this->max = max;
      this->current = -1;
    }

    void enqueue(int element){
      if( this->current + 1 == this->max ) return;

      this->queue[++this->current] = element;
    }

    int dequeue(){
      if( this->current == -1 ) throw "Empty";

      int element = this->queue[0];
      for(int i = 0; i < this->current; i++){
        queue[i] = queue[i+1];
      }

      this->queue[current--] = 0;

      return element;
    }
};

int main()
{
  Queue queue(5);
  queue.enqueue(1);
  queue.enqueue(2);
  queue.enqueue(3);
  queue.enqueue(4);
  queue.enqueue(5);

  printf("Dequeue > %d\n", queue.dequeue());
  printf("Dequeue > %d\n", queue.dequeue());
  printf("Dequeue > %d\n", queue.dequeue());
  printf("Dequeue > %d\n", queue.dequeue());
  printf("Dequeue > %d\n", queue.dequeue());

  /* Gera Exception por não ter mais elementos na fila */
  //printf("Dequeue > %d\n", queue.dequeue());

  return 0;
}

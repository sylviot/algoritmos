#include <bits/stdc++.h>

using namespace std;

class Queue{

  int *queue, max;

  public:
    Queue(){
      this->queue = new int[0];
      this->max = 0;
    }

    void enqueue(int element) {
      int *temp = new int[this->max];

      memcpy(temp, this->queue, this->max * sizeof(int));

      this->queue = new int[this->max + 1];
      for(int i = 0; i < this->max; i++) {
        this->queue[i] = temp[i];
      }

      this->queue[this->max] = element;
      this->max++;
    }

    int dequeue(){
      int element = this->queue[0];

      int *temp = new int[this->max];
      memcpy(temp, this->queue, this->max * sizeof(int));

      this->queue = new int[this->max - 1];

      for(int i = 1; i < this->max; i++) {
        this->queue[i-1] = temp[i];
      }
      
      return element;
    }
};

int main()
{
  Queue queue;
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

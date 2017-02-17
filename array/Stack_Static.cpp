#include <bits/stdc++.h>

using namespace std;

class Stack {
  int *stack, current, max;
  public:
  Stack(int max) {
    this->max = max;
    this->stack = new int[this->max];
    this->current = -1;
  }

  void push(int element) {
    if( this->current + 1 == this->max ) throw "Stack over flow";

    this->stack[++current] = element;
  }
  
  int pop() {
    if( this->current < 0 ) throw "Empty";

    return this->stack[current--];
  }
};

int main() {

  Stack stack(5);

  stack.push(5);
  stack.push(4);
  stack.push(3);
  stack.push(2);
  stack.push(1);

  printf("Pop > %d\n", stack.pop());
  printf("Pop > %d\n", stack.pop());
  printf("Pop > %d\n", stack.pop());
  printf("Pop > %d\n", stack.pop());
  printf("Pop > %d\n", stack.pop());

  /* Remover elementos da pilha vazia causa erro. */
  //printf("Pop > %d\n", stack.pop());

  return 0;
}

#include <bits/stdc++.h>

using namespace std;

class Stack {
  int *stack, max;
  
  public:
  Stack() {
    this->stack = new int[0];
    this->max = 0;
  }

  void push(int element) {
    int *temp = new int[this->max + 1];
    memcpy(temp, this->stack, this->max * sizeof(int));

    this->stack = new int[this->max + 1];
    for(int i = 0; i < this->max; i++) {
      this->stack[i] = temp[i];
    }
    this->stack[this->max] = element;
    this->max++;
  }

  int pop() {
    if( this->max == 0 ) throw "Empty";


    int element = this->stack[this->max -1];

    int *temp = new int[this->max -1];
    memcpy(temp, this->stack, (this->max - 1) * sizeof(int));
    
    this->stack = new int[this->max - 1];
    for(int i = 0; i < this->max - 1; i++) {
      this->stack[i] = temp[i];
    }

    this->max--;

    return element;
  }
};

int main() {
  Stack stack;
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

  return 0;
}

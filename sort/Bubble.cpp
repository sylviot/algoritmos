#include <bits/stdc++.h>

using namespace std;

/* Neste exemplo, o objetivo é ordernar o array de forma crescente. 
Para que o mesmo seja decrescente, basta trocar o sinal de 'maior que' para 'menor que' */

bool need_swap(int a, int b){
	/* Condição de troca dos elementos do array */
	return a > b;
}

void swap(int * a, int * b){
	int t = *a;  /* O valor armazenado no endereço de memória representado por *a será guardado na variável t*/
	*a = *b;     
	*b = t;
}

void bubble(int array[], int array_size){
	/* O array será percorrido de dois em dois elementos */
	for(int i = 0; i < array_size-1; i++){
		for(int j = i + 1; j < array_size; j++)	{
			/* Os elementos serão analisados para saber se precisarão trocar de posição*/
			if(need_swap(array[i], array[j])){
				swap(array[i], array[j]);
			}
		}
	}
	
	return array;
}

int main(){
	/* Declarado array para ordernar */
	int array[]=  { 2, 3, 1, 5, 4 };
	/* Armazenado o tamanho do array */
	int size = sizeof(array)/sizeof(int);
	/* Chamado método de ordenamento bubblesort (método bolha) */
	bubble(array, size);

	/* Exibição do array ordenado */
	for(int a:array){
		cout << a <<endl;
	}
	
	return 0;
}

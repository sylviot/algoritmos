#include <stdio.h>

using namespace std;

int main(){
	int i;

	/*
		Entendendo o for:
		1.(void) Inicializador de variaveis do escopo.
		2.(bool) Condições da repetição.
		3.(void) Incrementador de variaveis

		for(1 ; 2 ; 3)
	*/

	// De 0 a 9 faça:
	for(/*1*/i = 0; /*2*/i < 10; /*3*/i++){

	}

	// De 10 a 1 faça:
	for(/*1*/i = 10; /*2*/i > 0; /*3*/i--){

	}

	// For infinito até ter uma quebra.
	for(/*1*/;/*2*/;/*3*/){
		break;
	}

	i = 0;
	// While usando no inicio.
	while(i++){
		if(i < 3){
			continue;
		}

		break;
	}

	i = 0;
	// while é usado após fazer.
	do{
		if(i < 3){
			continue;
		}

		break;
	} while(i++);

	return 0;
}
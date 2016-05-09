#include <stdio.h>

using namespace std;

int main() {
	/*
    %d utilizado para inteiro
    %c utilizado para caracter
    %f utilizado para float(ponto flutuante)
    %lf utilizado para double
    %s utilizado para string
    %o utilizado para octal
    %x utilizado para hexadecimal
    \n utilizado para nova linha

    Exemplo de entrada:

    1
    $
    1.2
    1.2
    string

	*/

    int input_int;
    char input_char;
    float input_float;
    double input_double;
	char input_string[255];

	scanf("%d\n", &input_int);
	scanf("%c\n", &input_char);
	scanf("%f\n", &input_float);
	scanf("%lf\n", &input_double);
	scanf("%s\n", &input_string);

	return 0;
}
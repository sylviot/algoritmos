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
	*/

    int input_int           = 1;
    char input_char         = '$';
    float input_float       = 1.2;
    double input_double     = 1.;
	char input_string[255]  = "string";

	printf("%d\n", input_int);
	printf("%c\n", input_char);
	printf("%f\n", input_float);
	printf("%lf\n", input_double);
	printf("%s\n", input_string);
	
	return 0;
}
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

    int output_int           = 1;
    char output_char         = '$';
    float output_float       = 1.2;
    double output_double     = 1.2;
	char output_string[255]  = "string";

	printf("%d\n", output_int);
	printf("%c\n", output_char);
	printf("%f\n", output_float);
	printf("%lf\n", output_double);
	printf("%s\n", output_string);
	
	return 0;
}
#include <stdio.h>

using namespace std;

int main(){
	int i = 0;
	for(i = 0; i < 10; i++){

	}

	for(i = 10; i > 0; 1--){

	}

	for(;;){
		break;
	}

	i = 0;
	while(i++){
		if(i < 3){
			continue;
		}

		break;
	}

	i = 0;
	do{
		if(i < 3){
			continue;
		}

		break;
	} while(i++);

	return 0;
}
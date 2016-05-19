using System;

public class Loop
{
	public static void Main()
	{
		// De 0 a 9 faça:
		/*
			Entendendo o for:
			1.(void) Inicializador de variaveis do escopo.
			2.(bool) Condições da repetição.
			3.(void) Incrementador de variaveis
		*/
		for(/*1*/int i = 0; /*2*/i < 10; /*3*/i++)
		{
			
		}

		// De 10 a 1 faça:
		for(/*1*/int i = 10; /*2*/i > 0; /*3*/i--)
		{

		}

		// Infinito até ter uma quebra.
		for(/*1*/;/*2*/;/*3*/)
		{
			break; // Quebra do loop.
		}

		// Verifique antes de fazer.
		// Inifinito até ter uma quebra.
		while(/*2*/true)
		{
			break;
		}

		// Faça antes de verificar.
		do
		{
			break;
		} while(/*2*/true);
	}
}
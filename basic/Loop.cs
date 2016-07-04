using System;

public class Loop
{
	public static void Main()
	{
		/*
			Entendendo o for:
			1.(void) Inicializador de variaveis do escopo.
			2.(bool) Condições da repetição.
			3.(void) Incrementador de variaveis
		*/

		// De 0 a 9 faça:
		for(/*1*/int i = 0; /*2*/i < 10; /*3*/i++)
		{
			
		}

		// De 10 a 1 faça:
		for(/*1*/int i = 10; /*2*/i > 0; /*3*/i--)
		{

		}

		// For infinito até ter uma quebra.
		for(/*1*/;/*2*/;/*3*/)
		{
			break; // Quebra do loop.
		}

		int i = 0;
		// While usando no inicio.
		while(i++)
		{
			if(i < 3)
			{
				continue;
			}

			break;
		}

		i = 0;
		// while é usado após fazer.
		do
		{
			if(i < 3)
			{
				continue;
			}

			break;
		} while(i++);
	}
}
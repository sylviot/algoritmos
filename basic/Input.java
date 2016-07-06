import java.util.*;
import java.lang.*;
import java.io.*;
class Input
{
	public static void main (String[] args) throws java.lang.Exception
	{
    //Instanciado I/O para ler as entradas de dados;
    //Utilizado os Parses de cada tipo para converter os dados de entrada (string to X)
    Scanner scan = new Scanner(System.in);
		Integer input_int = Integer.parseInt(scan.next());
	  Character input_char = scan.next().charAt(0);
	  Float input_float = Float.parseFloat(scan.next());
	  Double input_double = Double.parseDouble(scan.next());
		String input_string = scan.next();
	}
}

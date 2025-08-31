using System;

public class Variaveis
{
	public Variaveis()
	{
		int number1 = 10;
		int number2 = 20;

		int changer = 0;

		changer = number1;
		number1 = number2;
		number2 = changer;


		Console.WriteLine(number1);
		Console.Write(number2);


	}
}

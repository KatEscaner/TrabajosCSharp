/*

	Fernández Moreno Juan José
	Práctica Evaluable Tema 2
	Ejericio 3

*/

using System;

class PracT2_E3{
	static void Main(){
		int num;
		try{
			System.Console.Write("Introduce el numero: ");
			num = System.Convert.ToInt32(System.Console.ReadLine());
			System.Console.WriteLine();
		
			if(num%2 == 0 || num < 9 || num > 26)
				throw new FormatException();
			
			num--;
			
			for(int i=0; i<=num; i++)
				System.Console.Write("*");
			System.Console.WriteLine();
			for(int i=0; i<=num-2; i++ ){
				System.Console.Write("*");
				for(int j=0; j<=num-2; j++){
					if(i == j)
						System.Console.Write("*");
					else if((num/2)+1 == i && (num/2)+1 == j)
						System.Console.Write("*");						
					else if(num-(j+2) == i)
						System.Console.Write("*");
					else
						System.Console.Write(" ");
					
				}
				System.Console.Write("*");
				System.Console.WriteLine();
					
				}
			for(int i=0; i<=num; i++)
				System.Console.Write("*");
		}catch(Exception e){
			if(e.GetType().Name == "FormatException"){
					System.Console.WriteLine("Número de filas incorrecto");
					System.Console.WriteLine();
					System.Console.WriteLine();

				} else {
					System.Console.WriteLine(e.GetType().Name);
					System.Console.WriteLine();
				}
		
		}
		
		
	}
}

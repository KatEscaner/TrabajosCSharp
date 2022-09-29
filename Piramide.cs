class Piramide{
	static void Main(){
		int num;
		
		System.Console.Write("Introduzca un número impar: ");
		num = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine();

			if(num%2 != 0){
			for(int i=(num-1); i>0; i--)
				System.Console.Write(" ");
			
			System.Console.Write("*");
			System.Console.WriteLine();

			for(int i=2; i<num-1;i++){
				for(int j=num; j>i; j--)
					System.Console.Write(" ");
				
				for(int k=1; k<i; k++)
					System.Console.Write("*");
				
				System.Console.Write("*");
				
				for(int k=1; k<i; k++)
					System.Console.Write("*");
					
				System.Console.WriteLine();
				
			}	
		} else {
			System.Console.WriteLine("El numero introducido es par, tiene que ser impar");
		}
	}
}



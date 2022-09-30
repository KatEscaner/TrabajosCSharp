class Piramide{
	static void Main(){
		int num;
		
		System.Console.Write("Introduzca un número impar: ");
		num = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine();

			if(num%2 != 0){
			for(int i=(num-1)/2; i>0; i--)
				System.Console.Write(" ");
			
			System.Console.Write("*");
			System.Console.WriteLine();

			int count = num-2;

			while(count>0){
				for(int i=2; i<count; i+=2)
					System.Console.Write(" ");
				
				for(int j=num+1; j>count; j--)
					System.Console.Write("*");
				
					
				System.Console.WriteLine();
				count-=2;
			}	
		} else {
			System.Console.WriteLine("El numero introducido es par, tiene que ser impar");
		}
	}
}



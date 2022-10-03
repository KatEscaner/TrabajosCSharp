/*

	Fernández Moreno Juan José
	Práctica Evaluable Tema 2
	Ejericio 2

*/

using System;

class PracT2_E2{
	static void Main(){
		int numOld=0, numNew=0, numReaded=1, countOld=0, countNew=0;
		
		while(numReaded != 0){
			try{
				System.Console.Write("Introduce el numero: ");
				numReaded = System.Convert.ToInt32(System.Console.ReadLine());
				System.Console.WriteLine();
			
				if(numNew == 0)
					numNew = numReaded;
					
				if(numNew == numReaded)
					countNew++;
				else if(numNew != numReaded){
					if(countNew > numOld){
						numOld = numNew;
						countOld = countNew;
						numNew = numReaded;
						countNew = 0;
					} else {
						numNew = numReaded;
						countNew = 0;
					}
				}
			} catch(Exception e){
				if(e.GetType().Name == "FormatException"){
					System.Console.WriteLine("Formato incorrecto vuelve a escribirlo");
					System.Console.WriteLine();
					System.Console.WriteLine();

				} else {
					System.Console.WriteLine(e.GetType().Name);
					System.Console.WriteLine();
				}
			}
		}
		System.Console.Write("El numero más repetido consecutivamente es : " + numOld);
	}
}

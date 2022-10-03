/*

	Fernández Moreno Juan José
	Práctica Evaluable Tema 2
	Ejericio 1

*/


using System;


class PracT2_E1{
	static void Main(){
		int mesActual=0, anoActual=0, mesUser, anoUser=1, edadUser=1, jovenes=0, maduros=0, mayores=0;
		string nombreUser, mesUserString="";
		bool fail = true;
		
		while(fail == true){
			try{
				System.Console.Write("Introduce el mes actual: ");
				mesActual = System.Convert.ToInt32(System.Console.ReadLine());
				System.Console.WriteLine();
		
				if(mesActual < 0 || mesActual > 12)
					throw new FormatException();
					
				System.Console.Write("Introduce el ano actual: ");
				anoActual = System.Convert.ToInt32(System.Console.ReadLine());
				System.Console.WriteLine();
				
				if(anoActual < 2000 || anoActual > 2100)
					throw new FormatException();
				
				System.Console.WriteLine();
				
				fail = false;
			} catch(Exception e) {
				if(e.GetType().Name == "FormatException"){
					System.Console.WriteLine("Formato incorrecto vuelve a escribirlo");
					System.Console.WriteLine();
				}		
			}
		}
		while(anoUser != 0){
			try{
				System.Console.Write("Introduce el nombre de la persona: ");
				nombreUser = System.Console.ReadLine();
				System.Console.WriteLine();
							
				System.Console.Write("Introduce el mes de nacimiento de " + nombreUser + " : ");
				mesUser = System.Convert.ToInt32(System.Console.ReadLine());
				System.Console.WriteLine();
				
				if(mesUser < 0 || mesUser > 12)
					throw new FormatException();
						
				System.Console.Write("Introduce el ano de nacimiento de " + nombreUser + " : ");
				anoUser = System.Convert.ToInt32(System.Console.ReadLine());
				System.Console.WriteLine();
			
				if(anoUser < 1900 || anoUser > 2100)
					throw new FormatException();
					
				switch(mesUser){
					case 1:
						mesUserString = "enero";
						break;
					
					case 2:
						mesUserString = "febrero";
						break;
					
					case 3:
						mesUserString = "marzo";
						break;
					
					case 4:
						mesUserString = "abril";
						break;
					
					case 5:
						mesUserString = "mayo";
						break;
					
					case 6:
						mesUserString = "junio";
						break;
					
					case 7:
						mesUserString = "julio";
						break;
					
					case 8:
						mesUserString = "agosto";
						break;
					
					case 9:
						mesUserString = "septiembre";
						break;
					
					case 10:
						mesUserString = "octubre";
						break;
					
					case 11:
						mesUserString = "noviembre";
						break;
					
					case 12:
						mesUserString = "diciembre";
						break;
				}
			
				if(mesUser>anoUser)
					edadUser = anoActual - anoUser;
				else
					edadUser = (anoActual - 1) - anoUser;
				System.Console.WriteLine(nombreUser + " nació en " + mesUserString + " del año " + anoUser + ". Tiene " + edadUser + " anos");

				if(edadUser < 25)
					jovenes++;
				else if(edadUser > 24 && edadUser < 50)
					maduros++;
				else
					mayores++;

				System.Console.WriteLine();
				System.Console.WriteLine();
			} catch(Exception e) {
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
	System.Console.WriteLine("Hay " + jovenes + " jovenes, " + maduros + " maduros y " + mayores + " maduros.");
	if(jovenes == 0 && maduros == 0 && mayores > 0)
		System.Console.WriteLine("Todos tienen 50 años o más");
		
	else if(mayores == 0)
		System.Console.WriteLine("Ninguno ha llegado a los 50 años");
		
	else
		System.Console.WriteLine("Hay algunos menores de 50 y otros mayores");
		
	}
}

/*
 * Created by SharpDevelop.
 * User: Byron Domínguez
 * Date: 12/01/2018
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Hola
{
	class Program
	{
		public static void Main()
		{
		
			var prueba = new Suma();
			
			int numero;
			string nombre;
			prueba.ParametrosSalida(out numero,out nombre);
			Console.WriteLine("Hola {0}, tu numero es: {1}",nombre,numero);
			
			
			prueba.ImprimirTabla(5,20,prueba.TablaDeMultiplicar(5,20));

			//Exepciones
			int[] arreloPrueba = new int[]{1,2,3};
			try{
				Console.WriteLine(arreloPrueba[5]);				
			}
			catch(Exception e){
				Console.WriteLine(e.Message);
				Console.WriteLine("Ocurrio un error. :(");
			}
			finally{
				Console.WriteLine("Ultimo elemento de la lista: {0}",arreloPrueba[arreloPrueba.Length - 1]);	
			}
			
			//Archivos
			string saludo = "Hola";
			File.WriteAllText("hola.txt",saludo);
			
			string lectura = File.ReadAllText("hola.txt");
			Console.WriteLine(lectura);
			
        	for (int i = 0; i < 6; i++){
            	Console.WriteLine(prueba.Fibonacci(i));
        		}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
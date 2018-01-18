/*
 * Created by SharpDevelop.
 * User: Byron Domínguez
 * Date: 15/01/2018
 * Time: 14:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hola
{
	/// <summary>
	/// Description of Suma.
	/// </summary>
	public class Suma
	{
		//Constructor
		public Suma(){
			//Console.WriteLine("Constructor");
		}
		
		//Destructor
		 ~Suma(){
			//Console.WriteLine("Destructor");
		}
		
		public int SumaDosNumeros(int numero1, int numero2){
				return numero1 + numero2;
		}
		
		public int SumaDeNNumeros(int [] numeros){
			var totalSuma = 0;
			if(numeros.Length == 0)
			{
				return 0;
			}
			else{
				foreach(int i in numeros){
					totalSuma += i;
				}	
				return totalSuma;				
			}
		}
		
		public float SumaDeNNumeros(float [] numeros){
			float totalSuma = 0f;
			if(numeros.Length == 0)
			{
				return 0;
			}
			else{
				for(int i = 0; i < numeros.Length; i++){
					totalSuma = totalSuma + numeros[i];
				}	
				return totalSuma;				
			}
		}
		
		public int MaxNumero(int [] numeros){
			var maximo = numeros[0];
			for (int i = 0; i < numeros.Length; i++){
				if(maximo < numeros[i]){
					maximo = numeros[i];
				}
			}
			return maximo;
		}
		
		public int MinNumero(int [] numeros){
			var minimo = numeros[0];
			for (int i = 0; i < numeros.Length; i++){
				if(minimo > numeros[i]){
					minimo = numeros[i];
				}
			}
			return minimo;
		}
		
		public int[] BubbleSortMenorAMayor(int [] numeros){
			int temp = 0;
			for (int write = 0; write < numeros.Length; write++) {
			    for (int sort = 0; sort < numeros.Length - 1; sort++) {
			        if (numeros[sort] > numeros[sort + 1]) {
			            temp = numeros[sort + 1];
			            numeros[sort + 1] = numeros[sort];
			            numeros[sort] = temp;
			        }
			    }
			}
			return numeros;
		}
		
		public int[] BubbleSortMayorAMenor(int [] numeros){
			int temp = 0;
			for (int write = 0; write < numeros.Length; write++) {
			    for (int sort = 0; sort < numeros.Length - 1; sort++) {
			        if (numeros[sort] < numeros[sort + 1]) {
			            temp = numeros[sort + 1];
			            numeros[sort + 1] = numeros[sort];
			            numeros[sort] = temp;
			        }
			    }
			}
			return numeros;
		}
		
		public int Fibonacci(int numero){
			if (numero < 0) {
				return 0;
			}
			else {
			if (numero == 0 || numero == 1){
				return numero;
				}
			}
   		 	return Fibonacci(numero - 2) + Fibonacci(numero - 1);
	
       }
		
		public int Factorial(int numero){
			if (numero < 0) {
				return 0;
			}
			else {
			if(numero == 1){
				return 1;
				}
			}
			return numero * Factorial(numero - 1);
       }
		
		public void MultiplicacionPorReferencia(ref int numero){
			numero = numero * 2;

		}
		
		public void ParametrosSalida(out int numero, out string nombre){
			numero = 50;
			nombre = "Byron";

		}
		
		public int MultiplicacionNNumeros(int [] numeros){
			var totalMultiplicacion = 1;
			if(numeros.Length == 0)
			{
				return 0;
			}
			else{
				for(int i = 0; i < numeros.Length; i++){
					totalMultiplicacion = totalMultiplicacion * numeros[i];
				}	
				return totalMultiplicacion;				
			}
		}
		
		public float MultiplicacionNNumeros(float [] numeros){
			float totalMultiplicacion = 1.00f;
			if(numeros.Length == 0)
			{
				return 0;
			}
			else{
				for(int i = 0; i < numeros.Length; i++){
					totalMultiplicacion = totalMultiplicacion * numeros[i];
				}	
				return totalMultiplicacion;				
			}
		}

		public int[,] TablaDeMultiplicar(int numeroMuliplicacion,int limite)
		{
			int[,] tabla = new int[limite,2];
			
			for(int i = 0; i < limite; i++){
				for(int j = 0; j < 2; j++){
					if(j == 0){
						tabla[i,j] = i + 1;
					}
					else{
						tabla[i,j] = numeroMuliplicacion * (i+1);
					}
				}
			}
			return tabla;
		}

		public void ImprimirTabla(int numeroMuliplicacion, int limite,int [,] tablaMultiplicar)
		{
			Console.WriteLine("Tabla de multiplicar del {0}, hasta {1}",numeroMuliplicacion,limite);
			for(int i = 0; i < limite; i++){
				for(int j = 0; j < 2; j++){
					Console.Write(tablaMultiplicar[i,j]);
					if(i < 9){
						Console.Write("   ");
					}
					else if (i >= 9 && i < 99){
						Console.Write("  ");
					}
					else if (i >= 99){
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}

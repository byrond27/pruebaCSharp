/*
 * Created by SharpDevelop.
 * User: Sercop-Admin
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
				for(int i = 0; i < numeros.Length; i++){
					totalSuma = totalSuma + numeros[i];
				}				
			}
			return totalSuma;
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

	}
}

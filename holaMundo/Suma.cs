/*
 * Created by SharpDevelop.
 * User: Sercop-Admin
 * Date: 15/01/2018
 * Time: 14:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace holaMundo
{
	/// <summary>
	/// Description of Suma.
	/// </summary>
	public class Suma
	{
		public int sumaDosNumeros(int a, int b){
				return a + b;
		}
		
		public int sumaDeNNumeros(int [] numeros){
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
		
		public int maxNumero(int [] numeros){
			var maximo = numeros[0];
			for (int i = 0; i < numeros.Length; i++){
				if(maximo < numeros[i]){
					maximo = numeros[i];
				}
			}
			return maximo;
		}
		
		public int minNumero(int [] numeros){
			var minimo = numeros[0];
			for (int i = 0; i < numeros.Length; i++){
				if(minimo > numeros[i]){
					minimo = numeros[i];
				}
			}
			return minimo;
		}
		
		public int[] bubbleSortMenorAMayor(int [] numeros){
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
		
		public int[] bubbleSortMayorAMenor(int [] numeros){
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
		
		public int fibonacci(int numero){
			if (numero == 0 || numero == 1){
				return numero;
			}
   		 	return fibonacci(numero - 2) + fibonacci(numero - 1);
	
       }
		
		public int factorial(int numero){
			if(numero == 1){
				return 1;
			}
			return numero * factorial(numero - 1);
		
       }

	}
}

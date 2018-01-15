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
				for(int i = 0; i < numeros.Length;i++){
					totalSuma = totalSuma + numeros[i];
				}				
			}
			return totalSuma;
		}

	}
}

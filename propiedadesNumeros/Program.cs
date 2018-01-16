/*
 * Created by SharpDevelop.
 * User: Sercop-Admin
 * Date: 12/01/2018
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hola
{
	class Program
	{
		public static void Main()
		{
		
			var prueba = new Suma();
			
        	for (int i = 0; i < 6; i++){
            	Console.WriteLine(prueba.Fibonacci(i));
        		}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
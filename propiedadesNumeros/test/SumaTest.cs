/*
 * Created by SharpDevelop.
 * User: Sercop-Admin
 * Date: 15/01/2018
 * Time: 14:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;


namespace Hola
{
	[TestFixture]
	public class SumaTest
	{
		[Test]
		public void Suma_DosNumeros_True()
		{
			// arrange  
			int expected = 4;
			var prueba = new Suma();
		    // act  
		    var actual = prueba.SumaDosNumeros(2,2);
		    // assert
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DosNumerosUnoNegativo_True()
		{
			// arrange  
			int expected = 0;
			var prueba = new Suma();
		    // act  
			var actual = prueba.SumaDosNumeros(-2,2);
		    // assert
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DosNumerosNegativo_True()
		{
			// arrange  
			int expected = -2;
			var prueba = new Suma();
		    // act  
		    var actual = prueba.SumaDosNumeros(-4,2);
		    // assert
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DeNNumeros_True()
		{
			// arrange
			var numeros = new int[] {1,1,1,1,1};
			int expected = 5;
			var prueba = new Suma();
			// act
			var actual = prueba.SumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DeNNumerosPositivosNegativos_True()
		{
			// arrange
			var numeros = new int[] {1,-1,-1,-1,2};
			int expected = 0;
			var prueba = new Suma();
			// act 
			var actual = prueba.SumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_SinNUmeros_True()
		{
			// arrange
			var numeros = new int[] {0};
			int expected = 0;
			var prueba = new Suma();
			// act 
			var actual = prueba.SumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Max_DeNNumeros_true()
		{
			// arrange
			var numeros = new int[] {1,100,3,4,5};
			int expected = 100;
			var prueba = new Suma();
			// act 
			var actual = prueba.MaxNumero(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Max_DeNNumerosNegativos_true()
		{
			// arrange
			var numeros = new int[] {-1,-100,-3,-4,-5};
			int expected = -1;
			var prueba = new Suma();
			// act 
			var actual = prueba.MaxNumero(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Min_DeNNumerosPositivos_true()
		{
			// arrange
			var numeros = new int[] {5,1,3,5,0,100};
			int expected = 0;
			var prueba = new Suma();
			// act 
			var actual = prueba.MinNumero(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Sort_BubbleSortMenorAMayor_true()
		{
			// arrange
			var numeros = new int[] {5,1,3,5,0,100};
			var expected = new int[]{0,1,3,5,5,100};
			var prueba = new Suma();
			// act 
			var actual = prueba.BubbleSortMenorAMayor(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Sort_BubbleSortMayorAMenor_true()
		{
			// arrange
			var numeros = new int[] {5,1,3,5,0,100};
			var expected = new int[]{100,5,5,3,1,0};
			var prueba = new Suma();
			// act 
			var actual = prueba.BubbleSortMayorAMenor(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Numero_Fibonnaci_True()
		{
			// arrange
			int numero = 6;
			int expected = 8;
			var prueba = new Suma();

			// act
			var actual = prueba.Fibonacci(numero);

			// assert 
			Assert.AreEqual(expected,actual);
		}

		[Test]
		public void Numero_Fibonnaci_False()
		{
			// arrange
			int numero = -1;
			int expected = 0;
			var prueba = new Suma();

			// act
			var actual = prueba.Fibonacci(numero);

			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Numero_Factorial_True()
		{
			// arrange
			int numero = 5;
			int expected = 120;
			var prueba = new Suma();

			// act
			var actual = prueba.Factorial(numero);

			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Numero_Factorial_False()
		{
			// arrange
			int numero = -1;
			var prueba = new Suma();
			int expected = 0;

			// act
			var actual = prueba.Factorial(numero);

			// assert 
			Assert.AreEqual(expected,actual);

		}
	}
}

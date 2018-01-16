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


namespace holaMundo
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
		    var actual = prueba.sumaDosNumeros(2,2);
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
			var actual = prueba.sumaDosNumeros(-2,2);
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
		    var actual = prueba.sumaDosNumeros(-4,2);
		    // assert
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DeNNumeros_True()
		{
			// arrange
			int [] numeros = new int[] {1,1,1,1,1};
			int expected = 5;
			var prueba = new Suma();
			// act
			var actual = prueba.sumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DeNNumerosPositivosNegativos_True()
		{
			// arrange
			int [] numeros = new int[] {1,-1,-1,-1,2};
			int expected = 0;
			var prueba = new Suma();
			// act 
			var actual = prueba.sumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_SinNUmeros_True()
		{
			// arrange
			int [] numeros = new int[] {0};
			int expected = 0;
			var prueba = new Suma();
			// act 
			var actual = prueba.sumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Max_DeNNumeros_true()
		{
			// arrange
			int [] numeros = new int[] {1,100,3,4,5};
			int expected = 100;
			var prueba = new Suma();
			// act 
			var actual = prueba.maxNumero(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Max_DeNNumerosNegativos_true()
		{
			// arrange
			int [] numeros = new int[] {-1,-100,-3,-4,-5};
			int expected = -1;
			var prueba = new Suma();
			// act 
			var actual = prueba.maxNumero(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Min_DeNNumerosPositivos_true()
		{
			// arrange
			int [] numeros = new int[] {5,1,3,5,0,100};
			int expected = 0;
			var prueba = new Suma();
			// act 
			var actual = prueba.minNumero(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Sort_BubbleSortMenorAMayor_true()
		{
			// arrange
			int [] numeros = new int[] {5,1,3,5,0,100};
			int [] expected = new int[]{0,1,3,5,5,100};
			var prueba = new Suma();
			// act 
			var actual = prueba.bubbleSortMenorAMayor(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Sort_BubbleSortMayorAMenor_true()
		{
			// arrange
			int [] numeros = new int[] {5,1,3,5,0,100};
			int [] expected = new int[]{100,5,5,3,1,0};
			var prueba = new Suma();
			// act 
			var actual = prueba.bubbleSortMayorAMenor(numeros);
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
			var actual = prueba.fibonacci(numero);

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
			var actual = prueba.factorial(numero);

			// assert 
			Assert.AreEqual(expected,actual);
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Byron Domínguez
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
			const int expected = 4;
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
			const int expected = 0;
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
			const int expected = -2;
			var prueba = new Suma();
		    // act  
		    var actual = prueba.SumaDosNumeros(-4,2);
		    // assert
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DeNNumerosEnteros_True()
		{
			// arrange
			var numeros = new int[] {1,1,1,1,1};
			const int expected = 5;
			var prueba = new Suma();
			// act
			var actual = prueba.SumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Suma_DeNNumerosFloat_True()
		{
			// arrange
			var numeros = new float[] {1.5f,1.5f,7,15.5f,1};
			const float expected = 26.5f;
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
			const int expected = 0;
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
			const int expected = 0;
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
			const int expected = 100;
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
			const int expected = -1;
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
			const int expected = 0;
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
			const int numero = 6;
			const int expected = 8;
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
			const int numero = -1;
			const int expected = 0;
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
			const int numero = 5;
			const int expected = 120;
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
			const int numero = -1;
			var prueba = new Suma();
			const int expected = 0;

			// act
			var actual = prueba.Factorial(numero);

			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Multiplicacion_PorReferencia_True()
		{
			// arrange
			int numero = 25;
			var prueba = new Suma();
			const int expected = 50;
			int actual = 0;
			// act
			prueba.MultiplicacionPorReferencia(ref numero);
			actual = numero;
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Parametros_PorSalida_True()
		{
			// arrange
			int numero;
			string nombre;
			var prueba = new Suma();
			const int expectedNumero = 50;
			const string expectedNombre = "Byron";
			
			int actualNumero = 0;
			string actualNombre = string.Empty;
			
			// act
			prueba.ParametrosSalida(out numero, out nombre);
			actualNumero = numero;
			actualNombre = nombre;
			// assert
			Assert.AreEqual(expectedNumero,actualNumero);
			Assert.AreEqual(expectedNombre,actualNombre);
		}
		
		[Test]
		public void Multiplicacion_NNumerosEnteros_True()
		{
			// arrange
			var numeros = new int[]{1,2,3,4,5,6,7,8,9};
			var prueba = new Suma();
			const int expected = 362880;
			int actual = 0;
			
			// act
			actual = prueba.MultiplicacionNNumeros(numeros);
			
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Multiplicacion_NNumerosFloat_True()
		{
			// arrange
			var numeros = new float[]{2.5f,2,5,11.33f};
			var prueba = new Suma();
			const float expected = 283.25f;
			float actual = 0;
			
			// act
			actual = prueba.MultiplicacionNNumeros(numeros);
			
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void TablaMultiplicar_NNumerosFloat_True()
		{
			// arrange
			var tabla = new int[,]{{1,2},{2,4},{3,6},{4,8},{5,10},{6,12},{7,14},{8,16},{9,18},{10,20},};
			const int limite = 10;
			const int numeroMuliplicacion = 2;
			var prueba = new Suma();
			int[,] expected = tabla;
			var actual = new int[limite,numeroMuliplicacion];
			
			// act
			actual = prueba.TablaDeMultiplicar(numeroMuliplicacion,limite);
			
			// assert 
			Assert.AreEqual(expected,actual);
		}
		
		[Test]
		public void Impimir_Tablas_True()
		{
			// arrange
			const int limite = 100;
			const int numeroMuliplicacion = 100;
			var prueba = new Suma();
			int[,] tabla = prueba.TablaDeMultiplicar(numeroMuliplicacion,limite);
			// act
			prueba.ImprimirTabla(numeroMuliplicacion,limite,tabla);
			
			// assert 
		}
		
	}
}

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
		public void sumaDosNumerosTrue()
		{
			// TODO: Add your test.
			var prueba = new Suma();
			Assert.AreEqual(4,prueba.sumaDosNumeros(2,2));
		}
		
		[Test]
		public void sumaDosNumerosUnoNegativoTrue()
		{
			// TODO: Add your test.
			var prueba = new Suma();
			Assert.AreEqual(0,prueba.sumaDosNumeros(-2,2));
		}
		
		[Test]
		public void sumaDosNumerosNegativoTrue()
		{
			// TODO: Add your test.
			var prueba = new Suma();
			Assert.AreEqual(-2,prueba.sumaDosNumeros(-4,2));
		}
		
		[Test]
		public void sumaDeNNumerosTrue()
		{
			// TODO: Add your test.
			
	// arrange  
    // act  
    // assert  
			// arrange
			int [] numeros = new int[5] {1,1,1,1,1};
			int expected = 5;
			// act 
			var prueba = new Suma();
			var actual = prueba.sumaDeNNumeros(numeros);
			// assert 
			Assert.AreEqual(expected,actual);
		}
	}
}

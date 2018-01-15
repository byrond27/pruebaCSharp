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
		public void TestMethod()
		{
			// TODO: Add your test.
			var prueba = new Suma();
			Assert.AreEqual(4,prueba.sumaDosNumeros(2,2));
		}
	}
}

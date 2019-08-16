/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 14/08/2019
 * Time: 07:48 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace andres
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string nombre="";
			int edad;
			
			Console.WriteLine ("Digite su nombre");
				nombre=Console.ReadLine();
			
			
				Console. WriteLine("Digite su edad");
				edad=int.Parse(Console.ReadLine());
			
			Console.WriteLine(nombre);
			Console.WriteLine(edad);
			
			Console. WriteLine("Su edad es: ");
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}
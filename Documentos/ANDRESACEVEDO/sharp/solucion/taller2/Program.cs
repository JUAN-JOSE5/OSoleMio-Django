/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 14/08/2019
 * Time: 08:24 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace taller2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
			int numero1;
			int numero2;
			int resultado;
			
			Console.WriteLine("Digite un numero");
			numero1= int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite otro numero");
			numero2= int.Parse(Console.ReadLine());
			
			resultado= numero1 +numero2;
				
				
			Console.WriteLine("la suma de los numeros"+resultado);
			
			
			
			
			
			
			
			
			
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
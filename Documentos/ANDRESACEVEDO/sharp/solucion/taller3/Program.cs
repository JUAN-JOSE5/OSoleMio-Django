/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 14/08/2019
 * Time: 08:53 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace taller3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double a, b, c, x;
			
			Console.WriteLine("Digite un valor para a");
			a = double.parse( Console.ReadLine);
		
			
			Console.WriteLine("Digite un valor para b");
			b=double.parse( Console.ReadLine);
		
			Console.WriteLine("Digite un valor para c");
			c=double.parse( Console.ReadLine);
		
		    
			x= a + b *((c+b)/2)+(c*c);
			
				
			Console.WriteLine("el valor de x es: "+r x);
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
using System;

namespace Org.InstitutoSerpis.Ed.Juanmi
{
	class HolaMundo
	{
		public static void Main (string[] args)
		{
			Console.Write ("Introduce tu nombre: ");
			string nombre = Console.ReadLine ();

			Console.WriteLine ("Hola " + nombre);
		}
	}
}

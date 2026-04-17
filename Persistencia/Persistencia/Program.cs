/*
 * Creado por SharpDevelop.
 * Usuario: Leonardo Rivas
 * Fecha: 17/4/2026
 * Hora: 2:19 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace Persistencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Taller");
			
			// directorio
			
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DatosIujo");
			
			
			string rutaReportes = Path.Combine(rutaRaiz, "Reportes");
			
			Console.Write(rutaRaiz);
			Console.Write(rutaReportes);
			
			if(!Directory.Exists(rutaReportes)){
				//Crea el directorio reportes
				Directory.CreateDirectory(rutaReportes);
				Console.WriteLine ("Directorio Creado correctamente");
			   }
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}

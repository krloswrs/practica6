/*
 * Created by SharpDevelop.
 * User: krlos
 * Date: 15/05/2014
 * Time: 09:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace mysqlConnect
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("          UNIVERSIDAD DE GUADALAJARA          ");
			Console.WriteLine("                   CuTonala                   ");
			Console.WriteLine("                 PROGRAMACION 3               ");
			Console.WriteLine("          Carlos Reyes Guerrero Garcia        ");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("1.-Mostrar");
			Console.WriteLine("2.-Agregar");
			Console.WriteLine("3.-Editar");
			Console.WriteLine("4.-Eliminar");
			Console.WriteLine("5.-Salir");
			int opc = int.Parse(Console.ReadLine());

			Profesor profesor = new Profesor();
			
			if(opc==1){
				profesor.mostrarTodos();
						 
			}else if(opc ==2){
				Console.WriteLine("Codigo");
				string codigo = Console.ReadLine();
				Console.WriteLine("Nombre");		
			   string nombre = Console.ReadLine();				
				profesor.insertarRegistroNuevo(codigo,nombre);

			}else if (opc ==3){				
				Console.WriteLine("id");
				string id = 
					Console.ReadLine();
				Console.WriteLine("Deseas editarlo");
				string opc1=Console.ReadLine();
				if (opc1 == "s" || opc1 == "S"){
					Console.WriteLine("Codigo");
					string codigo = Console.ReadLine();
					Console.WriteLine("Nombre");		
				    string nombre = Console.ReadLine();
					string sql="UPDATE profesor SET 'Codigo='" + codigo +"'" +
													 "Nombre ='" + nombre +"'" + 
													 "WHERE (ID= '" + id +"')";
				profesor.editarCodigoRegistro(id, codigo, nombre);
				}
											
			}else if(opc ==4){	
				Console.WriteLine("id");
				string id = 
					Console.ReadLine();
				Console.WriteLine("Deseas eliminar");
				string opc1=Console.ReadLine();
				if (opc1 == "s" || opc1 == "S"){
					string sql="DELETE profesor WHERE (ID= '" + id +"')";
				profesor.eliminarRegistroPorId(id);
				}
					
				
			}else if(opc ==5){
				
		
			}
			Console.Read();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
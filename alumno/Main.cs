/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 16/10/2014
 * Time: 01:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.*/
using System;
using System.Collections;

namespace alumno
{
	class practica3
	{
		public string nombre, codigo,indice;
		public int opc;
		public static void Main (string[] args)
		{

			practica3 pra = new practica3 ();

			Hashtable tabla = new Hashtable ();



			do {
				Console.WriteLine("ingrese codigo");
				pra.codigo = Console.ReadLine();
				Console.WriteLine("ingrese nombre");
				pra.nombre = Console.ReadLine();
				tabla.Add(pra.codigo,pra.nombre);

				Console.WriteLine("1 para ingresar mas valores");
				Console.WriteLine("2 para editar valores");
				Console.WriteLine("3 para ver valores");
				Console.WriteLine("4 para borrar valores");
				Console.WriteLine("5 para salir");
				pra.opc =int.Parse (Console.ReadLine());
				switch(pra.opc)
				{
				case 1:
					break;
				case 2:
					Console.WriteLine("ingrese codigo a editar");
					pra.indice=Console.ReadLine();
					tabla.Remove(pra.indice);

					Console.WriteLine("ingrese nuevo codigo");
					pra.codigo = Console.ReadLine();
					Console.WriteLine("ingrese nombre");
					pra.nombre = Console.ReadLine();
					tabla.Add(pra.codigo,pra.nombre);

					break;
				case 3:

					Console.WriteLine("ingrese codigo");
					pra.indice=Console.ReadLine();
					object valor = tabla [pra.indice];
					Console.WriteLine ("el nombre es : "+valor);


					break;
				case 4:
					Console.WriteLine("ingrese codigo a remover");
					pra.indice=Console.ReadLine();
					tabla.Remove(pra.indice);


					break;






				}









			}while (pra.opc!=5);

		}
	}
}

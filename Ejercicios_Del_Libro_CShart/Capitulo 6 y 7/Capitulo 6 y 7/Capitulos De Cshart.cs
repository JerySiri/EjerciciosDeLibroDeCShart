using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Capitulo_6_y_7
{
    public partial class EjerciciosLibrosForm : Form
    {
        public EjerciciosLibrosForm()
        {
            InitializeComponent();
        }

        private void Ejercicio1_6Button_Click(object sender, EventArgs e)
        {
            int cantidad = 0, salones = 0, n = 0, m = 0;
            
            float suma = 0.0f;
            float promedio = 0.0f;
            
            Console.WriteLine("Dame la cantidad de salones");
            
            salones = Convert.ToInt32(Console.ReadLine());
            
            float[][] calif = new float[salones][];
            
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}: ", n);
                
                cantidad = Convert.ToInt32(Console.ReadLine());
                
                calif[n] = new float[cantidad];
            }
            
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Salon {0}",n);
                for (m = 0; m < calif[n].GetLength(0); m++) 
                {
                    Console.Write("Dame la calificación ");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            
            Console.WriteLine(".: Información :.");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}",n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                    Console.WriteLine("El alumno {0} tiene {1} ",m, calif[n][m]);
                
            }

            
            for (n = 0; n < salones; n++)
            {
                suma = 0;
                for (m = 0; m < calif[n].GetLength(0); m++) 
                {
                    suma += calif[n][m];
                }
                promedio = suma / calif[n].GetLength(0);
                Console.WriteLine("El promedio del salon {0} es {1}", n+1, promedio);
            }
        }

        private void Ejercicio2_6Button_Click(object sender, EventArgs e)
        {
            int cantidad = 0, salones = 0, n = 0, m = 0;
            float suma = 0.0f, promedio = 0.0f, minima = 0.0f;

            Console.WriteLine("Dame la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            float[][] calif = new float[salones][];

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}: ", n);
                cantidad = Convert.ToInt32(Console.ReadLine());

                calif[n] = new float[cantidad];
            }

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificación ");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }

            Console.WriteLine(".: Información :. ");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);
                }

            }


            for (n = 0; n < salones; n++)
            {
                suma = 0;
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    suma += calif[n][m];
                }
                promedio = suma / calif[n].GetLength(0);
                Console.WriteLine("El promedio del salon {0} es {1}", n + 1, promedio);
            }

            for (n = 0; n < salones; n++)
            {
                minima = calif[n][0];
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    if (calif[n][m] < minima)
                        minima = calif[n][m];

                }
                Console.WriteLine("La nota minima del salon {0} es {1}", n + 1, minima);
            }
        }

        private void Ejercicio3_6Button_Click(object sender, EventArgs e)
        {
            int cantidad = 0, m = 0, salones = 0, n = 0;
            float suma = 0.0f, promedio = 0.0f, minima = 0.0f, mayor = 0.0f;
                     
            Console.WriteLine("Dame la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());
            
            float[][] calif = new float[salones][];
            
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}: ", n);
                cantidad = Convert.ToInt32(Console.ReadLine());
                
                calif[n] = new float[cantidad];
            }
           
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}",n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificación ");
                    calif[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            
            Console.WriteLine(".:Información:. ");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}",n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", n, calif[n][m]);
                }

            }

            
            for (n = 0; n < salones; n++)
            {
                suma = 0;
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    suma += calif[n][m];
                }
                promedio = suma / calif[n].GetLength(0);
                Console.WriteLine("El promedio del salon {0} es {1}",n + 1,promedio);
            }

            
            for (n = 0; n < salones; n++)
            {
                minima = calif[n][0];
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    if (calif[n][m] < minima)
                        minima = calif[n][m];

                }
                Console.WriteLine("La nota minima del salon {0} es {1}",n+1, minima);
            }

           
            for (n = 0; n < salones; n++)
            {
                mayor = calif[n][0];
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    if (calif[n][m] > mayor)
                        mayor = calif[n][m];

                }
                Console.WriteLine("La nota minima del salon {0} es {1}",n+1, mayor);
            }
        }

        int cantidad = 0;
        int salones = 0;
        int n = 0;
        int m = 0;
        float suma = 0.0f;
        float promedio = 0.0f;
        float minima = 0.0f;
        float mayor = 0.0f;
        float[][] calif;

        private void Ejercicio4_6Button_Click(object sender, EventArgs e)
        {
            

            Console.WriteLine("Dame la cantidad de salones"); 
            salones = Convert.ToInt32(Console.ReadLine());
            calif = new float[salones][];
           
            PedirAlumnos(calif);
            PedirCalificaciones(calif);
            Promedio(calif);
            NotaMenor(calif);
            NotaMayor(calif);
            Imprimir(calif);
        }

        public void NotaMayor(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                mayor = calificaciones[n][0];
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    if (calificaciones[n][m] > mayor)
                        mayor = calificaciones[n][m];

                }
                Console.WriteLine("La nota mayor del salon {0} es {1}", n+1,mayor);
            }
        }

        public void Promedio(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                suma = 0;
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    suma += calificaciones[n][m];
                }
                promedio = suma / calificaciones[n].GetLength(0);
                Console.WriteLine("El promedio del salon {0} es {1}", n+1, promedio);
            }
        }
        public void PedirCalificaciones(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}",n);
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificación ");
                    calificaciones[n][m] = Convert.ToSingle(Console.ReadLine());
                }
            }
            calif = calificaciones;
        }

        public void PedirAlumnos(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}: ", n);
                cantidad = Convert.ToInt32(Console.ReadLine());
                calificaciones[n] = new float[cantidad];
            }
            calif = calificaciones;
        }

        public void Imprimir(float[][] calificaciones)
        {
            Console.WriteLine( ".:Información:. ");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m, calificaciones[n][m]);
                }

            }
        }



        public void NotaMenor(float[][] calificaciones)
        {
            for (n = 0; n < salones; n++)
            {
                minima = calificaciones[n][0];
                for (m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    if (calificaciones[n][m] < minima)
                        minima = calificaciones[n][m];

                }
                Console.WriteLine("La nota minima del salon {0} es {1}", n+1, mayor);
            }
        }

        string[][] nombres;

        private void Ejercicio5_6Button_Click(object sender, EventArgs e)
        {
            nombres = new string[][] { new string[] { "pancho", "papolo", "Roberto" }, new string[] { "Juan" }, new string[] { "Panchito", "Pica piedra" } };
            Imprimir(nombres);
        }

        public void Imprimir(string[][] names)
        {

            Console.WriteLine(".:Nombres:.");
            for (int n = 0; n < names.GetLength(0); n++)
            {
                for (int m = 0; m < names[n].GetLength(0); m++)
                {
                    Console.WriteLine(names[n][m]);
                }

            }
        }

        private void Ejercicio1_7Button_Click(object sender, EventArgs e)
        {
            ArrayList salon = new ArrayList();
            int cont = 1;
            float suma = 0.0f, promedio = 0.0f;
            float[] extremos = new float[] { 100.0f, 0.0f };
            string respuesta = string.Empty;

            do
            {
                Console.Write("Ingrese la calificacion del alumno {0}: ",cont);
                salon.Add(Convert.ToSingle(Console.ReadLine()));

                if (Convert.ToSingle(salon[cont - 1]) > extremos[1])
                {
                    extremos[1] = Convert.ToSingle(salon[cont - 1]);
                }
                else if (Convert.ToSingle(salon[cont - 1]) < extremos[1] && Convert.ToSingle(salon[cont - 1]) < extremos[0])
                {
                    extremos[0] = Convert.ToSingle(salon[cont - 1]);
                }

                Console.WriteLine("Desea continuar agregando alumnos al salon? (S/N)");
                respuesta = Console.ReadLine();
            }
            while (respuesta == "S" || respuesta == "s");

            foreach (var nota in salon)
            {
                suma += Convert.ToSingle(nota);
            }
            promedio = suma / salon.Count;

            Console.WriteLine("El promedio de claificacion del curso es de: {0} puntos.", promedio);
            Console.WriteLine("La calificacion mas alta del curso es de: {0} puntos.", extremos[1]);
            Console.WriteLine("La calificacion mas baja del curso es de: {0} puntos.",extremos[0]);
        }

        private void Ejercicio2_7Button_Click(object sender, EventArgs e)
        {
            Hashtable diccionario = new Hashtable();
            int op;
            string palabra, def;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Ingresar paralabra con su definicion");
                Console.WriteLine("2- Buscar Palabra.");
                Console.WriteLine("3- Salir.");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("\nIngrese palabra");
                        palabra = Console.ReadLine();
                        Console.Write("Ingrese Definicion de palabra ingresada");
                        def = Console.ReadLine();
                        diccionario.Add(palabra, def);
                        break;

                    case 2:
                        bool existe = false;

                        Console.Write("Ingrese palabra a buscar");
                        palabra = Console.ReadLine();

                        foreach (DictionaryEntry dato in diccionario)
                        {
                            if (Convert.ToString(dato.Key) == palabra)
                                existe = true;
                        }

                        if (existe == true)
                        {
                            Console.Write("\n{0}:", palabra);
                            Console.WriteLine(diccionario[palabra]);
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Palabra No encontrada.");
                        }

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        break;
                }
            } while (op != 3);
        }

        private void Ejercicio5_7Button_Click(object sender, EventArgs e)
        {
            Hashtable telefono = new Hashtable();
            int op;
            string nombre, numero;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar contacto.");
                Console.WriteLine("2- Buscar contacto.");
                Console.WriteLine("3- Salir.");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese nombre ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese numero ");
                        numero = Console.ReadLine();

                        telefono.Add(nombre, numero);
                        break;

                    case 2:
                        bool existe = false;

                        Console.Write("Ingrese Contacto a buscar ");
                        nombre = Console.ReadLine();

                        foreach (DictionaryEntry dato in telefono)
                        {
                            if (Convert.ToString(dato.Key) == nombre)
                                existe = true;
                        }

                        if (existe == true)
                        {
                            Console.WriteLine("Nombre: {0}", nombre);
                            Console.Write("Numero Telefonico: ");
                            Console.WriteLine(telefono[nombre]);
                        }
                        else
                        {
                            Console.WriteLine("Contacto no encontrado");
                        }

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("ERROR, contacto no valido");
                        Console.ReadKey();
                        break;
                }
            } while (op != 3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre;
            string telefono;
            string direccion;

            string nombreMascota;
            string tipo;
            string raza;

            Dueño dueño;
            Mascota mascota;

            Console.WriteLine("Digite el nombre del dueño: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite el numero de telefono: ");
            telefono = Console.ReadLine();

            Console.WriteLine("Digite la direccion: ");
            direccion = Console.ReadLine();

            Console.WriteLine("Digite el nombre de la mascota: ");
            nombreMascota = Console.ReadLine();

            Console.WriteLine("Digite el tipo de mascota: ");
            tipo = Console.ReadLine();

            Console.WriteLine("Digite la raza: ");
            raza = Console.ReadLine();

            mascota = new Mascota(nombre, raza, tipo);
            dueño = new Dueño(nombre, telefono, direccion, mascota);

            Console.WriteLine(dueño.ToString());
        }

        public struct Mascota
        {
            string nombre;
            string raza;
            string tipo;

            public Mascota(string nombre, string raza, string tipo)
            {
                this.nombre = nombre;
                this.raza = raza;
                this.tipo = tipo;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre: { nombre}\t Tipo: {tipo}\tRaza: {raza} ");
                return (sb.ToString());
            }
        }

        public struct Dueño
        {
            string nombre;
            string telefono;
            string direccion;
            Mascota mascota;

            public Dueño(string nombre, string telefono, string direccion, Mascota mascota)
            {
                this.nombre = nombre;
                this.telefono = telefono;
                this.direccion = direccion;

                this.mascota = mascota;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Dueño\nNombre: { nombre}\t Telefono: {telefono}\tDireccion: {direccion}\nMascota\n{mascota.ToString()} ");
                return (sb.ToString());
            }
        }

        enum Neumaticos { Duro, Medio, Intermedio, Blando, Lluvia };
        Neumaticos neumaticos;

        private void button1_Click(object sender, EventArgs e)
        {

            neumaticos = Neumaticos.Duro;
            Console.WriteLine(neumaticos.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre;
            int cantidad;
            double precio;
            Articulos[] articulos;
            int cantidadArticulos;

            Console.WriteLine("Digite la cantidad de productos que desea registrar: ");
            cantidadArticulos = Convert.ToInt32(Console.ReadLine());
            articulos = new Articulos[cantidadArticulos];

            for (int i = 0; i < cantidadArticulos; i++)
            {
                Console.WriteLine("Digite el nombre del producto: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Digite la cantidad del producto: ");
                cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el precio del producto: ");
                precio = Convert.ToDouble(Console.ReadLine());

                articulos[i] = new Articulos(nombre, cantidad, precio);
            }

            for (int i = 0; i < cantidadArticulos; i++)
                Console.WriteLine(articulos[i].ToString());
        }

        public struct Articulos
        {
            public string nombre;
            public int cantidad;
            public double precio;

            public Articulos(String nombre, int cantidad, Double precio)
            {
                this.nombre = nombre;

                this.cantidad = cantidad;
                this.precio = precio;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre: { nombre}\nCantidad: {cantidad}\nPrecio: {precio}");
                return (sb.ToString());
            }

        }


        private void Ejercicio3_8Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(String.Format("Hora: {0:hh mm tt}\nFecha: {0:yyyy dd M}", DateTime.Now));
        }

        private void Ejercicio5_8Button_Click(object sender, EventArgs e)
        {
            string[] cadenas;
            cadenas = new string[2];

            Console.WriteLine("Ingrese la primera cadena: ");
            cadenas[0] = Console.ReadLine();

            Console.WriteLine("Ingrese la segunda cadena: ");
            cadenas[1] = Console.ReadLine();

            if (String.Compare(cadenas[0], cadenas[1]) == 1)
                Console.WriteLine("Las cadenas son iguales");
            else
                Console.WriteLine("Las cadenas son diferentes");
           
        }


    }
}

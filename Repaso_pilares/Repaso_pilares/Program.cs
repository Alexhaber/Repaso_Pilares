namespace Repaso_pilares
{
    public class Pincipal
    {
        static void Main(string[] arg)
        {
            int opt;
            bool loop = true;
            bool loop2 = true;

            string nombre;
            string apellido;
            int edad;
            int id;

            Calculo cal = new Suma();
            

            Console.WriteLine("Bienvenido\n");

            while (loop == true)
            {
                Console.WriteLine("Elija una opción: \n1-Ejem.Herencia \n2-Polimorfismo \n3-Salir \n");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opt)   
                {
                    case 1:

                        while (loop2 == true)
                        { 
                            Console.WriteLine("Elija una operación \n1-Suma \n2-Resta \n3-Multiplicaón \n");
                            opt = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (opt)
                            { 
                                
                                case 1: cal = new Suma();
                                    break;

                                case 2:  cal = new Resta();  
                                    break;

                                case 3: cal = new Mult();
                                    break;

                                default:

                                    Console.WriteLine("La suma es el default");

                                    break;
                            }

                            Console.WriteLine("Introduzca el primer numero");
                            cal.n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduzca el segundo numero");
                            cal.n2 = int.Parse(Console.ReadLine());
                            loop2 = false;
                            Console.WriteLine("\nEl resultado es " + cal.Operacion());
                            continuo();

                        }

                        continuo();
                        break;

                    case 2:

                        Console.WriteLine("Elija la cantidad de atributos: \n1-Dos \n2-Tres \n3-Cuatro \n");
                        opt = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opt)
                        { 
                            case 1:

                                Console.WriteLine("Introduzca el nombre:");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Coloque el apellido:");
                                apellido = Console.ReadLine();

                                Persona per = new Persona(nombre, apellido);
                                Console.WriteLine($"\nNombre:{per.nombre} Apellido: {per.apellido}");

                                break;

                            case 2:

                                Console.WriteLine("Introduzca el nombre:");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Coloque el apellido:");
                                apellido = Console.ReadLine();
                                Console.WriteLine("Coloque la edad:");
                                edad = int.Parse(Console.ReadLine());

                                Persona per2 = new Persona(nombre, apellido, edad);
                                Console.WriteLine($"\nNombre:{per2.nombre} - Apellido: {per2.apellido} - Edad: {per2.edad}");

                                break;

                            case 3:

                                Console.WriteLine("Introduzca el nombre:");
                                nombre = Console.ReadLine();
                                Console.WriteLine("Coloque el apellido:");
                                apellido = Console.ReadLine();
                                Console.WriteLine("Coloque la edad:");
                                edad = int.Parse(Console.ReadLine());
                                Console.WriteLine("Coloque el id:");
                                id = int.Parse(Console.ReadLine());

                                Persona per3 = new Persona(nombre, apellido, edad);
                                Console.WriteLine($"\nNombre: {per3.nombre} - Apellido: {per3.apellido} - Edad: {per3.edad} -id: {per3.id}");
                                break;

                        }

                        continuo();
                        break;

                    case 3: loop = false;
                        break;

                    default:

                        continuo();
                        break;
                
                }

                
            }

            static void continuo()
            {
                Console.WriteLine("\nPulse una tecla para continuar.....");
                Console.ReadKey();
                Console.Clear();
            };
        }
    }
}
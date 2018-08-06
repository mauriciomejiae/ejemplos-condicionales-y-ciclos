// ejemplo de if simple

namespace if1 
{
    class Program
    {
        static void Main(string[] args)
        {
            //capturar el sueldo de una persona e indicar su sueldo a pagar teniendo en cuenta el auxilio de trasnporte
            float S , SP;
            Console.WriteLine("Digite su sueldo basico ");
            S = float.Parse(Console.ReadLine());
            SP = S * 92/100;
            if (S < 1400000)
                SP = SP + 60000; 
            Console.WriteLine("El sueldo a pagar es " + SP);
            Console.ReadKey();

        }
    }
}




// ejemplo de if doble

namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            //capturar un numero e indicar si es par o impar
            int n , R;
            Console.WriteLine("Digite un numero ");
            n = int.Parse(Console.ReadLine());
            R = n % 2;
            if (R == 0)
                Console.WriteLine(n + " es un numero par");
            else
                Console.WriteLine(n + " es un numero impar");
            Console.ReadKey();

        }
    }
}


// ejemplo de if anidado o multiple

namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            //capturar el sueldo de un empleado e indicar el nivel de salud al que pertenece 700000 salario minimo
            float sueldo;
            Console.WriteLine("Digite el sueldo ");
            sueldo = float.Parse(Console.ReadLine());
            if (sueldo < 1400000)
                Console.WriteLine("Usted es de nivel A");
            else
                if (sueldo < 3500000)
                    Console.WriteLine("Usted es de nivel B");
                else
                    Console.WriteLine("Usted es de nivel C");
            Console.ReadKey();

        }
    }
}



// ejemplo de if anidado o multiple


namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            //capturar el nivel socio economico de una persona e indicar el nivel a que pertenece
            int n;

            Console.WriteLine("Digite el nivel socio economico de 1 a 6 ");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.WriteLine("usted es de nivel socioeconomico 1");
            else
                if (n == 2)
                    Console.WriteLine("usted es de nivel socioeconomico 2");
                else
                    if (n == 3)
                        Console.WriteLine("usted es de nivel socioeconomico 3");
                    else
                        if (n == 4)
                            Console.WriteLine("usted es de nivel socioeconomico 4");
                         else
                            if (n == 5)
                                Console.WriteLine("usted es de nivel socioeconomico 5");
                            else
                                Console.WriteLine("usted es de nivel socioeconomico 6");
            Console.ReadKey();

        }
    }
}


// ejemplo de switch

namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            //capturar el nivel socio economico de una persona e indicar el nivel a que pertenece
            int n;
            Console.WriteLine("Digite el nivel socio economico de 1 a 6 ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("usted es de nivel socioeconomico 1");
                    break;
                case 2:
                    Console.WriteLine("usted es de nivel socioeconomico 2");
                    break;
                case 3:
                    Console.WriteLine("usted es de nivel socioeconomico 3");
                    break;
                case 4:
                    Console.WriteLine("usted es de nivel socioeconomico 4");
                    break;
                case 5:
                    Console.WriteLine("usted es de nivel socioeconomico 5");
                    break;
                case 6:
                    Console.WriteLine("usted es de nivel socioeconomico 6");
                    break;
                default:
                     Console.WriteLine("usted digito una que no existe");
                    break;
            }
                    Console.ReadKey();

        }
    }
}



// ejemplo de ciclos


namespace if1
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, p;
            float ep;
            p = 1;
            ep = 0;/*
            while (p <= 3)
            {
                Console.WriteLine("Edad de la " + p + " persona ");
                e = int.Parse(Console.ReadLine());
                ep = ep + e;
                p = p + 1;
            }*/

            /*
            do
            {
                Console.WriteLine("Edad de la " + p + " persona ");
                e = int.Parse(Console.ReadLine());
                ep = ep + e;
                p = p + 1;
            } while (p <= 3);
            */

            for (p = 1; p <= 3; p++)
                {
                Console.WriteLine("Edad de la " + p + " persona ");
                e = int.Parse(Console.ReadLine());
                ep = ep + e;
                }

            ep = ep / (p-1);
            Console.WriteLine("la edad promedio de las " + (p - 1) + " personas es " + ep);
            Console.ReadKey();
        }
    }
}


// Ejemplo de Menus sin metodos


namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. nombre");
                Console.WriteLine("2. celular");
                Console.WriteLine("3. correo");
                Console.WriteLine("4. saludo");
                Console.WriteLine("5.Salir");
                Console.WriteLine("Digite opcion");
                op = int.Parse(Console.ReadLine());
                switch (op)
                    {
                    case 1:
                        Console.WriteLine("Hernando Arbey Robles Puentes");
                        break;
                    case 2:
                        Console.WriteLine("31339222070");
                        break;
                    case 3:
                        Console.WriteLine("hernando.robles@unad.edu.co");
                        break;
                    case 4:
                        Console.WriteLine("hola como estan");
                        break;
                    case 5:
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                    default: Console.WriteLine("digito opcion no valida");
                        break;
                }
                Console.ReadKey();
            } while (op!=5);
        }
    }
}


// Ejemplo de Menus con metodos


namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. nombre");
                Console.WriteLine("2. celular");
                Console.WriteLine("3. correo");
                Console.WriteLine("4. saludo");
                Console.WriteLine("5.Salir");
                do
                {
                    Console.WriteLine("Digite opcion");
                    op = int.Parse(Console.ReadLine());
                } while (op < 1 || op > 5);
                switch (op)
                    {
                    case 1:
                        nombre();
                        break;
                    case 2:
                        celular();
                        break;
                    case 3:
                        correo();
                        break;
                    case 4:
                        mensaje();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                }
                Console.ReadKey();
            } while (op!=5);
        }
        public static void nombre()
        {
            Console.WriteLine("Hernando Arbey Robles Puentes");
        }
        public static void celular()
        {
            Console.WriteLine("3133922070");
        }
        public static void correo()
        {
            Console.WriteLine("hernando.robles@unad.edu.co  ");
        }
        public static void mensaje()
        {
            Console.WriteLine("hola como estan");
        }
    }
}

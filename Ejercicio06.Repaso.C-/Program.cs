namespace Ejercicio06.Repaso.C{

    class Prgram
    {


        public static void Main(string[] args){

            // Solicitud al usuario que introduzca una frase.
            Console.WriteLine("INTRODUZCA UNA FRASE: ");
            string fraseIntroUsu = Console.ReadLine();

            // Creacion de un Array el cual contendra, cada uno de los caracteres Introducidas por el Usuario.
            char[] fraseUsu = new char[fraseIntroUsu.Length];

            // Bucle encargado de introducir cada uno de los caracteres de la frase introducida por el usuario.
            // En el Array Creado.
            for (int i = 0; i < fraseIntroUsu.Length; i++)
            {

                fraseUsu[i] = fraseIntroUsu[i];
                Console.WriteLine(fraseUsu[i]);

            }

            // Mostrara la frase introducida por el usuario de manera reversa.
            Console.WriteLine(fraseUsu.Reverse().ToArray());

            
   



        }


    }

}

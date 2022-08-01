using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool palindromo(string arg)
        {
            bool dromo = true;
            int t = 0;
            char[]caracteres=new char[arg.Length];
            foreach(char c in arg)
            {
                caracteres[t] = c;
                t++;
            }
            foreach (char c in arg)
            {
                t--;
                if (c == caracteres[t] )
                {
                   
                    dromo = true;
                }
                else
                {

                    dromo = false;
                    return dromo;
                }
            

            }
            return dromo;

        }

        public static int repeticion(string arg,string pt)
        {
            int t = 0;
            int f = 0;

          
           
               string [] words = arg.Split(' ');
            
           
           for (int i = 0; i < words.Length; i++)
            {
                
                if (words[t]  == pt)
                {
                    f++;
                    t++;
                    Console.WriteLine(f);
                    t = 0;
                }
                Console.ReadLine();

                
            
            }

            return f;
        }





        static void Main(string[] args)

        {
           
            bool contr = true;
            string selec = "";
            string palin = "";
            while (contr == true)
            {
                Console.Clear();
                Console.Write(".............menu............\n");
                Console.Write("use numeros para selecionar una opcion\n");
                Console.Write("1-revisar si una palabra es palindromo\n");
                Console.Write("2-revisar cuantas veces se repite una palabra\n");
                Console.Write("3-salir\n");
                selec = Console.ReadLine();
                if (selec !="1"+"2"+"3" )
                {
                    
                    switch (selec)
                    {
                        case ("1"):
                            Console.Clear();
                            Console.Write("indique la palabra que quiere revisar\n");
                            palin = Console.ReadLine();
                            bool texto = palindromo(palin);
                            if (texto == true)
                            {
                                Console.WriteLine("la palabra es palindromo\n");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("La palabra no es palindromo\n");
                                Console.ReadLine();
                            }
                            break;
                        case ("2"):
                            Console.Clear();
                            int repe = 0;
                            Console.Write("escriba un texto \n");
                            selec = Console.ReadLine();
                            Console.Write("escriba la palabra que quiere ver si se repite \n");
                            palin = Console.ReadLine();
                            repe = repeticion(selec, palin);
                            Console.WriteLine("la palabra " + palin + " se repitio " + repe + " veces\n");
                            Console.ReadLine();
                            break;
                        case ("3"):
                            contr = false;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("no ha escogido una opcion,por favor escoger entre 1,2,3");
                    Console.ReadLine();
                }
                   
            }
        }
    }
}

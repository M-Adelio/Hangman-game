using System;

namespace forca
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
        Start:


            Console.Write("Escreva uma palavra: ");
            string strpal = Console.ReadLine();


            char[] charpal = strpal.ToCharArray();
            char[] secret = new char[charpal.Length];

            for (int i = 0; i < secret.Length; i++)
            {
                secret[i] = '-';
            }

            char ltr = new char();
            int i0 = 0;
            char[] ltrs = new char[26];
            int lifes = 5;
            
            
            

        Here:

            Console.Clear();

            Console.Write("Agora adivinhe!\n");

            Console.Write("Letras usadas: "); Console.Write(ltrs); Console.WriteLine();

            Console.WriteLine(secret);

            Console.Write("Vidas: ");
            Console.WriteLine(lifes);

            Console.Write("letra escolhida: ");

            ltr = Console.ReadKey().KeyChar;

            if (Essas_Caralha_Aqui(secret, charpal) == true) { Console.Clear(); Console.WriteLine("Você venceu!!"); Console.Read(); goto End;  }

            if (FindIndex(ltrs,ltr,0) == -1)
            {
                ltrs[i0] = ltr;

                Coisos(ltr, charpal, secret, lifes);

                i0++;
            } else {}

            if (FindIndex(charpal, ltr,0) == -1)
            {
                lifes--;
            }

            if (lifes == 0) { Console.Clear(); Console.WriteLine("Você perdeu..."); Console.Read(); goto End; }

            
            
            Console.Read();
            Console.Read();

            goto Here;

       End:

            /*Console.Clear();
            Console.WriteLine("Você deseja iniciar outra partida? Se sim, digite < S >, se não, digite < N >");
            char r = Console.ReadKey().KeyChar;
            if (r == 's' || r == 'S') { goto Start; }*/

            Console.Clear();
            



        }

        static int FindIndex(char[] a, char b, int x)
        {
            for (int i = x; i < a.Length; x++ , i++)
            {
                if (a[i] == b)
                {
                    return i;
                }
                else
                {

                }
            }
            return -1;
        }
       
        static void Coisos(char ltr, char[] pal, char[] secret, int vidas)
        {
            for (int i = 0; i < pal.Length; i++)
            {
                int n = FindIndex(pal,ltr,i);
                if (n != -1)
                {
                    secret[n] = ltr;
                } else
                {
                    vidas = vidas - 1;
                }
            }
        }

        static bool Essas_Caralha_Aqui(char[] secret, char[] charpal)
        {
            int x = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                if (secret[i] == charpal[i])
                {
                    x++;
                }
            }
            if (x == charpal.Length)
            {
                return true;

            } else { return false; }
        }
        
        
    }
}

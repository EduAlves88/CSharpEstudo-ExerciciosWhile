using System;
using System.Globalization;


//Lista de Exercícios 4
//Eduardo Reis Alves


namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.
            //Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
            //Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido"
            //e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            int acerto;
            bool controle;
            int senha = 2002;
            controle = true;
            while (controle)
            {
                Console.WriteLine("Entre com a senha (Dica2002)->");
                acerto = int.Parse(Console.ReadLine());
                if (acerto == senha)
                {
                    Console.WriteLine("Acesso Permitido");
                    controle = false;
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            }
            //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.
            //Para cada ponto escrever o quadrante a que ele pertence.
            //O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            bool looper = true;

            while (looper)
            {
                Console.WriteLine("Entre com o valor de X e Y:");
                string coordXY = Console.ReadLine();
                string[] vetCoord = coordXY.Split(' ');
                float valX = float.Parse((vetCoord[0]), CultureInfo.InvariantCulture);
                float valY = float.Parse((vetCoord[1]), CultureInfo.InvariantCulture);
                if ((valX == 0) || (valY == 0))
                {
                    looper = false;
                }
                else if ((valX < 0) && (valY > 0))
                {
                    Console.WriteLine("Primeiro Quadrante!");// Q1
                }
                else if ((valX > 0) && (valY > 0))
                {
                    Console.WriteLine("Segundo Quadrante!");//Q2
                }
                else if ((valX < 0) && (valY < 0))
                {
                    Console.WriteLine("Terceiro Quadrante!");//Q3
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante!");//Q4
                }

            }
        }
    }
}

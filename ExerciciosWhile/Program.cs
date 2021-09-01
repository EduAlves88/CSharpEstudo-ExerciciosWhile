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

            }//fim while

            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível
            bool abastecimento = true;
            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;
            while (abastecimento)
            {
                Console.WriteLine("Entre com o abastecimento: ");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Fim");
                int abasteceu = int.Parse(Console.ReadLine());
                if (abasteceu == 1)
                {
                    contAlcool += 1;
                }
                if (abasteceu == 2)
                {
                    contGasolina += 1;
                }
                if (abasteceu == 3)
                {
                    contDiesel += 1;
                }
                if (abasteceu == 4)
                {
                    Console.WriteLine("Muito Obrigado!");
                    Console.WriteLine("Álcool = " + contAlcool);
                    Console.WriteLine("Gasolina = " + contGasolina);
                    Console.WriteLine("Diesel = " + contDiesel);
                    abastecimento = false;
                }


            }//fim while




        }
    }
}

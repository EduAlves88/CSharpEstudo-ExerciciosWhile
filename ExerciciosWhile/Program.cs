using System;
using System.Globalization;

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
                Console.WriteLine("Entre com a senha ->");
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



        }
    }
}

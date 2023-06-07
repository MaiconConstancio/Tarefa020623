using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaCondicoesPrimeiraParte020623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome;
            string sobreNome;
            string estado;
            string cidade;
            string bairro;
            string endereco;
            int media;
            int ViagensFezNoAno;
            int ViagensEsseAno;
            string cupomDesconto;
            string confirmarEmail;


            //int media = (ViagensFezNoAno + ViagensEsseAno) /2;

            ///double ViagensFezNoAno,ViagensEsseAno
            ///double media;



            Console.WriteLine("Seja bem-vindo a companhia MK VooS");
            Console.WriteLine("Para comecarmos, digite seu PRIMEIRO NOME:");
            primeiroNome = Console.ReadLine();

            Console.WriteLine($"Certo Sr(a) {primeiroNome}!, qual o seu SOBRENOME?:");
            sobreNome = Console.ReadLine();

            Console.WriteLine($"Ola Sr(a) {primeiroNome} {sobreNome}. Vamos continuar seu cadastro...");

            Console.WriteLine($"\nEm qual estado o Sr(a) {primeiroNome} se localiza?");
            estado = Console.ReadLine();

            Console.WriteLine($"Em qual cidade o Sr(a) se localiza?");
            cidade = Console.ReadLine();

            Console.WriteLine($"Em qual bairro o Sr(a) Se localiza?");
            bairro = Console.ReadLine();

            Console.WriteLine($"E por ultimo, qual o endereco do Sr(a)?");
            endereco = Console.ReadLine();

            Console.WriteLine($"O Sr(a) {sobreNome} mora na cidade de {cidade} - {estado}, no endereco {endereco}, localiza no bairro {bairro}.");

            Console.WriteLine($"\n\nQuantoas viagens o Sr(a) {sobreNome} fez no ano passado?");
            ViagensFezNoAno = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n\nE quantas viagens você vai fazer esse ano");
            ViagensEsseAno = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{sobreNome} você tem um total de {ViagensFezNoAno + ViagensEsseAno} viagens!");

            Console.WriteLine($"Faltam {10 - (ViagensFezNoAno + ViagensEsseAno)} viagens, para completar 10 viagens.");

            media = (ViagensFezNoAno + ViagensEsseAno) / 2;
            Console.WriteLine($"Sua média de viagens é de {media}");


            ///if(media >=10)
            /// {
            ///    Console.Writeline("Acima da média");
            ///  }
            ///else
            ///  {
            ///    Console.WriteLine("abaixo da média");
            ///  }

            Console.WriteLine("Digite seu cupom de desconto");
            cupomDesconto = Console.ReadLine();

            if (cupomDesconto == "Conradito10")
            {
                Console.WriteLine("Parabéns você recebeu 10% de desconto na sua próxima viagem");
            }
            else
            {
                Console.WriteLine("Esse cupom não existe");
            }


            Console.WriteLine("Você gostaria de receber promoções no seu e-mail? Digite sim ou não: ");
            confirmarEmail = Console.ReadLine();

            if (confirmarEmail == "sim")
            {
                Console.WriteLine($"Obrigado Sr(a) {primeiroNome} por se registrar, se você receberá novos e-mails em breve!");
            }
            else
            {
                Console.WriteLine("Ok, você não receberá e-mails de promoções!");
            }


            Console.WriteLine("Obrigado, volte sempre!");
        }
    }
}

using System;
using Exercicio3.Modelos;

namespace Exercicio3
{
    class Program
    {
        // Este é o espaço que tenho na minha estante para uma televisão
        private static Televisao _televisao;

        // Este é o espaço que tenho para guardar um controle remoto
        private static ControleRemoto _controleRemoto;

        static void Main(string[] args)
        {
            Console.WriteLine("Meu deus, minha televisão nova chegou!");
            _televisao = new Televisao();

            Console.WriteLine("Meu controle também!");
            _controleRemoto = new ControleRemoto();

            Console.WriteLine("Vamos testar ela!");
            Console.ReadKey();
            ControlarControleRemoto();
        }

        static void ControlarControleRemoto()
        {
            Console.Clear();
            Console.WriteLine("Para usar o controle remoto você precisa sincronizar com a televisão");
            Console.WriteLine("Escolhe uma opção:");
            Console.WriteLine("1. Sincronizar controle com televisão");
            Console.WriteLine("2. Aumentar volume");
            Console.WriteLine("3. Diminuir volume");
            Console.WriteLine("4. Próximo canal");
            Console.WriteLine("5. Canal anterior");
            Console.WriteLine("6. Mudar para canal específico");
            Console.WriteLine("0. Sair do programa");

            var opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    _controleRemoto.SincronizarComTelevisao(_televisao);
                    Console.WriteLine("Controle sincronizado!");
                    break;

                case 2:
                    _controleRemoto.AumentarVolume();
                    break;

                case 3:
                    _controleRemoto.DiminuirVolume();
                    break;

                case 4:
                    _controleRemoto.ProximoCanal();
                    break;

                case 5:
                    _controleRemoto.CanalAnterior();
                    break;
                
                case 6:
                    MudarParaCanalEspecifico();
                    break;

                default:
                    TerminarAplicação();
                    break;
            }

            Console.Clear();
            Console.Write(_televisao.InfoDaTelevisao);
            Console.ReadKey();
            ControlarControleRemoto();
        }

        static void MudarParaCanalEspecifico()
        {
            Console.Clear();
            Console.WriteLine("Escolhe o canal específico que quer mudar:");
            var opcao = Convert.ToInt16(Console.ReadLine());
            _controleRemoto.MudarParaCanalEspecifico(opcao);
        }

        static void TerminarAplicação()
        {
            Console.Clear();
            Console.WriteLine("Até mais :)");
            Environment.Exit(0);
        }
    }
}
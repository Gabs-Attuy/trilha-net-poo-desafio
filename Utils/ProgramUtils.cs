namespace DesafioPOO.Utils
{
    public static class ProgramUtils
    {
        public static int LerEscolhaDeSmartphone(string mensagem, int valorMinimo, int valorMaximo)
        {
            Console.WriteLine(mensagem);
            while (true)
            {
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out int numero) || numero < valorMinimo || numero > valorMaximo)
                {
                    Console.WriteLine($"\nPor favor, digite um número inteiro que represente uma opção válida ({valorMinimo} a {valorMaximo}).\n");
                }
                else
                {
                    return numero;
                }
            }
        }

        public static string LerNomeDeAplicativo()
        {
            Console.WriteLine("Digite o nome de um aplicativo para instalar:");
            while (true)
            {
                string nomeApp = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nomeApp))
                {
                    Console.WriteLine("O nome do aplicativo não pode estar vazio. Tente novamente.\n");
                }
                else
                {
                    return nomeApp.Trim();
                }
            }
        }

        public static bool LerRespostaSimNao(string mensagem)
        {
            while (true)
            {
                Console.WriteLine(mensagem);
                string resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta == "S")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (resposta == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite apenas S ou N.");
                }
            }
        }
    }
}
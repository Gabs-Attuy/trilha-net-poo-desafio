using System.Text;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Buscando {nomeApp} na Play Store...\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Instalando {nomeApp} no Nokia...\n");

            int tempoDeInstalacao = nomeApp.Length * 30;
            int tamanhoBarra = 30;

            StringBuilder barra = new(new string('.', tamanhoBarra));

            for (int i = 0; i < tamanhoBarra; i++)
            {
                barra[i] = '#';

                int porcentagem = (i + 1) * 100 / tamanhoBarra;

                Console.Write($"\r[{barra}] {porcentagem}%");

                Thread.Sleep(tempoDeInstalacao);
            }

            Console.WriteLine($"\n\n{nomeApp} instalado com sucesso!");
        }

        public override string ToString()
        {
            return $"Nokia - {base.ToString()}";
        }
    }
}
using System.Text;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Buscando {nomeApp} na App Store...\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Instalando {nomeApp} no iPhone...\n");

            int tempoDeInstalacao = 30;
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
            return $"iPhone - {base.ToString()}";
        }
    }
}
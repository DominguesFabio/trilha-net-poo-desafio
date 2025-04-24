namespace DesafioPOO.Models
{
    using Models;
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        public Nokia (string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria){

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
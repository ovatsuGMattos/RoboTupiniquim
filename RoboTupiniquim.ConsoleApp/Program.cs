namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posicoesInicias = ["1 2 N", "3 3 L"];
            string[] comandosInicias = ["EMEMEMEMM", "MMDMMDMDDM"];

            string[] nomeRobos = ["Gabriel", "Leonardo"];


            int quantidadeRobos = 2;

            Robo[] robos = new Robo[quantidadeRobos];

            for (int contador = 0; contador < robos.Length; contador++)
            {
                string[] coordenadasAtuais = posicoesInicias[contador].Split(' ');

                Robo robo = new Robo();

                robo.nome = nomeRobos[contador];

                robo.posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
                robo.posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
                robo.direcao = Convert.ToChar(coordenadasAtuais[2]);

                char[] instrucoes = comandosInicias[contador].ToCharArray();

                robo.Explorar(instrucoes);

                Console.WriteLine(robo.ObterLocalizacao());

                robos[contador] = robo;

            }
            Console.ReadLine();

        }
    }
}

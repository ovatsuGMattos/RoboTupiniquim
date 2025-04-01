namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posicoesInicias = ["1 2 N", "3 3 L"];
            string[] comandosInicias = ["EMEMEMEMM", "MMDMMDMDDM"];

            string[] coordenadasAtuais = posicoesInicias[0].Split(' ');

            RoboUm.posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
            RoboUm.posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
            RoboUm.direcao = Convert.ToChar(coordenadasAtuais[2]);

            char[] instrucoes = comandosInicias[0].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    RoboUm.VirarEsquerda();
                else if (instrucaoAtual == 'D')
                    RoboUm.VirarDireita();

                else if (instrucaoAtual == 'M')
                    RoboUm.Mover();
            }

            coordenadasAtuais = posicoesInicias[1].Split(' ');

            RoboDois.posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
            RoboDois.posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
            RoboDois.direcao = Convert.ToChar(coordenadasAtuais[2]);

            instrucoes = comandosInicias[1].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    RoboDois.VirarEsquerda();

                else if (instrucaoAtual == 'D')
                    RoboDois.VirarDireita();

                else if (instrucaoAtual == 'M')
                    RoboDois.Mover();

            }
            Console.WriteLine(RoboUm.ObterLocalizacao());
            Console.WriteLine(RoboDois.ObterLocalizacao());

            Console.ReadLine();
        }
    }
}

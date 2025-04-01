namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posicoesInicias = ["1 2 N", "3 3 L"];
            string[] comandosInicias = ["EMEMEMEMM", "MMDMMDMDDM"];

            #region Ordens do primeiro robô
            string[] coordenadasAtuais = posicoesInicias[0].Split(' ');

            Robo.posicaoXRoboUm = Convert.ToInt32(coordenadasAtuais[0]);
            Robo.posicaoYRoboUm = Convert.ToInt32(coordenadasAtuais[1]);
            Robo.direcaoRoboUm = Convert.ToChar(coordenadasAtuais[2]);

            char[] instrucoes = comandosInicias[0].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    Robo.virarEsquerdaRoboUm();
                else if (instrucaoAtual == 'D')
                    Robo.virarDireitaRoboUm();

                else if (instrucaoAtual == 'M')
                    Robo.MoverRoboUm();
            }
            #endregion

            #region Ordens do segundo robô
            coordenadasAtuais = posicoesInicias[1].Split(' ');

            Robo.posicaoXRoboDois = Convert.ToInt32(coordenadasAtuais[0]);
            Robo.posicaoYRoboDois = Convert.ToInt32(coordenadasAtuais[1]);
            Robo.direcaoRoboDois = Convert.ToChar(coordenadasAtuais[2]);

            instrucoes = comandosInicias[1].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    Robo.VirarEsquerdaRoboDois();

                else if (instrucaoAtual == 'D')
                    Robo.VirarDireitaRoboDois();

                else if (instrucaoAtual == 'M')
                    Robo.MoverRoboDois();

            }

            #endregion

            Console.WriteLine(Robo.ObterLocalizacaoRoboUm());
            Console.WriteLine(Robo.ObterLocalizacaoRoboDois());

            Console.ReadLine();
        }
    }
}

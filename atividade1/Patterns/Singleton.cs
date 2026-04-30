using System;

namespace atividade1.Patterns
{
    public class Singleton
    {
        private static Singleton? instancia;

        private Singleton()
        {
        }

        public static Singleton GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
            }

            return instancia;
        }

        public string Mensagem()
        {
            return "Olá, você está usando o padrão Singleton!";
        }
    }
}
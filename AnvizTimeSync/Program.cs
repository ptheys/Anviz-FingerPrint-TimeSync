using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnvizTimeSync
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Anviz.SDK.AnvizManager("10.10.9.5", 2, 5010);
            manager.Connect();
            try
            {
                Console.WriteLine($"Data e hora atual do Anviz: {manager.GetDateTime().Value.ToString("yyyy-MM-dd HH:mm:ss")}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao obter o horário atual");
            }

            if (manager.SetDateTime(DateTime.Now))
                Console.WriteLine("Horário ajustado com sucesso");
            else
                Console.WriteLine("FALHA: Horário não ajustado com sucesso");
        }
    }
}

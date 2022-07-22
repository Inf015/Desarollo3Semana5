using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;


namespace Semana_5
{
    internal class Program
    {

        static Entities entities = new Entities();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            string Name,Apellido,Telefono, OriSexual,EstadCivil, select="si";


            try
            {
                while (select.ToUpper() == "SI")
                {
                    Console.WriteLine("Nombre:");
                    Name = Console.ReadLine();

                    Console.WriteLine("Apelido:");
                    Apellido = Console.ReadLine();

                    Console.WriteLine("Telefono:");
                    Telefono = Console.ReadLine();

                    Console.WriteLine("Orientacion Sexual:");
                    OriSexual = Console.ReadLine();

                    Console.WriteLine("Estado civil:");
                    EstadCivil = Console.ReadLine();

                    entities.ppInsertPersona(Name, Apellido, Telefono, OriSexual, EstadCivil, DateTime.Now);

                    log.Info($"Se ha registrado la persona {Name} {Apellido}");

                    Console.WriteLine();
                    Console.WriteLine("Desea Registrar otra persona?");
                    select = Console.ReadLine();
                }
            }

            catch (Exception ex)
            {
                log.Error($"A ocurrido un error {ex}");

                throw;
            }

            


        }
    }
}

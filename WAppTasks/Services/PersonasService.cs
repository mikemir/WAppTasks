using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WAppTasks.Services
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }

    public class PersonasService
    {
        public static Persona GetPersona(int id)
        {
            Thread.Sleep(10000);

            return new Persona
            {
                Id = id,
                Nombres = $"Juan {id}.",
                Apellidos = $"Cena{id}."
            };
        }

        public static List<Persona> GetPersonas()
        {
            var result = new List<Persona>();            
            var rand = new Random(DateTime.Now.Millisecond);

            //for (int i = 0; i < 10; i++)
            //{
            //    result.Add(GetPersona(i));
            //}

            Parallel.For(0, 10, (i) =>
            {
                result.Add(GetPersona(i));
            });

            return result;
        }
    }
}

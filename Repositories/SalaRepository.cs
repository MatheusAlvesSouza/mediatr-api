using escola_api.Entities;
using System.Collections.Generic;

namespace escola_api.Repositories
{
    public class SalaRepository : IRepository<Sala>
    {
        private readonly List<Sala> salas;
        public SalaRepository()
        {
            salas = new List<Sala>();
        }

        public Sala Create(Sala sala)
        {
            salas.Add(sala);
            
            return sala;
        }

        public List<Sala> All() => salas;
    }
}
using RegistroComunitarioComunidadConectada.Web.Models;
using System.Collections.Generic;

namespace RegistroComunitarioComunidadConectada.Web.Data
{
    public class ParticipanteRepo
    {
        
        private static List<Participante> _participantes = new List<Participante>();

        public void Add(Participante nuevoParticipante)
        {
            _participantes.Add(nuevoParticipante);
        }

        public IEnumerable<Participante> GetAll()
        {
            return _participantes.AsReadOnly();
        }
    }

}
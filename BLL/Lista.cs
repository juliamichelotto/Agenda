using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_
{
    public class Lista
    {
        public List<Pessoas> Pessoas { get; set; } = new List<Pessoas>() { };
        public void Incluir (Pessoas pessoas)
        {
            Pessoas.Add(pessoas);
        }

        public void Remover (Pessoas pessoas)
        {
            Pessoas.Remove(pessoas);
        }
    }
}

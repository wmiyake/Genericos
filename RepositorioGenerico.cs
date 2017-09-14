using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGemerics
{
    public class RepositorioGenerico<Ttipo>
    {
        private List<Ttipo> list;
        public RepositorioGenerico()
        {
            list = new List<Ttipo>();
        }

        public List<Ttipo> Get()
        {
            return list;
        }
        public void Insert(Ttipo meuObjeto)
        {
            list.Add(meuObjeto);
        }

    }
}

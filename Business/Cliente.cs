using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Cliente : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public string Data { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Horario { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Modelo { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Placa { get; set; }

        public new List<Cliente> Todos()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach(var ibase in base.Todos())
            {
                clientes.Add((Cliente)ibase);
            }
            return clientes;
        }
    }
}

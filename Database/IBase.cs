using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IBase
    {
        void Salvar();
        void Excluir(int id);
        int Key();
        void CriarTabela();

        List<IBase> Todos();
        List<T> Buscar<T>(int id);
    }
}

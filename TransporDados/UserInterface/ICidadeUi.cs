using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporDados
{
    public interface ICidadeUI<T>
    {
        List<T> BuscaCidade(string conexao);
        List<T> ComparaBusca(List<T> cidadeP, List<T> CidadeS, bool ComparaDesc);
        void InserirCidade();
        void UpdateCidade();
    }
}

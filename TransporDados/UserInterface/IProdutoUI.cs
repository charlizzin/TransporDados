using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporDados.UserInterface
{
    public interface IProdutoUI<T>
    {
        List<T> BuscaProduto(string conexao, bool bancoPesquisa);
        List<T> ComparaBusca(List<T> ProdutoP, List<T> ProdutoS);
        void InserirProduto();
        void UpdateProduto();
    }
}

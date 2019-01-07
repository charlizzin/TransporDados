using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporDados.UserInterface
{
    public interface IClienteUI<T>
    {
        List<T> BuscaCliente(string conexao, bool bancoPesquisa);
        List<T> ComparaBusca(List<T> clienteP, List<T> ClienteS);
        void InserirCliente();
        void UpdateCliente();
    }
}

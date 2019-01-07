using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporDados.UserInterface
{
    public interface ICompprodUI<T>
    {
        List<T> BuscaCompprod(string conexao);
        List<T> ComparaBusca(List<T> compprodP, List<T> compprodS);
        void InserirCompprod();
        void UpdateCompprod();
    }
}

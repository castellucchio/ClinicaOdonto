using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segalla.Repo
{
    internal interface IRepo<T>
    {
        ObservableCollection<T> BuscaTodos();
        T BuscaPorCodigo(int Codigo);
        bool Insere(T Model);
        bool Atualiza(T Model);
        bool Exclui(T Model);
    }
}

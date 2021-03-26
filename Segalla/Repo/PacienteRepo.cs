using Dapper.Contrib.Extensions;
using Segalla.Models;
using Segalla.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segalla.Repo
{
    class PacienteRepo : IRepo<Paciente>
    {
        public bool Atualiza(Paciente Model)
        {
            using (var conn = AppUtils.connection)
            {
                return conn.Update<Paciente>(Model);
            }
        }

        public Paciente BuscaPorCodigo(int Codigo)
        {
            using(var conn = AppUtils.connection)
            {
                return conn.Get<Paciente>(Codigo);
            }
        }

        public ObservableCollection<Paciente> BuscaTodos()
        {
            using(var conn = AppUtils.connection)
            {
                return new ObservableCollection<Paciente>(conn.GetAll<Paciente>());
            }
        }

        public bool Exclui(Paciente Model)
        {
            using(var conn = AppUtils.connection)
            {
                return conn.Delete<Paciente>(Model);
            }
        }

        public bool Insere(Paciente Model)
        {
            using(var conn = AppUtils.connection)
            {
                return conn.Insert<Paciente>(Model) != 0;
            }
        }
    }
}

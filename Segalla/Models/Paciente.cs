using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segalla.Models
{
    [Table("Paciente")]
    class Paciente
    {
        [Key]
        public ulong Codigo { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Parentesco { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string TelFixo { get; set; }
        public string TelCelular { get; set; }
        public string Dentista { get; set; }
        public string DentistaCRO { get; set; }
        public DateTime? DataProntuario { get; set; }
        public bool Deletado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeValidation.Program.Models
{
    public class Cota
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public int Grupo { get; set; } 
        public int Versao { get; set; }
        public DateTime? DataContemplacao { get; set; }

        public Cota(int codigo, int grupo, int versao, DateTime? dataContemplacao)
        {
            Id = Guid.NewGuid();
            Codigo = codigo;
            Grupo = grupo;
            Versao = versao;
            DataContemplacao = dataContemplacao;
        }
    }
}

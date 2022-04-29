using System;
using System.Collections.Generic;
using System.Text;

namespace Contas.Entites
{
    class CadConta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimeto { get; set; }
        public string situacao { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAcademia
{
    internal class Planos
    {
        string nomePlano, dataInicio, dataFim, valor;

        public string NomePlano { get => nomePlano; set => nomePlano = value; }
        public string DataInicio { get => dataInicio; set => dataInicio = value; }
        public string DataFim { get => dataFim; set => dataFim = value; }
        public string Valor { get => valor; set => valor = value; }
    }
}

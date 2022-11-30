using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiAcademia
{
    internal class Clientes
    {
        int plano;
        string nome, cpf, dataNascimento, email, telefone, endereco, cidade;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Plano { get => plano; set => plano = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public override string exibirDados()
        {
            string mensagem = $"Id: {Id}\nNome: {Nome}\nCargo: {Cargo}\nEmail: {Email}\nCPF: {Cpf}\nSenha: {Senha}";
            return mensagem;
        }

        public override void cadastrar(int? id, string nome, string cargo, string email, string cpf, string senha)
        {
            base.cadastrar(id, nome, cargo, email, cpf, senha);
            this.Cargo = cargo;
        }

    }
}

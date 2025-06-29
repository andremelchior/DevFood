﻿using System;
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

        public override string exibirDados(Funcionario F)
        {
            string mensagem = $"Id: {F.Id}\nNome: {F.Nome}\nCargo: {F.Cargo}\nEmail: {F.Email}\nCPF: {F.Cpf}\nSenha: {F.Senha}";
            return mensagem;
        }

        public override void cadastrar(int? id, string nome, string cargo, string email, string cpf, string senha)
        {
            base.cadastrar(id, nome, email, cpf, senha);
            this.Cargo = cargo;
        }

        public override void cadastrar(string nome, string cargo, string email, string cpf, string senha)
        {
            base.cadastrar(nome, email, cpf, senha);
            this.Cargo = cargo;
        }

    }
}

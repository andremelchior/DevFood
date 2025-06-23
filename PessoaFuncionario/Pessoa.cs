using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public abstract class Pessoa
    {
        public int? Id { get; set; }
        private string nome;
        public string Nome
        {
            get
            {
                return nome.ToUpper();
            }
            set
            {
                if (value != null && value.Length > 2)
                {
                    nome = value.ToUpper();
                }
                else
                {
                    throw new ArgumentException("Erro! Nome não pode ser nulo ou com menos de 3 letras.");
                }
            }
        }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

        public abstract string exibirDados();

        public void cadastrar(int? id, string nome, string email, string cpf, string senha)
        {
            if (nome != null && email != null && cpf != null && senha != null)
            {
                this.Id = id.Value;
                this.Nome = nome;
                this.Email = email;
                this.Cpf = cpf;
                this.Senha = senha;
            }
            else
            {
                throw new ArgumentException("Todos os campos devem ser preenchidos.");
            }
        }

        public virtual void cadastrar(int? id, string nome, string cargo, string email, string cpf, string senha)
        {
            this.cadastrar(id, nome, email, cpf, senha);
        }

    }
}

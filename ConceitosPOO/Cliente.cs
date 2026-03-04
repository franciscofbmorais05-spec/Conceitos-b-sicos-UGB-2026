using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length > 0)
                    _nome = value;
                else
                    throw new Exception(" O nome não pode estar vazio");
            }



        }
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value.Length == 11)
                    _cpf = value;
                else
                    throw new Exception("O CPF deve ter exatamente 11 dígitos");
            }
        }
    }

    public class Agencia
    {
        private string _numero;
        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value.Length == 11)
                    _numero = value;
                else
                    throw new Exception("O número deve conter DDD + Dígitos");
            }
        }

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length > 0)
                    _nome = value;
                else
                    throw new Exception("O nome não pode estar vazio");
            }
        }

        private string _telefone;
        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                if (value.Length == 10)
                    _telefone = value;
                else
                    throw new Exception("O telefone deve conter DDD + Dígitos");
            }
        }
    } 

}
   


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Hospedagem.models
{
    public class Pessoa
    {

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        private string _nome;
        private int _sobrenome;


        public string Nome { 
            
            get=> _nome.ToUpper();
        
            set{
                if (value == "")
                {
                    throw new ArgumentException("o nome nao pode ser vazio" );
                }
                _nome = value;
            }
            
        }
        public string Sobrenome { 
            get;
            set;
            
        }


        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();



        
    }
}
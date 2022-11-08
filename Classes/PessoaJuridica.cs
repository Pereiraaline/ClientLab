using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica 
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        } // ainda da é necessário criar o método. Está apenas implementado
    }
}
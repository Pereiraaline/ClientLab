using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? Cpf;
        public string? DataNascimento;

        bool IPessoaFisica.ValidarDataNasc(string dataNasc)
        {
            throw new NotImplementedException();
        } // ainda da é necessário criar o método. Está apenas implementado
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLab.Interfaces;

namespace ClientLab.Classes
{
    public class Pessoa : IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

         float IPessoa.PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        } // ainda da é necessário criar o método. Está apenas implementado
    }
    }

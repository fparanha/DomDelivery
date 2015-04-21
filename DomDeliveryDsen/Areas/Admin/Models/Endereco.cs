using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Areas.Admin.Models
{
    public class Endereco
    {
        public virtual int IdCep { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual int Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Uf { get; set; }

    }
}
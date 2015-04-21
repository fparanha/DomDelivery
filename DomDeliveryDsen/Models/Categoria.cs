using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Models
{
    public class Categoria
    {
        public virtual int IdCategoria { get; set; }
        public virtual Loja IdLoja { get; set; }
        public virtual Secao IdSecao { get; set; }
        public virtual string Nome { get; set; }
        public virtual bool Exibicao { get; set; }
    }
}
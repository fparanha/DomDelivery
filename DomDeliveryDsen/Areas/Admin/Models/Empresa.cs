using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Models
{
    public class Empresa
    {
        public virtual int IdEmpresa { get; set; }
        public virtual string NomeEmpresa { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string Url { get; set; }
        public virtual string Pasta { get; set; }        
    }
}
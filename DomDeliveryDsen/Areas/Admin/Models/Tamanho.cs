using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Models
{
    public class Tamanho
    {
        public virtual int Id { get; set; }
        public virtual Loja IdLoja { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual int QuantidadeSabor { get; set; }
        public virtual int QuantidadeFatias { get; set; }
        public virtual bool SttPromocao { get; set; }
    }
}
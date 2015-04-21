using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Models
{
    public class Secao
    {
        public virtual int Id { get; set; }
        public virtual Loja IdLoja { get; set; }
        public virtual string Nome { get; set; }
        public virtual bool Exibir { get; set; }
        public virtual int OrdemExibicao { get; set; }
        public virtual bool SttObservacao { get; set; }
        public virtual bool SttAdicional { get; set; }
        public virtual bool SttProdutosPromocionais { get; set; }
        public virtual bool SttTamanho { get; set; }
        public virtual bool SttPizza { get; set; }
        public virtual bool SttObsPizza { get; set; }
    }
}
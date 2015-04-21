using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Models
{
    public class Produtos
    {
        public virtual int IdProd { get; set; }
        public virtual Empresa IdEmpresa { get; set; }
        public virtual string Nome { get; set; }
        public virtual string ImagemCompreJa { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Secao IdSecao { get; set; }
        public virtual Tamanho IdTamanho { get; set; }
        public virtual bool SttPromocao { get; set; }
        public virtual bool SttProdutoPromocional { get; set; }
        public virtual string ImagemProdutoPromocional { get; set; }
        public virtual string ImagemProduto { get; set; }
        public virtual bool Destaque { get; set; }
        public virtual string Moeda { get; set; }
        public virtual Categoria IdCategoria { get; set; }



    }
}
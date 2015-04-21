using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomDeliveryDsen.Models
{
    public class Loja
    {
        public virtual int IdLoja { get; set; }
        public virtual Empresa IdEmpresa { get; set; }
        public virtual string NomeLoja { get; set; }
        public virtual Endereco EnderecoLoja { get; set; }
        public virtual Telefone TelefoneLoja { get; set; }
        public virtual string Cnpj { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }
        public virtual string SmtpServer { get; set; }
        public virtual int TipoImpressora { get; set; }
        public virtual string PortaCom { get; set; }
        public virtual string VelocidadeCom { get; set; }
        public virtual bool SttAtividade { get; set; }
        public virtual bool SttSom { get; set; }
        public virtual bool SttAutoImpressao { get; set; }
        public virtual string TempoEntrega { get; set; }
        public virtual bool SttPedidoMinimo { get; set; }
    }
}
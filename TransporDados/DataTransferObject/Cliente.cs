using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace TransporDados.DataTransferObject
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [ExplicitKey]
        public string Codcliente { get; set; } // char(8)
        public string Nome { get; set; } // varchar(60)
        public string Nomefantasia { get; set; } // varchar(50)
        public string Endereco { get; set; } // varchar(60)
        public string Bairro { get; set; } // varchar(30)
        public string Codcidade { get; set; } // varchar(5)
        public string Estado { get; set; } // varchar(2)
        public string Cep { get; set; } // varchar(8)
        public string Cgccpf { get; set; } // varchar(18)
        public string Inscest { get; set; } // varchar(15)
        public char? Pessoa_fj { get; set; } // varchar(1)
        public string Contato { get; set; } // varchar(50)
        public string Fone { get; set; } // varchar(15)
        public string Fax { get; set; } // varchar(15)
        public string Codclascli { get; set; } // varchar(3)
        public string Codsegmento { get; set; } // varchar(3)
        public string Enderecocob { get; set; } // varchar(60)
        public string Bairrocob { get; set; } // varchar(30)
        public string Codcidadecob { get; set; } // varchar(5)
        public string Estadocob { get; set; } // varchar(2)
        public string Cepcob { get; set; } // varchar(8)
        public string Ctctbred { get; set; } // varchar(7)
        public string Nomesocio { get; set; } // varchar(50)
        public string Codtranspt { get; set; } // varchar(4)
        public string Codvendend1 { get; set; } // varchar(4)
        public string Enderecoent { get; set; } // varchar(60)
        public string Bairroent { get; set; } // varchar(30)
        public string Codcidadeent { get; set; } // varchar(5)
        public string Estadoent { get; set; } // varchar(2)
        public string Cepent { get; set; } // varchar(8)
        public DateTime? Dt_cadastro { get; set; } // timestamp
        public DateTime? Dt_primvenda { get; set; } // timestamp
        public DateTime? Dt_ultvenda { get; set; } // timestamp
        public string Codprazo { get; set; } // varchar(3)
        public string Email { get; set; } // varchar(60)
        public string Campolivre1 { get; set; } // varchar(20)
        public string Campolivre2 { get; set; } // varchar(20)
        public string Campolivre3 { get; set; } // varchar(60)
        public string Campolivre4 { get; set; } // varchar(60)
        public string Homepage { get; set; } // varchar(30)
        public char? Clibloqueado { get; set; } // varchar(1)
        public char? Ativo { get; set; } // varchar(1)
        public DateTime? Dt_valcad { get; set; } // timestamp
        public double? Limitecredito { get; set; } // double precision
        public DateTime? Dt_nascimento { get; set; } // timestamp
        public string Observacao { get; set; } // blob sub_type 1
        public string Codfornec { get; set; } // varchar(6)
        public DateTime? Data_ult_alteracao { get; set; } // timestamp
        public string Campolivre5 { get; set; } // varchar(40)
        public string Campolivre6 { get; set; } // varchar(40)
        public string Campolivre7 { get; set; } // varchar(40)
        public string Campolivre8 { get; set; } // varchar(40)
        public string Campolivre9 { get; set; } // varchar(40)
        public string Campolivre10 { get; set; } // varchar(40)
        public string Codrota { get; set; } // varchar(5)
        public string Tipocliente { get; set; } // varchar(1)
        public string Celular { get; set; } // varchar(20)
        public int? Codopcel { get; set; } // integer
        public char? Maladiretaeletr { get; set; } // varchar(1)
        public string Prefixcelular { get; set; } // varchar(4)
        public string Prazopgtoliberado { get; set; } // varchar(40)
        public string Formapgtoliberado { get; set; } // varchar(40)
        public string Codtvenda { get; set; } // varchar(4)
        public char? Retempisconfis { get; set; } // varchar(1)
        public string Codrepresentante { get; set; } // varchar(4)
        public int? Tipovenda { get; set; } // integer
        public int? Seqrota { get; set; } // integer
        public int? Carenciadebitopdv { get; set; } // integer
        public string Gruposproduto { get; set; } // varchar(100)
        public int? Codficha { get; set; } // integer
        public double? Outrasdespesasnf { get; set; } // double precision
        public char? Optantesimples { get; set; } // varchar(1)
        public char? Protestarcliente { get; set; } // varchar(1)
        public string Inscmunicipal { get; set; } // varchar(15)
        public int? Prazoprotesto { get; set; } // integer
        public char? Retemiss { get; set; } // varchar(1)
        public int? Contribuintest { get; set; } // integer
        public int? Codclienteecom { get; set; } // integer
        public string Codpais { get; set; } // varchar(4)
        public string Placa { get; set; } // varchar(20)
        public string Km { get; set; } // varchar(20)
        public DateTime? Version { get; set; } // timestamp
        public char? Revendagrotoxico { get; set; } // varchar(1)
        public string Enderecopr { get; set; } // varchar(60)
        public string Bairropr { get; set; } // varchar(30)
        public string Codcidadepr { get; set; } // varchar(5)
        public string Estadopr { get; set; } // varchar(2)
        public string Ceppr { get; set; } // varchar(8)
        public string Nomeprop { get; set; } // varchar(60)
        public string Codcidadeprop { get; set; } // varchar(5)
        public string Estadoprop { get; set; } // varchar(2)
        public int? Idclienteecom { get; set; } // integer
        public byte[] Digital1 { get; set; } // blob
        public byte[] Digital2 { get; set; } // blob
        public byte[] Digital3 { get; set; } // blob
        public int? Idclientejava { get; set; } // integer
        public string Documentoestrangeiro { get; set; } // varchar(20)
        public DateTime? Validade { get; set; } // timestamp
        public int? Contribuinteicms { get; set; } // integer
        public double? Aliqirrf { get; set; } // double precision
        public string Numero { get; set; } // varchar(5)
        public string Complemento { get; set; } // varchar(60)
        public string Numerocob { get; set; } // varchar(5)
        public string Complementocob { get; set; } // varchar(60)
        public string Numeroent { get; set; } // varchar(5)
        public string Complementoent { get; set; } // varchar(60)
        public int? Gravadopeloecf { get; set; } // integer
        public int? Sincronizado { get; set; } // integer
        public string Codmunicipio { get; set; } // varchar(7)
        //public int? Tipocontrato { get; set; } // integer
        //public int? Diavenccontrato { get; set; } // integer
        //public DateTime? Databasecontrato { get; set; } // timestamp
        //public double? Qtdsalariominimo { get; set; } // double precision
        //public double? Valorcontrato { get; set; } // double precision
        //public string Codempresacli { get; set; } // varchar(2)
        //public DateTime? Datacancelacontrato { get; set; } // timestamp
        //public string Motivocancelacontrato { get; set; } // blob sub_type 1
        //public int? Exigenf { get; set; } // integer
        //public string Senhainstalacao { get; set; } // blob sub_type 1
        //public string Codmotivocanccontrato { get; set; } // varchar(3)


    }
}

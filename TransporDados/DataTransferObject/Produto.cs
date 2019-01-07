using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace TransporDados.DataTransferObject
{
    [Table("PRODUTO")]
    public class Produto
    {
        public string Codprod { get; set; } // char(6)
        public char? Ativo { get; set; } // varchar(1)
        public string Referencia { get; set; } // varchar(50)
        public string Reffabricante { get; set; } // varchar(20)
        public string Descricao { get; set; } // varchar(50)
        public string Descricao2 { get; set; } // varchar(50)
        public string Descricao3 { get; set; } // varchar(50)
        public string Codgrupo { get; set; } // varchar(3)
        public string Codsubgrupo { get; set; } // varchar(3)
        public char? Tipoprod { get; set; } // varchar(1)
        public double? Estminimo { get; set; } // double precision
        public int? Diasestminimo { get; set; } // integer
        public double? Estmaximo { get; set; } // double precision
        public int? Diasestmaximo { get; set; } // integer
        public string Codclasfis { get; set; } // varchar(4)
        public double? Aliqipi { get; set; } // double precision
        public double? Aliqiss { get; set; } // double precision
        public double? Aliqicmsreg00 { get; set; } // double precision
        public double? Baseicmsreg00 { get; set; } // double precision
        public string Codtribut00 { get; set; } // varchar(3)
        public string Mensagem00 { get; set; } // varchar(3)
        public double? Aliqicmsreg01 { get; set; } // double precision
        public double? Baseicmsreg01 { get; set; } // double precision
        public string Codtribut01 { get; set; } // varchar(3)
        public string Mensagem01 { get; set; } // varchar(3)
        public double? Aliqicmsreg02 { get; set; } // double precision
        public double? Baseicmsreg02 { get; set; } // double precision
        public string Codtribut02 { get; set; } // varchar(3)
        public string Mensagem02 { get; set; } // varchar(3)
        public double? Aliqicmsreg03 { get; set; } // double precision
        public double? Baseicmsreg03 { get; set; } // double precision
        public string Codtribut03 { get; set; } // varchar(3)
        public string Mensagem03 { get; set; } // varchar(3)
        public string Substrib { get; set; } // varchar(1)
        public double? Lucrosubstrib { get; set; } // double precision
        public double? Comissao { get; set; } // double precision
        public string Embalagem { get; set; } // varchar(15)
        public string Codlocal { get; set; } // varchar(8)
        public string Codfabric { get; set; } // varchar(5)
        public double? Peso { get; set; } // double precision
        public string Unidadeent { get; set; } // varchar(6)
        public string Unidadesaida { get; set; } // varchar(6)
        public double? Fatorconversao { get; set; } // double precision
        public string Multdivide { get; set; } // varchar(1)
        public double? Pr_ult_ent1 { get; set; } // double precision
        public DateTime? Data_ult_ent1 { get; set; } // timestamp
        public double? Quant_ult_ent1 { get; set; } // double precision
        public string Fornec_ult_ent1 { get; set; } // varchar(6)
        public double? Pr_ult_ent2 { get; set; } // double precision
        public DateTime? Data_ult_ent2 { get; set; } // timestamp
        public double? Quant_ult_ent2 { get; set; } // double precision
        public string Fornec_ult_ent2 { get; set; } // varchar(6)
        public double? Pr_ult_ent3 { get; set; } // double precision
        public DateTime? Data_ult_ent3 { get; set; } // timestamp
        public double? Quant_ult_ent3 { get; set; } // double precision
        public string Fornec_ult_ent3 { get; set; } // varchar(6)
        public double? Dvv { get; set; } // double precision
        public double? Lucro { get; set; } // double precision
        public double? Sugestao { get; set; } // double precision
        public double? Preco { get; set; } // double precision
        public char? Prodbloqueado { get; set; } // varchar(1)
        public string Campolivre1 { get; set; } // varchar(20)
        public string Campolivre2 { get; set; } // varchar(20)
        public string Campolivre3 { get; set; } // varchar(50)
        public string Campolivre4 { get; set; } // varchar(50)
        public string Principalfornec { get; set; } // varchar(6)
        public string Nota_ult_ent1 { get; set; } // varchar(10)
        public string Nota_ult_ent2 { get; set; } // varchar(10)
        public string Nota_ult_ent3 { get; set; } // varchar(10)
        public string Controleserie { get; set; } // varchar(1)
        public string Codprodbaixa { get; set; } // varchar(6)
        public double? Fatorconvbaixa { get; set; } // double precision
        public string Multdivbaixa { get; set; } // varchar(1)
        public string Codfrete { get; set; } // varchar(3)
        public DateTime? Dt_cadastro { get; set; } // timestamp
        public string Descricaopreco { get; set; } // varchar(10)
        public double? Preco2 { get; set; } // double precision
        public string Descricaopreco2 { get; set; } // varchar(10)
        public double? Preco3 { get; set; } // double precision
        public string Descricaopreco3 { get; set; } // varchar(10)
        public double? Lucro2 { get; set; } // double precision
        public double? Lucro3 { get; set; } // double precision
        public string Itemportaria790 { get; set; } // varchar(2)
        public string Enviado { get; set; } // varchar(1)
        public double? Precodolar { get; set; } // double precision
        public DateTime? Data_ult_alteracao { get; set; } // timestamp
        public double? Percperda { get; set; } // double precision
        public double? Precopromo { get; set; } // double precision
        public DateTime? Datainipromo { get; set; } // timestamp
        public DateTime? Datafimpromo { get; set; } // timestamp
        public char? Substribsaida { get; set; } // varchar(1)
        public double? Percbasesubstribsaida { get; set; } // double precision
        public double? Percicmssubstribsaida { get; set; } // double precision
        public string Temsubitens { get; set; } // varchar(1)
        public string Codsegmentosubtribsaida { get; set; } // varchar(3)
        public double? Aliqicmsdiversos { get; set; } // double precision
        public double? Baseicmsdiversos { get; set; } // double precision
        public string Codtributdiversos { get; set; } // varchar(3)
        public string Mensagemdiversos { get; set; } // varchar(3)
        public string Tipodiversos { get; set; } // varchar(8)
        public string Contacxa { get; set; } // varchar(7)
        public double? Percicmmargemlucro { get; set; } // double precision
        public double? Aliqinternaicmlucro { get; set; } // double precision
        public string Segmentoicmlucro { get; set; } // varchar(3)
        public string Segmentoicmdiversos { get; set; } // varchar(3)
        public double? Aliqicmsdiversos2 { get; set; } // double precision
        public double? Baseicmsdiversos2 { get; set; } // double precision
        public string Codtributdiversos2 { get; set; } // varchar(3)
        public string Mensagemdiversos2 { get; set; } // varchar(3)
        public string Controlelote { get; set; } // varchar(1)
        public int? Grade { get; set; } // integer
        public string Aceitaprecozero { get; set; } // varchar(1)
        public double? Vlrcobraroper { get; set; } // double precision
        public double? Comissaovlr { get; set; } // double precision
        public int? Garantia { get; set; } // integer
        public double Ipiantigo { get; set; } // double precision
        public double? Custodolar { get; set; } // double precision
        public double? Aliqicmspdv { get; set; } // double precision
        public char? Temrebatefinanc { get; set; } // varchar(1)
        public double? Lucro4 { get; set; } // double precision
        public string Descricaopreco4 { get; set; } // varchar(10)
        public double? Preco4 { get; set; } // double precision
        public string Prodbalanca { get; set; } // varchar(1)
        public string Substribsaidar1 { get; set; } // varchar(1)
        public double? Percbasesubstribsaidar1 { get; set; } // double precision
        public double? Percicmssubstribsaidar1 { get; set; } // double precision
        public string Substribsaidar2 { get; set; } // varchar(1)
        public double? Percbasesubstribsaidar2 { get; set; } // double precision
        public double? Percicmssubstribsaidar2 { get; set; } // double precision
        public string Substribsaidar3 { get; set; } // varchar(1)
        public double? Percbasesubstribsaidar3 { get; set; } // double precision
        public double? Percicmssubstribsaidar3 { get; set; } // double precision
        public double? Descontomaximo { get; set; } // double precision
        public int? Tipomedicamento { get; set; } // integer
        public double? Descpercpadrao { get; set; } // double precision
        public double? Lucroprevisto { get; set; } // double precision
        public double? Redutor { get; set; } // double precision
        public string Itemportariaforauf { get; set; } // varchar(2)
        public DateTime? Data_ult_reajuste { get; set; } // timestamp
        public double? Preco_anterior { get; set; } // double precision
        public string Observacao { get; set; } // blob sub_type 1
        public string Codvolume { get; set; } // varchar(3)
        public char? Fracionado { get; set; } // varchar(1)
        public string Codgeneroitem { get; set; } // varchar(2)
        public double? Custooperc { get; set; } // double precision
        public double? Perc_iva { get; set; } // double precision
        public double? Valoripi { get; set; } // double precision
        public string Tipoentrega { get; set; } // varchar(1)
        public double? Liminiloteentrega { get; set; } // double precision
        public double? Limfimloteentrega { get; set; } // double precision
        public char? Consideracomissao { get; set; } // varchar(1)
        public double? Multiplo { get; set; } // double precision
        public string Unidademultiplo { get; set; } // varchar(4)
        public char? Substribsaidar4 { get; set; } // varchar(1)
        public double? Percbasesubstribsaidar4 { get; set; } // double precision
        public double? Percicmssubstribsaidar4 { get; set; } // double precision
        public string Tipolista { get; set; } // varchar(1)
        public string Codprodproducao { get; set; } // varchar(6)
        public char? Farmaciapopular { get; set; } // varchar(1)
        public string Cfopdentrouf { get; set; } // varchar(4)
        public string Cfopforauf { get; set; } // varchar(4)
        public string Codprodpai { get; set; } // varchar(6)
        public string Codfamilia { get; set; } // varchar(2)
        public string Codtipoproduto { get; set; } // varchar(2)
        public string Codprodanp { get; set; } // varchar(9)
        public DateTime? Version { get; set; } // timestamp
        public char? Agrotoxico { get; set; } // varchar(1)
        public string Codigomapa { get; set; } // varchar(7)
        public string Codigoembalagem { get; set; } // varchar(7)
        public int? Etqprecobase { get; set; } // integer
        public int? Etqparcelamento { get; set; } // integer
        public double? Etqtxmes { get; set; } // double precision
        public string Etqinftxmes { get; set; } // varchar(30)
        public string Etqinfprecobase { get; set; } // varchar(30)
        public string Etqinfprecoaprazo { get; set; } // varchar(30)
        public string Etqinftxdia { get; set; } // varchar(30)
        public double? Percivasubstribsaida { get; set; } // double precision
        public double? Percivasubstribsaida1 { get; set; } // double precision
        public double? Percivasubstribsaida2 { get; set; } // double precision
        public double? Percivasubstribsaida3 { get; set; } // double precision
        public double? Percivasubstribsaida4 { get; set; } // double precision
        public int? Idprodutojava { get; set; } // integer
        public string Tiposinc { get; set; } // varchar(1)
        public int? Importaprodecom { get; set; } // integer
        public int? Idprodutoecom { get; set; } // integer
        public char? Iat { get; set; } // varchar(1)
        public string Codenqipi { get; set; } // varchar(3)
        public string Codnatreceita { get; set; } // varchar(3)
        public int? Idnatreceita { get; set; } // integer
        public string Codcest { get; set; } // varchar(7)
        public int? Tipomateremba { get; set; } // integer
        public int? Idparceiro { get; set; } // integer
        public int? Tipoeqpreducaobasedifal { get; set; } // integer
        public string Codselfcolor { get; set; } // varchar(8)
        public double? Percentdesctopromocao { get; set; } // double precision
        public string Codshotcolor { get; set; } // varchar(8)
        public double? Markuppreco1 { get; set; } // double precision
        public double? Markuppreco2 { get; set; } // double precision
        public double? Markuppreco3 { get; set; } // double precision
        public double? Markuppreco4 { get; set; } // double precision
        public int? Escalarelevante { get; set; } // integer
        public double? Conversaoetiquetadeprecos { get; set; } // double precision
        public string Unidadeaposconverter { get; set; } // varchar(6)
        public double? Codregistroanvisa { get; set; } // double precision
        public string Sef { get; set; } // varchar(20)
        public string Testedogerabanco { get; set; } // varchar(10)
        public char? Passapelolaudo { get; set; } // varchar(1)
        public double? Percglpderivado { get; set; } // double precision
        public double? Percgasnatural { get; set; } // double precision
        public double? Percgasnaturalinternacional { get; set; } // double precision
    }
}

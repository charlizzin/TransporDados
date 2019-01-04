using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExportaDados
{
    public class ProdutoH
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
        public double? Prultent1 { get; set; } // double precision
        public DateTime? Dataultent1 { get; set; } // timestamp
        public double? Quantultent1 { get; set; } // double precision
        public string Fornecultent1 { get; set; } // varchar(6)
        public double? Prultent2 { get; set; } // double precision
        public DateTime? Dataultent2 { get; set; } // timestamp
        public double? Quantultent2 { get; set; } // double precision
        public string Fornecultent2 { get; set; } // varchar(6)
        public double? Prultent3 { get; set; } // double precision
        public DateTime? Dataultent3 { get; set; } // timestamp
        public double? Quantultent3 { get; set; } // double precision
        public string Fornecultent3 { get; set; } // varchar(6)
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
        public string Notaultent1 { get; set; } // varchar(10)
        public string Notaultent2 { get; set; } // varchar(10)
        public string Notaultent3 { get; set; } // varchar(10)
        public string Controleserie { get; set; } // varchar(1)
        public string Codprodbaixa { get; set; } // varchar(6)
        public double? Fatorconvbaixa { get; set; } // double precision
        public string Multdivbaixa { get; set; } // varchar(1)
        public string Codfrete { get; set; } // varchar(3)
        public DateTime? Dtcadastro { get; set; } // timestamp
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
        public DateTime? Dataultalteracao { get; set; } // timestamp
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
        public DateTime? Dataultreajuste { get; set; } // timestamp
        public double? Precoanterior { get; set; } // double precision
        public string Observacao { get; set; } // blob sub_type 1
        public string Codvolume { get; set; } // varchar(3)
        public char? Fracionado { get; set; } // varchar(1)
        public string Codgeneroitem { get; set; } // varchar(2)
        public double? Custooperc { get; set; } // double precision
        public double? Perciva { get; set; } // double precision
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
        public int? Idimpostoprodutojava { get; set; } // integer

    }
    public class ProdutoP : ProdutoH { }
    public class ProdutoS : ProdutoH { }
    public class ProdutoRepository
    {
        private readonly string sqlProduto = "Select * from produto where produto.dt_cadastro = @data order by codprod";
        private readonly string dataHoje = DateTime.Today.Date.ToString("dd/MM/yyyy").Replace("/", ".");


        public List<ProdutoP> GetListaProdutosP()
        {

            DefaultTypeMap.MatchNamesWithUnderscores = true;
            //Com essa funcao ativada o DAPPER consegui identificar que DT_CADASTRO é a mesma coisa que DTCADASTRO
            //https://stackoverflow.com/questions/34533349/how-to-get-dapper-to-ignore-remove-underscores-in-field-names-when-mapping/34536829#34536829
            //https://stackoverflow.com/questions/8902674/manually-map-column-names-with-class-properties
            IEnumerable ProdutoP = new FbConnection(new Conexao().conexao1).Query<ProdutoP>(sqlProduto, new { data = dataHoje });
            List<ProdutoP> listaProdutos = new List<ProdutoP>();
            foreach (ProdutoP itemP in ProdutoP)
            {
                listaProdutos.Add(itemP);
            }
            return listaProdutos;
        }
        public List<ProdutoS> GetListaProdutosS()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            //Com essa funcao ativada o DAPPER consegui identificar que DT_CADASTRO é a mesma coisa que DTCADASTRO
            //https://stackoverflow.com/questions/34533349/how-to-get-dapper-to-ignore-remove-underscores-in-field-names-when-mapping/34536829#34536829
            //https://stackoverflow.com/questions/8902674/manually-map-column-names-with-class-properties
            IEnumerable ProdutoS = new FbConnection(new Conexao().conexao2).Query<ProdutoS>(sqlProduto, new { data = dataHoje });
            List<ProdutoS> listaProdutos = new List<ProdutoS>();
            foreach (ProdutoS itemS in ProdutoS)
            {
                listaProdutos.Add(itemS);
            }
            return listaProdutos;
        }
        public List<dynamic> ResultProduto()
        {
            List<ProdutoP> ProdutosP = GetListaProdutosP();
            List<ProdutoS> ProdutosS = GetListaProdutosS();

            List<ProdutoP> Resul = new List<ProdutoP>();
            foreach (var item in ProdutosP)
            {
                Resul.Add(item);
            }

            foreach (var itemP in ProdutosP)
            {
                foreach (var itemS in ProdutosS)
                {
                    if (itemP.Codprod.Equals(itemS.Codprod))
                    {
                        Resul.Remove(itemP);
                        break;
                    }
                }
            }
            return Resul.Cast<dynamic>().ToList();
        }
        public void InsertProduto()
        {
            #region Insert Produto
            string Insert = "INSERT INTO PRODUTO (CODPROD, ATIVO, REFERENCIA, REFFABRICANTE, DESCRICAO, " +
    "DESCRICAO2, DESCRICAO3, CODGRUPO, CODSUBGRUPO, TIPOPROD, ESTMINIMO, DIASESTMINIMO, " +
    "ESTMAXIMO, DIASESTMAXIMO, CODCLASFIS, ALIQIPI, ALIQISS, ALIQICMSREG00, BASEICMSREG00, " +
    "CODTRIBUT00, MENSAGEM00, ALIQICMSREG01, BASEICMSREG01, CODTRIBUT01, MENSAGEM01, ALIQICMSREG02, " +
    "BASEICMSREG02, CODTRIBUT02, MENSAGEM02, ALIQICMSREG03, BASEICMSREG03, CODTRIBUT03, MENSAGEM03, " +
    "SUBSTRIB, LUCROSUBSTRIB, COMISSAO, EMBALAGEM, CODLOCAL, CODFABRIC, PESO, UNIDADEENT, UNIDADESAIDA, " +
    "FATORCONVERSAO, MULTDIVIDE, PR_ULT_ENT1, DATA_ULT_ENT1, QUANT_ULT_ENT1, FORNEC_ULT_ENT1, PR_ULT_ENT2, " +
    "DATA_ULT_ENT2, QUANT_ULT_ENT2, FORNEC_ULT_ENT2, PR_ULT_ENT3, DATA_ULT_ENT3, QUANT_ULT_ENT3, " +
    "FORNEC_ULT_ENT3, DVV, LUCRO, SUGESTAO, PRECO, PRODBLOQUEADO, CAMPOLIVRE1, CAMPOLIVRE2, " +
    "CAMPOLIVRE3, CAMPOLIVRE4, PRINCIPALFORNEC, NOTA_ULT_ENT1, NOTA_ULT_ENT2, NOTA_ULT_ENT3, " +
    "CONTROLESERIE, CODPRODBAIXA, FATORCONVBAIXA, MULTDIVBAIXA, CODFRETE, DT_CADASTRO, " +
    "DESCRICAOPRECO, PRECO2, DESCRICAOPRECO2, PRECO3, DESCRICAOPRECO3, LUCRO2, LUCRO3, " +
    "ITEMPORTARIA790, ENVIADO, PRECODOLAR, DATA_ULT_ALTERACAO, PERCPERDA, PRECOPROMO, " +
    "DATAINIPROMO, DATAFIMPROMO, SUBSTRIBSAIDA, PERCBASESUBSTRIBSAIDA, PERCICMSSUBSTRIBSAIDA, " +
    "TEMSUBITENS, CODSEGMENTOSUBTRIBSAIDA, ALIQICMSDIVERSOS, BASEICMSDIVERSOS, CODTRIBUTDIVERSOS, " +
    "MENSAGEMDIVERSOS, TIPODIVERSOS, CONTACXA, PERCICMMARGEMLUCRO, ALIQINTERNAICMLUCRO, SEGMENTOICMLUCRO, " +
    "SEGMENTOICMDIVERSOS, ALIQICMSDIVERSOS2, BASEICMSDIVERSOS2, CODTRIBUTDIVERSOS2, MENSAGEMDIVERSOS2, " +
    "CONTROLELOTE, GRADE, ACEITAPRECOZERO, VLRCOBRAROPER, COMISSAOVLR, GARANTIA, IPIANTIGO, CUSTODOLAR, " +
    "ALIQICMSPDV, TEMREBATEFINANC, LUCRO4, DESCRICAOPRECO4, PRECO4, PRODBALANCA, SUBSTRIBSAIDAR1, " +
    "PERCBASESUBSTRIBSAIDAR1, PERCICMSSUBSTRIBSAIDAR1, SUBSTRIBSAIDAR2, PERCBASESUBSTRIBSAIDAR2, " +
    "PERCICMSSUBSTRIBSAIDAR2, SUBSTRIBSAIDAR3, PERCBASESUBSTRIBSAIDAR3, PERCICMSSUBSTRIBSAIDAR3, " +
    "DESCONTOMAXIMO, TIPOMEDICAMENTO, DESCPERCPADRAO, LUCROPREVISTO, REDUTOR, ITEMPORTARIAFORAUF, " +
    "DATA_ULT_REAJUSTE, PRECO_ANTERIOR, CODVOLUME, FRACIONADO, CODGENEROITEM, CUSTOOPERC, PERC_IVA, " +
    "VALORIPI, TIPOENTREGA, LIMINILOTEENTREGA, LIMFIMLOTEENTREGA, CONSIDERACOMISSAO, MULTIPLO, " +
    "UNIDADEMULTIPLO, SUBSTRIBSAIDAR4, PERCBASESUBSTRIBSAIDAR4, PERCICMSSUBSTRIBSAIDAR4, TIPOLISTA, " +
    "CODPRODPRODUCAO, FARMACIAPOPULAR, CFOPDENTROUF, CFOPFORAUF, CODPRODPAI, CODFAMILIA, " +
    "CODTIPOPRODUTO, CODPRODANP, VERSION, AGROTOXICO, CODIGOMAPA, CODIGOEMBALAGEM, ETQPRECOBASE, " +
    "ETQPARCELAMENTO, ETQTXMES, ETQINFTXMES, ETQINFPRECOBASE, ETQINFPRECOAPRAZO, ETQINFTXDIA, " +
    "PERCIVASUBSTRIBSAIDA, PERCIVASUBSTRIBSAIDA1, PERCIVASUBSTRIBSAIDA2, PERCIVASUBSTRIBSAIDA3, " +
    "PERCIVASUBSTRIBSAIDA4, IDPRODUTOJAVA, TIPOSINC, IMPORTAPRODECOM, IDPRODUTOECOM, IAT, CODENQIPI, " +
    "CODNATRECEITA, IDNATRECEITA, CODCEST, TIPOMATEREMBA, IDPARCEIRO, TIPOEQPREDUCAOBASEDIFAL, " +
    "CODSELFCOLOR, PERCENTDESCTOPROMOCAO, CODSHOTCOLOR, MARKUPPRECO1, " +
    "MARKUPPRECO2, MARKUPPRECO3, MARKUPPRECO4, ESCALARELEVANTE, CONVERSAOETIQUETADEPRECOS, " +
    "UNIDADEAPOSCONVERTER, CODREGISTROANVISA, SEF, TESTEDOGERABANCO, PASSAPELOLAUDO, PERCGLPDERIVADO, " +
    "PERCGASNATURAL, PERCGASNATURALINTERNACIONAL, IDIMPOSTOPRODUTOJAVA)VALUES (@CODPROD, @ATIVO, @REFERENCIA, " +
    "@REFFABRICANTE, @DESCRICAO, @DESCRICAO2, @DESCRICAO3, @CODGRUPO, @CODSUBGRUPO, @TIPOPROD, @ESTMINIMO, " +
    "@DIASESTMINIMO, @ESTMAXIMO, @DIASESTMAXIMO, @CODCLASFIS, @ALIQIPI, @ALIQISS, @ALIQICMSREG00, " +
    "@BASEICMSREG00, @CODTRIBUT00, @MENSAGEM00, @ALIQICMSREG01, @BASEICMSREG01, @CODTRIBUT01, " +
    "@MENSAGEM01, @ALIQICMSREG02, @BASEICMSREG02, @CODTRIBUT02, @MENSAGEM02, @ALIQICMSREG03, " +
    "@BASEICMSREG03, @CODTRIBUT03, @MENSAGEM03, @SUBSTRIB, @LUCROSUBSTRIB, @COMISSAO, @EMBALAGEM, " +
    "@CODLOCAL, @CODFABRIC, @PESO, @UNIDADEENT, @UNIDADESAIDA, @FATORCONVERSAO, @MULTDIVIDE, " +
    "@PRULTENT1, @DATAULTENT1, @QUANTULTENT1, @FORNECULTENT1, @PRULTENT2, " +
    "@DATAULTENT2, @QUANTULTENT2, @FORNECULTENT2, @PRULTENT3, @DATAULTENT3, " +
    "@QUANTULTENT3, @FORNECULTENT3, @DVV, @LUCRO, @SUGESTAO, @PRECO, @PRODBLOQUEADO, " +
    "@CAMPOLIVRE1, @CAMPOLIVRE2, @CAMPOLIVRE3, @CAMPOLIVRE4, @PRINCIPALFORNEC, @NOTAULTENT1, " +
    "@NOTAULTENT2, @NOTAULTENT3, @CONTROLESERIE, @CODPRODBAIXA, @FATORCONVBAIXA, @MULTDIVBAIXA, " +
    "@CODFRETE, @DTCADASTRO, @DESCRICAOPRECO, @PRECO2, @DESCRICAOPRECO2, @PRECO3, @DESCRICAOPRECO3, " +
    "@LUCRO2, @LUCRO3, @ITEMPORTARIA790, @ENVIADO, @PRECODOLAR, @DATAULTALTERACAO, @PERCPERDA, " +
    "@PRECOPROMO, @DATAINIPROMO, @DATAFIMPROMO, @SUBSTRIBSAIDA, @PERCBASESUBSTRIBSAIDA, " +
    "@PERCICMSSUBSTRIBSAIDA, @TEMSUBITENS, @CODSEGMENTOSUBTRIBSAIDA, @ALIQICMSDIVERSOS, " +
    "@BASEICMSDIVERSOS, @CODTRIBUTDIVERSOS, @MENSAGEMDIVERSOS, @TIPODIVERSOS, @CONTACXA, " +
    "@PERCICMMARGEMLUCRO, @ALIQINTERNAICMLUCRO, @SEGMENTOICMLUCRO, @SEGMENTOICMDIVERSOS, " +
    "@ALIQICMSDIVERSOS2, @BASEICMSDIVERSOS2, @CODTRIBUTDIVERSOS2, @MENSAGEMDIVERSOS2, " +
    "@CONTROLELOTE, @GRADE, @ACEITAPRECOZERO, @VLRCOBRAROPER, @COMISSAOVLR, @GARANTIA, " +
    "@IPIANTIGO, @CUSTODOLAR, @ALIQICMSPDV, @TEMREBATEFINANC, @LUCRO4, @DESCRICAOPRECO4, " +
    "@PRECO4, @PRODBALANCA, @SUBSTRIBSAIDAR1, @PERCBASESUBSTRIBSAIDAR1, @PERCICMSSUBSTRIBSAIDAR1, " +
    "@SUBSTRIBSAIDAR2, @PERCBASESUBSTRIBSAIDAR2, @PERCICMSSUBSTRIBSAIDAR2, @SUBSTRIBSAIDAR3, " +
    "@PERCBASESUBSTRIBSAIDAR3, @PERCICMSSUBSTRIBSAIDAR3, @DESCONTOMAXIMO, @TIPOMEDICAMENTO, " +
    "@DESCPERCPADRAO, @LUCROPREVISTO, @REDUTOR, @ITEMPORTARIAFORAUF, @DATAULTREAJUSTE, " +
    "@PRECOANTERIOR, @CODVOLUME, @FRACIONADO, @CODGENEROITEM, @CUSTOOPERC, @PERCIVA, @VALORIPI, " +
    "@TIPOENTREGA, @LIMINILOTEENTREGA, @LIMFIMLOTEENTREGA, @CONSIDERACOMISSAO, @MULTIPLO, " +
    "@UNIDADEMULTIPLO, @SUBSTRIBSAIDAR4, @PERCBASESUBSTRIBSAIDAR4, @PERCICMSSUBSTRIBSAIDAR4, " +
    "@TIPOLISTA, @CODPRODPRODUCAO, @FARMACIAPOPULAR, @CFOPDENTROUF, @CFOPFORAUF, @CODPRODPAI, " +
    "@CODFAMILIA, @CODTIPOPRODUTO, @CODPRODANP, @VERSION, @AGROTOXICO, @CODIGOMAPA, @CODIGOEMBALAGEM, " +
    "@ETQPRECOBASE, @ETQPARCELAMENTO, @ETQTXMES, @ETQINFTXMES, @ETQINFPRECOBASE, @ETQINFPRECOAPRAZO, " +
    "@ETQINFTXDIA, @PERCIVASUBSTRIBSAIDA, @PERCIVASUBSTRIBSAIDA1, @PERCIVASUBSTRIBSAIDA2, " +
    "@PERCIVASUBSTRIBSAIDA3, @PERCIVASUBSTRIBSAIDA4, @IDPRODUTOJAVA, @TIPOSINC, @IMPORTAPRODECOM, " +
    "@IDPRODUTOECOM, @IAT, @CODENQIPI, @CODNATRECEITA, @IDNATRECEITA, @CODCEST, @TIPOMATEREMBA, " +
    "@IDPARCEIRO, @TIPOEQPREDUCAOBASEDIFAL, @CODSELFCOLOR, " +
    "@PERCENTDESCTOPROMOCAO, @CODSHOTCOLOR, @MARKUPPRECO1, @MARKUPPRECO2, @MARKUPPRECO3, " +
    "@MARKUPPRECO4, @ESCALARELEVANTE, @CONVERSAOETIQUETADEPRECOS, @UNIDADEAPOSCONVERTER, " +
    "@CODREGISTROANVISA, @SEF, @TESTEDOGERABANCO, @PASSAPELOLAUDO, @PERCGLPDERIVADO, @PERCGASNATURAL, " +
    "@PERCGASNATURALINTERNACIONAL, @IDIMPOSTOPRODUTOJAVA)";
            #endregion


            Conexao conexao = new Conexao();
            FbConnection fbConnection = new FbConnection(conexao.conexao2);
            ProdutoP produto = new ProdutoP();
            var result = ResultProduto();

            foreach (var item in result)
            {
                if (result.Count != 0)
                {
                    try
                    {
                        produto = new ProdutoP
                        {
                            Codprod = item.Codprod,
                            Ativo = item.Ativo,
                            Referencia = item.Referencia,
                            Reffabricante = item.Reffabricante,
                            Descricao = item.Descricao,
                            Descricao2 = item.Descricao2,
                            Descricao3 = item.Descricao3,
                            Codgrupo = item.Codgrupo,
                            Codsubgrupo = item.Codsubgrupo,
                            Tipoprod = item.Tipoprod,
                            Estminimo = item.Estminimo,
                            Diasestminimo = item.Diasestminimo,
                            Estmaximo = item.Estmaximo,
                            Diasestmaximo = item.Diasestmaximo,
                            Codclasfis = item.Codclasfis,
                            Aliqipi = item.Aliqipi,
                            Aliqiss = item.Aliqiss,
                            Aliqicmsreg00 = item.Aliqicmsreg00,
                            Baseicmsreg00 = item.Baseicmsreg00,
                            Codtribut00 = item.Codtribut00,
                            Mensagem00 = item.Mensagem00,
                            Aliqicmsreg01 = item.Aliqicmsreg01,
                            Baseicmsreg01 = item.Baseicmsreg01,
                            Codtribut01 = item.Codtribut01,
                            Mensagem01 = item.Mensagem01,
                            Aliqicmsreg02 = item.Aliqicmsreg02,
                            Baseicmsreg02 = item.Baseicmsreg02,
                            Codtribut02 = item.Codtribut02,
                            Mensagem02 = item.Mensagem02,
                            Aliqicmsreg03 = item.Aliqicmsreg03,
                            Baseicmsreg03 = item.Baseicmsreg03,
                            Codtribut03 = item.Codtribut03,
                            Mensagem03 = item.Mensagem03,
                            Substrib = item.Substrib,
                            Lucrosubstrib = item.Lucrosubstrib,
                            Comissao = item.Comissao,
                            Embalagem = item.Embalagem,
                            Codlocal = item.Codlocal,
                            Codfabric = item.Codfabric,
                            Peso = item.Peso,
                            Unidadeent = item.Unidadeent,
                            Unidadesaida = item.Unidadesaida,
                            Fatorconversao = item.Fatorconversao,
                            Multdivide = item.Multdivide,
                            Prultent1 = item.Prultent1,
                            Dataultent1 = item.Dataultent1,
                            Quantultent1 = item.Quantultent1,
                            Fornecultent1 = item.Fornecultent1,
                            Prultent2 = item.Prultent2,
                            Dataultent2 = item.Dataultent2,
                            Quantultent2 = item.Quantultent2,
                            Fornecultent2 = item.Fornecultent2,
                            Prultent3 = item.Prultent3,
                            Dataultent3 = item.Dataultent3,
                            Quantultent3 = item.Quantultent3,
                            Fornecultent3 = item.Fornecultent3,
                            Dvv = item.Dvv,
                            Lucro = item.Lucro,
                            Sugestao = item.Sugestao,
                            Preco = item.Preco,
                            Prodbloqueado = item.Prodbloqueado,
                            Campolivre1 = item.Campolivre1,
                            Campolivre2 = item.Campolivre2,
                            Campolivre3 = item.Campolivre3,
                            Campolivre4 = item.Campolivre4,
                            Principalfornec = item.Principalfornec,
                            Notaultent1 = item.Notaultent1,
                            Notaultent2 = item.Notaultent2,
                            Notaultent3 = item.Notaultent3,
                            Controleserie = item.Controleserie,
                            Codprodbaixa = item.Codprodbaixa,
                            Fatorconvbaixa = item.Fatorconvbaixa,
                            Multdivbaixa = item.Multdivbaixa,
                            Codfrete = item.Codfrete,
                            Dtcadastro = item.Dtcadastro,
                            Descricaopreco = item.Descricaopreco,
                            Preco2 = item.Preco2,
                            Descricaopreco2 = item.Descricaopreco2,
                            Preco3 = item.Preco3,
                            Descricaopreco3 = item.Descricaopreco3,
                            Lucro2 = item.Lucro2,
                            Lucro3 = item.Lucro3,
                            Itemportaria790 = item.Itemportaria790,
                            Enviado = item.Enviado,
                            Precodolar = item.Precodolar,
                            Dataultalteracao = item.Dataultalteracao,
                            Percperda = item.Percperda,
                            Precopromo = item.Precopromo,
                            Datainipromo = item.Datainipromo,
                            Datafimpromo = item.Datafimpromo,
                            Substribsaida = item.Substribsaida,
                            Percbasesubstribsaida = item.Percbasesubstribsaida,
                            Percicmssubstribsaida = item.Percicmssubstribsaida,
                            Temsubitens = item.Temsubitens,
                            Codsegmentosubtribsaida = item.Codsegmentosubtribsaida,
                            Aliqicmsdiversos = item.Aliqicmsdiversos,
                            Baseicmsdiversos = item.Baseicmsdiversos,
                            Codtributdiversos = item.Codtributdiversos,
                            Mensagemdiversos = item.Mensagemdiversos,
                            Tipodiversos = item.Tipodiversos,
                            Contacxa = item.Contacxa,
                            Percicmmargemlucro = item.Percicmmargemlucro,
                            Aliqinternaicmlucro = item.Aliqinternaicmlucro,
                            Segmentoicmlucro = item.Segmentoicmlucro,
                            Segmentoicmdiversos = item.Segmentoicmdiversos,
                            Aliqicmsdiversos2 = item.Aliqicmsdiversos2,
                            Baseicmsdiversos2 = item.Baseicmsdiversos2,
                            Codtributdiversos2 = item.Codtributdiversos2,
                            Mensagemdiversos2 = item.Mensagemdiversos2,
                            Controlelote = item.Controlelote,
                            Grade = item.Grade,
                            Aceitaprecozero = item.Aceitaprecozero,
                            Vlrcobraroper = item.Vlrcobraroper,
                            Comissaovlr = item.Comissaovlr,
                            Garantia = item.Garantia,
                            Ipiantigo = item.Ipiantigo,
                            Custodolar = item.Custodolar,
                            Aliqicmspdv = item.Aliqicmspdv,
                            Temrebatefinanc = item.Temrebatefinanc,
                            Lucro4 = item.Lucro4,
                            Descricaopreco4 = item.Descricaopreco4,
                            Preco4 = item.Preco4,
                            Prodbalanca = item.Prodbalanca,
                            Substribsaidar1 = item.Substribsaidar1,
                            Percbasesubstribsaidar1 = item.Percbasesubstribsaidar1,
                            Percicmssubstribsaidar1 = item.Percicmssubstribsaidar1,
                            Substribsaidar2 = item.Substribsaidar2,
                            Percbasesubstribsaidar2 = item.Percbasesubstribsaidar2,
                            Percicmssubstribsaidar2 = item.Percicmssubstribsaidar2,
                            Substribsaidar3 = item.Substribsaidar3,
                            Percbasesubstribsaidar3 = item.Percbasesubstribsaidar3,
                            Percicmssubstribsaidar3 = item.Percicmssubstribsaidar3,
                            Descontomaximo = item.Descontomaximo,
                            Tipomedicamento = item.Tipomedicamento,
                            Descpercpadrao = item.Descpercpadrao,
                            Lucroprevisto = item.Lucroprevisto,
                            Redutor = item.Redutor,
                            Itemportariaforauf = item.Itemportariaforauf,
                            Dataultreajuste = item.Dataultreajuste,
                            Precoanterior = item.Precoanterior,
                            Observacao = item.Observacao,
                            Codvolume = item.Codvolume,
                            Fracionado = item.Fracionado,
                            Codgeneroitem = item.Codgeneroitem,
                            Custooperc = item.Custooperc,
                            Perciva = item.Perciva,
                            Valoripi = item.Valoripi,
                            Tipoentrega = item.Tipoentrega,
                            Liminiloteentrega = item.Liminiloteentrega,
                            Limfimloteentrega = item.Limfimloteentrega,
                            Consideracomissao = item.Consideracomissao,
                            Multiplo = item.Multiplo,
                            Unidademultiplo = item.Unidademultiplo,
                            Substribsaidar4 = item.Substribsaidar4,
                            Percbasesubstribsaidar4 = item.Percbasesubstribsaidar4,
                            Percicmssubstribsaidar4 = item.Percicmssubstribsaidar4,
                            Tipolista = item.Tipolista,
                            Codprodproducao = item.Codprodproducao,
                            Farmaciapopular = item.Farmaciapopular,
                            Cfopdentrouf = item.Cfopdentrouf,
                            Cfopforauf = item.Cfopforauf,
                            Codprodpai = item.Codprodpai,
                            Codfamilia = item.Codfamilia,
                            Codtipoproduto = item.Codtipoproduto,
                            Codprodanp = item.Codprodanp,
                            Version = item.Version,
                            Agrotoxico = item.Agrotoxico,
                            Codigomapa = item.Codigomapa,
                            Codigoembalagem = item.Codigoembalagem,
                            Etqprecobase = item.Etqprecobase,
                            Etqparcelamento = item.Etqparcelamento,
                            Etqtxmes = item.Etqtxmes,
                            Etqinftxmes = item.Etqinftxmes,
                            Etqinfprecobase = item.Etqinfprecobase,
                            Etqinfprecoaprazo = item.Etqinfprecoaprazo,
                            Etqinftxdia = item.Etqinftxdia,
                            Percivasubstribsaida = item.Percivasubstribsaida,
                            Percivasubstribsaida1 = item.Percivasubstribsaida1,
                            Percivasubstribsaida2 = item.Percivasubstribsaida2,
                            Percivasubstribsaida3 = item.Percivasubstribsaida3,
                            Percivasubstribsaida4 = item.Percivasubstribsaida4,
                            Idprodutojava = item.Idprodutojava,
                            Tiposinc = item.Tiposinc,
                            Importaprodecom = item.Importaprodecom,
                            Idprodutoecom = item.Idprodutoecom,
                            Iat = item.Iat,
                            Codenqipi = item.Codenqipi,
                            Codnatreceita = item.Codnatreceita,
                            Idnatreceita = item.Idnatreceita,
                            Codcest = item.Codcest,
                            Tipomateremba = item.Tipomateremba,
                            Idparceiro = item.Idparceiro,
                            Tipoeqpreducaobasedifal = item.Tipoeqpreducaobasedifal,
                            Codselfcolor = item.Codselfcolor,
                            Percentdesctopromocao = item.Percentdesctopromocao,
                            Codshotcolor = item.Codshotcolor,
                            Markuppreco1 = item.Markuppreco1,
                            Markuppreco2 = item.Markuppreco2,
                            Markuppreco3 = item.Markuppreco3,
                            Markuppreco4 = item.Markuppreco4,
                            Escalarelevante = item.Escalarelevante,
                            Conversaoetiquetadeprecos = item.Conversaoetiquetadeprecos,
                            Unidadeaposconverter = item.Unidadeaposconverter,
                            Codregistroanvisa = item.Codregistroanvisa,
                            Sef = item.Sef,
                            Testedogerabanco = item.Testedogerabanco,
                            Passapelolaudo = item.Passapelolaudo,
                            Percglpderivado = item.Percglpderivado,
                            Percgasnatural = item.Percgasnatural,
                            Percgasnaturalinternacional = item.Percgasnaturalinternacional,
                        };
                        fbConnection.Execute(Insert, produto);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}

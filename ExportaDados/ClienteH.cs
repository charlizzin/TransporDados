using Dapper;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportaDados
{
    public class ClienteH
    {
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
        public char? Pessoafj { get; set; } // varchar(1)
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
        public DateTime? Dtcadastro { get; set; } // timestamp
        public DateTime? Dtprimvenda { get; set; } // timestamp
        public DateTime? Dtultvenda { get; set; } // timestamp
        public string Codprazo { get; set; } // varchar(3)
        public string Email { get; set; } // varchar(60)
        public string Campolivre1 { get; set; } // varchar(20)
        public string Campolivre2 { get; set; } // varchar(20)
        public string Campolivre3 { get; set; } // varchar(60)
        public string Campolivre4 { get; set; } // varchar(60)
        public string Homepage { get; set; } // varchar(30)
        public char? Clibloqueado { get; set; } // varchar(1)
        public char? Ativo { get; set; } // varchar(1)
        public DateTime? Dtvalcad { get; set; } // timestamp
        public double? Limitecredito { get; set; } // double precision
        public DateTime? Dtnascimento { get; set; } // timestamp
        public string Observacao { get; set; } // blob sub_type 1
        public string Codfornec { get; set; } // varchar(6)
        public DateTime? Dataultalteracao { get; set; } // timestamp
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
        public int? Tipocontrato { get; set; } // integer
        public int? Diavenccontrato { get; set; } // integer
        public DateTime? Databasecontrato { get; set; } // timestamp
        public double? Qtdsalariominimo { get; set; } // double precision
        public double? Valorcontrato { get; set; } // double precision
        public string Codempresacli { get; set; } // varchar(2)
        public DateTime? Datacancelacontrato { get; set; } // timestamp
        public string Motivocancelacontrato { get; set; } // blob sub_type 1
        public int? Exigenf { get; set; } // integer
        public string Senhainstalacao { get; set; } // blob sub_type 1
        public string Codmotivocanccontrato { get; set; } // varchar(3)
    }
    public class ClienteP : ClienteH { }
    public class ClienteS : ClienteH { }
    public class ClienteRepository
    {
        private readonly string sqlCliente = "Select * from cliente order by codcliente";

        public List<ClienteP> GetListaClientesP()
        {
            IEnumerable ClienteP = new FbConnection(new Conexao().conexao1).Query<ClienteP>(sqlCliente);
            List<ClienteP> listaClientes = new List<ClienteP>();
            foreach (ClienteP itemP in ClienteP)
            {
                listaClientes.Add(itemP);
            }
            return listaClientes;
        }
        public List<ClienteS> GetListaClientesS()
        {
            IEnumerable ClienteS = new FbConnection(new Conexao().conexao2).Query<ClienteS>(sqlCliente);
            List<ClienteS> listaClientes = new List<ClienteS>();
            foreach (ClienteS itemS in ClienteS)
            {
                listaClientes.Add(itemS);
            }
            return listaClientes;
        }
        public List<dynamic> ResultCliente()
        {
            List<ClienteP> ClientesP = GetListaClientesP();
            List<ClienteS> ClientesS = GetListaClientesS();

            List<ClienteP> Resul = new List<ClienteP>();
            foreach (var item in ClientesP)
            {
                Resul.Add(item);
            }

            foreach (var itemP in ClientesP)
            {
                foreach (var itemS in ClientesS)
                {
                    if (itemP.Codcliente.Equals(itemS.Codcliente))
                    {
                        Resul.Remove(itemP);
                        break;
                    }
                }
            }
            return Resul.Cast<dynamic>().ToList();
        }
        public void InsertCliente()
        {
            #region InsertCliente
            string Insert = "INSERT INTO CLIENTE (CODCLIENTE, NOME, NOMEFANTASIA, ENDERECO, BAIRRO, CODCIDADE, " + 
                "ESTADO, CEP, CGCCPF, INSCEST, PESSOA_FJ, CONTATO, FONE, FAX, CODCLASCLI, CODSEGMENTO, ENDERECOCOB, " + 
                "BAIRROCOB, CODCIDADECOB, ESTADOCOB, CEPCOB, CTCTBRED, NOMESOCIO, CODTRANSPT, CODVENDEND1, ENDERECOENT, " +
                "BAIRROENT, CODCIDADEENT, ESTADOENT, CEPENT, DT_CADASTRO, DT_PRIMVENDA, DT_ULTVENDA, CODPRAZO, EMAIL, " +
                "CAMPOLIVRE1, CAMPOLIVRE2, CAMPOLIVRE3, CAMPOLIVRE4, HOMEPAGE, CLIBLOQUEADO, ATIVO, DT_VALCAD, " +
                "LIMITECREDITO, DT_NASCIMENTO, CODFORNEC, DATA_ULT_ALTERACAO, CAMPOLIVRE5, CAMPOLIVRE6, CAMPOLIVRE7, " +
                "CAMPOLIVRE8, CAMPOLIVRE9, CAMPOLIVRE10, CODROTA, TIPOCLIENTE, CELULAR, CODOPCEL, MALADIRETAELETR, " +
                "PREFIXCELULAR, PRAZOPGTOLIBERADO, FORMAPGTOLIBERADO, CODTVENDA, RETEMPISCONFIS, CODREPRESENTANTE, " +
                "TIPOVENDA, SEQROTA, CARENCIADEBITOPDV, GRUPOSPRODUTO, CODFICHA, OUTRASDESPESASNF, OPTANTESIMPLES, " +
                "PROTESTARCLIENTE, INSCMUNICIPAL, PRAZOPROTESTO, RETEMISS, CONTRIBUINTEST, CODCLIENTEECOM, CODPAIS, " +
                "PLACA, KM, VERSION, REVENDAGROTOXICO, ENDERECOPR, BAIRROPR, CODCIDADEPR, ESTADOPR, CEPPR, NOMEPROP, " +
                "CODCIDADEPROP, ESTADOPROP, IDCLIENTEECOM, IDCLIENTEJAVA, DOCUMENTOESTRANGEIRO, VALIDADE, CONTRIBUINTEICMS, " +
                "ALIQIRRF, NUMERO, COMPLEMENTO, NUMEROCOB, COMPLEMENTOCOB, NUMEROENT, COMPLEMENTOENT, GRAVADOPELOECF, " +
                "SINCRONIZADO, CODMUNICIPIO, TIPOCONTRATO, DIAVENCCONTRATO, DATABASECONTRATO, QTDSALARIOMINIMO, " +
                "VALORCONTRATO, CODEMPRESACLI, DATACANCELACONTRATO, EXIGENF, CODMOTIVOCANCCONTRATO)VALUES " +
                "(@CODCLIENTE, @NOME, @NOMEFANTASIA, @ENDERECO, @BAIRRO, @CODCIDADE, " +
                "@ESTADO, @CEP, @CGCCPF, @INSCEST, @PESSOAFJ, @CONTATO, @FONE, @FAX, @CODCLASCLI, @CODSEGMENTO, @ENDERECOCOB, " +
                "@BAIRROCOB, @CODCIDADECOB, @ESTADOCOB, @CEPCOB, @CTCTBRED, @NOMESOCIO, @CODTRANSPT, @CODVENDEND1, @ENDERECOENT, " +
                "@BAIRROENT, @CODCIDADEENT, @ESTADOENT, @CEPENT, @DTCADASTRO, @DTPRIMVENDA, @DTULTVENDA, @CODPRAZO, @EMAIL, " +
                "@CAMPOLIVRE1, @CAMPOLIVRE2, @CAMPOLIVRE3, @CAMPOLIVRE4, @HOMEPAGE, @CLIBLOQUEADO, @ATIVO, @DTVALCAD, " +
                "@LIMITECREDITO, @DTNASCIMENTO, @CODFORNEC, @DATAULTALTERACAO, @CAMPOLIVRE5, @CAMPOLIVRE6, @CAMPOLIVRE7, " +
                "@CAMPOLIVRE8, @CAMPOLIVRE9, @CAMPOLIVRE10, @CODROTA, @TIPOCLIENTE, @CELULAR, @CODOPCEL, @MALADIRETAELETR, " +
                "@PREFIXCELULAR, @PRAZOPGTOLIBERADO, @FORMAPGTOLIBERADO, @CODTVENDA, @RETEMPISCONFIS, @CODREPRESENTANTE, " +
                "@TIPOVENDA, @SEQROTA, @CARENCIADEBITOPDV, @GRUPOSPRODUTO, @CODFICHA, @OUTRASDESPESASNF, @OPTANTESIMPLES, " +
                "@PROTESTARCLIENTE, @INSCMUNICIPAL, @PRAZOPROTESTO, @RETEMISS, @CONTRIBUINTEST, @CODCLIENTEECOM, @CODPAIS, " +
                "@PLACA, @KM, @VERSION, @REVENDAGROTOXICO, @ENDERECOPR, @BAIRROPR, @CODCIDADEPR, @ESTADOPR, @CEPPR, @NOMEPROP, " +
                "@CODCIDADEPROP, @ESTADOPROP, @IDCLIENTEECOM, @IDCLIENTEJAVA, @DOCUMENTOESTRANGEIRO, @VALIDADE, @CONTRIBUINTEICMS, " +
                "@ALIQIRRF, @NUMERO, @COMPLEMENTO, @NUMEROCOB, @COMPLEMENTOCOB, @NUMEROENT, @COMPLEMENTOENT, @GRAVADOPELOECF, " +
                "@SINCRONIZADO, @CODMUNICIPIO, @TIPOCONTRATO, @DIAVENCCONTRATO, @DATABASECONTRATO, @QTDSALARIOMINIMO, " +
                "@VALORCONTRATO, @CODEMPRESACLI, @DATACANCELACONTRATO, @EXIGENF, @CODMOTIVOCANCCONTRATO)";
            #endregion

            Conexao conexao = new Conexao();
            FbConnection fbConnection = new FbConnection(conexao.conexao2);
            ClienteS cliente = new ClienteS();
            var result = ResultCliente();

            foreach (var item in result)
            {
                if (result.Count != 0)
                {
                    try
                    {
                        cliente = new ClienteS
                        {
                            Codcliente = item.Codcliente,
                            Nome = item.Nome,
                            Nomefantasia = item.Nomefantasia,
                            Endereco = item.Endereco,
                            Bairro = item.Bairro,
                            Codcidade = item.Codcidade,
                            Estado = item.Estado,
                            Cep = item.Cep,
                            Cgccpf = item.Cgccpf,
                            Inscest = item.Inscest,
                            Pessoafj = item.Pessoafj,
                            Contato = item.Contato,
                            Fone = item.Fone,
                            Fax = item.Fax,
                            Codclascli = item.Codclascli,
                            Codsegmento = item.Codsegmento,
                            Enderecocob = item.Enderecocob,
                            Bairrocob = item.Bairrocob,
                            Codcidadecob = item.Codcidadecob,
                            Estadocob = item.Estadocob,
                            Cepcob = item.Cepcob,
                            Ctctbred = item.Ctctbred,
                            Nomesocio = item.Nomesocio,
                            Codtranspt = item.Codtranspt,
                            Codvendend1 = item.Codvendend1,
                            Enderecoent = item.Enderecoent,
                            Bairroent = item.Bairroent,
                            Codcidadeent = item.Codcidadeent,
                            Estadoent = item.Estadoent,
                            Cepent = item.Cepent,
                            Dtcadastro = item.Dtcadastro,
                            Dtprimvenda = item.Dtprimvenda,
                            Dtultvenda = item.Dtultvenda,
                            Codprazo = item.Codprazo,
                            Email = item.Email,
                            Campolivre1 = item.Campolivre1,
                            Campolivre2 = item.Campolivre2,
                            Campolivre3 = item.Campolivre3,
                            Campolivre4 = item.Campolivre4,
                            Homepage = item.Homepage,
                            Clibloqueado = item.Clibloqueado,
                            Ativo = item.Ativo,
                            Dtvalcad = item.Dtvalcad,
                            Limitecredito = item.Limitecredito,
                            Dtnascimento = item.Dtnascimento,
                            Observacao = item.Observacao,
                            Codfornec = item.Codfornec,
                            Dataultalteracao = item.Dataultalteracao,
                            Campolivre5 = item.Campolivre5,
                            Campolivre6 = item.Campolivre6,
                            Campolivre7 = item.Campolivre7,
                            Campolivre8 = item.Campolivre8,
                            Campolivre9 = item.Campolivre9,
                            Campolivre10 = item.Campolivre10,
                            Codrota = item.Codrota,
                            Tipocliente = item.Tipocliente,
                            Celular = item.Celular,
                            Codopcel = item.Codopcel,
                            Maladiretaeletr = item.Maladiretaeletr,
                            Prefixcelular = item.Prefixcelular,
                            Prazopgtoliberado = item.Prazopgtoliberado,
                            Formapgtoliberado = item.Formapgtoliberado,
                            Codtvenda = item.Codtvenda,
                            Retempisconfis = item.Retempisconfis,
                            Codrepresentante = item.Codrepresentante,
                            Tipovenda = item.Tipovenda,
                            Seqrota = item.Seqrota,
                            Carenciadebitopdv = item.Carenciadebitopdv,
                            Gruposproduto = item.Gruposproduto,
                            Codficha = item.Codficha,
                            Outrasdespesasnf = item.Outrasdespesasnf,
                            Optantesimples = item.Optantesimples,
                            Protestarcliente = item.Protestarcliente,
                            Inscmunicipal = item.Inscmunicipal,
                            Prazoprotesto = item.Prazoprotesto,
                            Retemiss = item.Retemiss,
                            Contribuintest = item.Contribuintest,
                            Codclienteecom = item.Codclienteecom,
                            Codpais = item.Codpais,
                            Placa = item.Placa,
                            Km = item.Km,
                            Version = item.Version,
                            Revendagrotoxico = item.Revendagrotoxico,
                            Enderecopr = item.Enderecopr,
                            Bairropr = item.Bairropr,
                            Codcidadepr = item.Codcidadepr,
                            Estadopr = item.Estadopr,
                            Ceppr = item.Ceppr,
                            Nomeprop = item.Nomeprop,
                            Codcidadeprop = item.Codcidadeprop,
                            Estadoprop = item.Estadoprop,
                            Idclienteecom = item.Idclienteecom,
                            Digital1 = item.Digital1,
                            Digital2 = item.Digital2,
                            Digital3 = item.Digital3,
                            Idclientejava = item.Idclientejava,
                            Documentoestrangeiro = item.Documentoestrangeiro,
                            Validade = item.Validade,
                            Contribuinteicms = item.Contribuinteicms,
                            Aliqirrf = item.Aliqirrf,
                            Numero = item.Numero,
                            Complemento = item.Complemento,
                            Numerocob = item.Numerocob,
                            Complementocob = item.Complementocob,
                            Numeroent = item.Numeroent,
                            Complementoent = item.Complementoent,
                            Gravadopeloecf = item.Gravadopeloecf,
                            Sincronizado = item.Sincronizado,
                            Codmunicipio = item.Codmunicipio,
                            Tipocontrato = item.Tipocontrato,
                            Diavenccontrato = item.Diavenccontrato,
                            Databasecontrato = item.Databasecontrato,
                            Qtdsalariominimo = item.Qtdsalariominimo,
                            Valorcontrato = item.Valorcontrato,
                            Codempresacli = item.Codempresacli,
                            Datacancelacontrato = item.Datacancelacontrato,
                            Motivocancelacontrato = item.Motivocancelacontrato,
                            Exigenf = item.Exigenf,
                            Senhainstalacao = item.Senhainstalacao,
                            Codmotivocanccontrato = item.Codmotivocanccontrato
                        };
                        fbConnection.Execute(Insert, cliente);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.FluentColumnMapping;
using TransporDados.DataTransferObject;
using Dapper.FluentMap.Mapping;

namespace TransporDados.Mapper
{
    public class ClienteMap : EntityMap<Cliente>
    {
        public void MapCliente()
        {
            //var mapper = new ColumnMappingCollection();

            //mapper.RegisterType<Cliente>()
            //    .MapProperty(x => x.Pessoafj).ToColumn("PESSOA_JF")
            //    .MapProperty(x => x.Dtcadastro).ToColumn("DT_CADASTRO")
            //    .MapProperty(x => x.Dtprimvenda).ToColumn("DT_PRIMVENDA")
            //    .MapProperty(x => x.Dtultvenda).ToColumn("DT_ULTVENDA")
            //    .MapProperty(x => x.Dtvalcad).ToColumn("DT_VALCAD")
            //    .MapProperty(x => x.Dtnascimento).ToColumn("DT_NASCIMENTO")
            //    .MapProperty(x => x.Dataultalteracao).ToColumn("DATA_ULT_ALTERACAO");
            //mapper.RegisterWithDapper();
            Map(x => x.Pessoa_fj).ToColumn("PESSOA_JF");
            Map(x => x.Dtcadastro).ToColumn("DT_CADASTRO");
            Map(x => x.Dtprimvenda).ToColumn("DT_PRIMVENDA");
            Map(x => x.Dtultvenda).ToColumn("DT_ULTVENDA");
            Map(x => x.Dtvalcad).ToColumn("DT_VALCAD");
            Map(x => x.Dtnascimento).ToColumn("DT_NASCIMENTO");
            Map(x => x.Dataultalteracao).ToColumn("DATA_ULT_ALTERACAO");
        }
    }
}

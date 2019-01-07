using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.FluentColumnMapping;

namespace TransporDados
{
    public class CidadeMap
    {
        public void MapCidade()
        {
            var mapping = new ColumnMappingCollection();
            mapping.RegisterType<Cidades>()
                .MapProperty(x => x.CodCidade).ToColumn("CODCIDADE")
                .MapProperty(X => X.Cidade).ToColumn("CIDADE")
                .MapProperty(X => X.Estado).ToColumn("ESTADO")
                .MapProperty(X => X.CodMunicipio).ToColumn("CODMUNICIPIO")
                .MapProperty(X => X.CodSiafi).ToColumn("CODSIAFI");
            mapping.RegisterWithDapper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace TransporDados
{
    public class Cidades
    {
        [ExplicitKey]
        public string CodCidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CodMunicipio { get; set; }
        public string CodSiafi { get; set; }

        //[ExplicitKey]
        //private string _CodCidade { get; set; }
        //private string _Cidade { get; set; }
        //private string _Estado { get; set; }
        //private string _CodMunicipio { get; set; }
        //private string _CodSiafi { get; set; }

        //[ExplicitKey]
        //public string CodCidade
        //{
        //    get
        //    {
        //        return _CodCidade;
        //    }
        //    set
        //    {
        //        _CodCidade = value;
        //    }
        //}
        //public string Cidade
        //{
        //    get
        //    {
        //        return _Cidade;
        //    }
        //    set
        //    {
        //        _Cidade = value;
        //    }
        //}
        //public string Estado
        //{
        //    get
        //    {
        //        return _Estado;
        //    }
        //    set
        //    {
        //        _Estado = value;
        //    }
        //}
        //public string CodMunicipio
        //{
        //    get
        //    {
        //        return _CodMunicipio;
        //    }
        //    set
        //    {
        //        _CodMunicipio = value;
        //    }
        //}
        //public string CodSiafi
        //{
        //    get
        //    {
        //        return _CodSiafi;
        //    }
        //    set
        //    {
        //        _CodSiafi = value;
        //    }
        //}
    }
}

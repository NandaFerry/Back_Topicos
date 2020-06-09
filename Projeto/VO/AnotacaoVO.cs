using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.VO
{
    public class AnotacaoVO : BaseVO
    {
        public string  Obs { set; get; }

        public System.DateTime Data { set; get; }

        public int? Id_pessoa_grupo { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TransfBancarias_DIO.Enumeradores
{
    public enum TipoConta
    {
        [Description("Pessoa Física")]
        Pf = 1,
        [Description("Pessoa Jurídica")]
        Pj = 2
    }
}

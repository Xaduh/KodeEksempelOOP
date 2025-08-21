using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSandkasse
{
    internal class Ansat : PersonOld
    {
        //public string Navn { get; set; }
        //public string Efternavn { get; set; }
        //public string Adresse { get; set; }
        //public string Tlf { get; set; }
        public decimal Løn { get; set; }
        public decimal Provision { get; set; }
        public void ProvisionUdregner(decimal TotalSalgPrDag)
        {
            Provision = TotalSalgPrDag * 0.05M;
        }
        public void LønUdregner(decimal GrundLøn)
        {
            Løn = GrundLøn + Provision;
        }
    }
}

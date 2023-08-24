using OpgaveTilmeldning.Køretøjer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecTilmeldning.Køretøjer
{
    internal class Bil : Kørtøj, FireHjulKøretøj
    {
        public double? MotorStørrelse { get; set; }
        public int? BagagerumVolumelKubikCm { get; set; }


        public Bil(string? mærke, string? model, double motorStørrelse, int bagagerumVolumelKubikCm) : base(mærke, model)
        {
            MotorStørrelse = motorStørrelse;
            BagagerumVolumelKubikCm = bagagerumVolumelKubikCm;
        }
    }
}
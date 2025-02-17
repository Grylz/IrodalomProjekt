using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodalomProjekt.Models
{
    internal class Kerdes
    {
        public string KerdesSzovege { get; set; }
        public string ValaszA { get; set; }
        public string ValaszB { get; set; }
        public string ValaszC { get; set; }
        public string ValaszD { get; set; }
        public string HelyesValasz { get; set; }
        public string FelhasznaloValasz { get; set; }


        public Kerdes(string KerdesSzovege, string ValaszA, string ValaszB, string ValaszC, string ValaszD, string HelyesValasz, string FelhasznaloValasz) 
        {
            this.KerdesSzovege = KerdesSzovege;
            this.ValaszA = ValaszA;
            this.ValaszB = ValaszB;
            this.ValaszC = ValaszC;
            this.ValaszD = ValaszD;
            this.HelyesValasz = HelyesValasz;
            this.FelhasznaloValasz = FelhasznaloValasz;
        }

        /// <summary>  
        /// A felhasználó válaszának ellenőrzése, ha nincs kitöltve, akkor a válasz automatikusan hibás. 
        /// </summary>
        /// <returns></returns>>
        public bool ValaszEllenorzes()
        {
            return FelhasznaloValasz is null? false: FelhasznaloValasz.ToLower() == HelyesValasz.ToLower();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podroz
{
    class Stacja:ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna;

        public Stacja(string nazwaStacji,bool oplataKlimatyczna)
        {
            this.nazwaStacji = nazwaStacji;
            this.oplataKlimatyczna = oplataKlimatyczna;
        }
        public override string ToString()
        {
            string sprczy="z";
            if (oplataKlimatyczna==true) sprczy= "tak";
            if (oplataKlimatyczna==false) sprczy= "nie";
            return "Stacja: " + nazwaStacji + ", oplata klimatyczna: " + sprczy;
        }
        
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}

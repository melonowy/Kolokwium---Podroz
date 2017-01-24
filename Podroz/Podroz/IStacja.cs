using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podroz
{
    interface IStacja
    {
        void DodajStacje(string nazwa, bool oplata);
        void Powrot();
        void UsunStacje();
        void ZapiszPodroz();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Podroz
{
    class Podroz:IStacja
    {
        protected Stack<Stacja> stacje = new Stack<Stacja>();
        protected double koszt = 77;

        public Podroz()
        {
            
        }

        protected virtual double KosztPoRabacie()
        {   double procent;
            double kosztporabacie;
            procent = koszt*0.12;
            kosztporabacie = koszt - procent;
            return kosztporabacie;
        }

        public override string ToString()
        {
            string output = "Podroz:\n";
            string output2 = "Stacja: ";
            string output3 = "";
            foreach(var stac in stacje)
            {
                output2 += stac.Clone()+",";
            }
            output3 = output + output2 + "Koszt po rabacie: " + KosztPoRabacie();
            return output3;
        }

        public void DodajStacje(string nazwaStacji, bool oplataKlimaczyczna)
        {
            stacje.Push(new Stacja(nazwaStacji, oplataKlimaczyczna));
            if (oplataKlimaczyczna == true) koszt += 8;
        }
        public void UsunStacje()
        {
            stacje.Pop();
        }

        public void Powrot()
        {

        }

        public void ZapiszPodroz()
        {   string path = Directory.GetCurrentDirectory();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"path\string\podroze.txt",true))
            {
                file.WriteLine(ToString());
            }
        }

    }
}

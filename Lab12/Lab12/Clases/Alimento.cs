using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.Clases
{
    [Serializable]
    public class Alimento
    {
        string name;
        double protes;
        double carbos;
        double grasa;

        public Alimento(string Name, double Protes, double Carbos, double Grasa) {
            name = Name;
            protes = Protes;
            carbos = Carbos;
            grasa = Grasa;
        }
        public override string ToString()
        {
            return$"{name}(Carbohidratos: Proteinas: Grasas:,Calorias{this.Calorias()})";
        }
        public double Calorias()
        {
            return (4 * protes + 4 * carbos + 9 * grasa);
        }
    }
}

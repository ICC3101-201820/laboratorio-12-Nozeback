using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.Clases
{
    [Serializable]
    public class ListaAlimentos
    {
        List<Alimento> comidas;
        public ListaAlimentos() {
            comidas = new List<Alimento>();
         }
        public void Agregar(Alimento alimento)
        {
            comidas.Add(alimento);
        }
        public void Eliminar(Alimento alimento)
        {
            comidas.Remove(alimento);
        }
    }
}

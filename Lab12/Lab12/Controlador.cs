using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Controlador
    {
        public Form1 form1;
        private Clases.ListaAlimentos listado;
        public Controlador() {
            listado = this.DeSerializar();
        }
        public void OnEliminarComida(string name, double prote, double carbos, double grasa)
        {
            Clases.Alimento alm = new Clases.Alimento(name,prote, carbos, grasa);
            listado.Eliminar(alm);
            form1.EliminarComida(alm);
        }
        public void OnAgregarComida(string name, double prote, double carbos, double grasa)
        {
            Clases.Alimento alm = new Clases.Alimento(name, prote, carbos, grasa);
            listado.Agregar(alm);
            form1.AgregarComida(alm);
        }
        public Clases.ListaAlimentos DeSerializar()
        {
            if (File.Exists(@"..\..\docs\Alimentos") == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\Alimentos", FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                Clases.ListaAlimentos elem = _formatter.Deserialize(_fs) as Clases.ListaAlimentos;
                _fs.Close();
                return elem;
            }
            else return new Clases.ListaAlimentos();
        }
        public void Serializar()
        {
            if (listado != null)
            {
                FileStream _fs = new FileStream(@"..\..\docs\Alimentos.dat", FileMode.Create);
                BinaryFormatter _formatter = new BinaryFormatter();
                _formatter.Serialize(_fs, listado);
                _fs.Close();
            }
        }
    }
}

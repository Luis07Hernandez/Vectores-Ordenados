using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class CarroIniciar
    {
        private string placa;
        private string marca;
        private string modelo;
        private string telefono;
        private string año;
        private string FALLO = "No se encontro";

        public string FALLO_1
        {
            get { return FALLO; }
        }
        public string placa_1
        {
            get { return placa; }
            set { placa = value; }
        }
        public string marca_1
        {
            get { return marca; }
            set { marca = value; }
        }
        public string modelo_1
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string telefono_1
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string ano_1
        {
            get { return año; }
            set { año = value; }
        }
    }
}

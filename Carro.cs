using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Carro
    {
        CarroIniciar[] car = new CarroIniciar[15];
        public int i = 0;
        public int t = 14;
        int contador = 0;
        

        public void agregar(CarroIniciar datos)
        {
            car[contador] = datos;
            contador++;
        }

        public CarroIniciar buscar(string placas)
        {
            
            int y = 0;
            for (int x = 0; x < contador; x++)
            {
                if (car[x].placa_1 == placas)
                {
                    return car[x];
                }
            
            }
            return null;
        }

        public void eliminar(string placa)
        {
            for (int e = 0; e < contador; e++)
            {
                if (car[e].placa_1 == placa)
                {
                    car[e] = car[e + 1];


                    car[contador - 1] = null;
                    contador--;
                }
            }
        }
   
    

        public string listar()
        {
            string mostrar = " ";
            for (int m = 0; m < contador; m++)
            {
                mostrar += "[" + m + "]"+Environment.NewLine + car[m].placa_1 + Environment.NewLine + car[m].marca_1 + Environment.NewLine + car[m].modelo_1 + Environment.NewLine + car[m].telefono_1 + Environment.NewLine + car[m].ano_1 + Environment.NewLine;
            }
            return mostrar;
        }
    }
}

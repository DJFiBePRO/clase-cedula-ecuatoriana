using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppRioinvernaderos
{
    class ClValidarCed
    {
        string cedula;
        public ClValidarCed(string cd)
        {
            cedula = string.Copy(cd);
        }
        public int[] vector()
        {
            int[] vc = new int[10];
            string aux;
            for(int i=0; i < cedula.Length; i++)
            {
                aux = cedula[i].ToString();
                vc[i] = int.Parse(aux);
            }
            return vc;
        }
        public bool Verificar()
        {
            bool respuesta;
            int suma = 0, aux = 0; 
            int[] vec = new int[10];

            vec = vector();
            
            for(int i=0; i < 9; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    suma += vec[i];
                   
                }
                else
                {
                    aux = (vec[i] * 2);
                    if (aux > 9)
                    {
                        suma += (aux-9);

                    }
                    else
                    {
                        suma += aux;
                    }
                }
            }

            int residuo = suma % 10;
            if (residuo != 0)
                suma = 10 - residuo;
            else
                suma = residuo;

            if (suma == vec[9])
            {
                respuesta = true;
                MessageBox.Show("Cédula correcta","",MessageBoxButtons.OK);
            }
            else
            {
                respuesta = false;
                MessageBox.Show("Cédula incorrecta", "Error",MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
                
            return respuesta;
        }
    }
}

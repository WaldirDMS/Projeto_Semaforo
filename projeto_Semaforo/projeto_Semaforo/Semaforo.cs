using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_Semaforo
{
    class Semaforo
    {
        private byte luz;

        public Semaforo()
        {
            this.luz = 0;
        }

        public Semaforo(byte luz)
        {
            this.luz = luz;
        }

        public void setLuz(byte luz)
        {
            this.luz = luz;
        }

        public byte getLuz()
        {
            return this.luz;
        }

        public bool getLuz(int bit)
        {
            byte novoDado;
            int valor;
            valor = (int)Math.Pow(2, bit - 1);
            novoDado = (byte)((int)this.luz & valor);
            return (novoDado > 0);
        }

        public void setLuz1(int bit)
        {
            int valor;
            valor = (int)Math.Pow(2, bit - 1);
            this.luz = (byte)((int)this.luz | valor);
        }

        public void setLuz0(int bit)
        {
            int valor;
            valor = 255 - (int)Math.Pow(2, bit - 1);
            this.luz = (byte)((int)this.luz & valor);

        }
    }
}

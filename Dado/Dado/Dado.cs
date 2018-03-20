using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dado
{
    class Dado
    {
        private int[] dado;
        private int[] Vectores;
        public Dado()
        {
            dado = new int[6];
            Vectores = new int[11];
            Thread.Sleep(1);//Tarda un milisegundo contando para que pueda genera un segundo numero.
        }
        Random ran = new Random(DateTime.Now.Millisecond);
        public void Lanzar()
        {
            int num = ran.Next(1, 7);
            switch (num)
            {
                case 1:
                    dado[num - 1] += 1;
                    break;
                case 2:
                    dado[num - 1] += 1;
                    break;
                case 3:
                    dado[num - 1] += 1;
                    break;
                case 4:
                    dado[num - 1] += 1;
                    break;
                case 5:
                    dado[num - 1] += 1;
                    break;
                case 6:
                    dado[num - 1] += 1;
                    break;
            }
        }
        public override string ToString()
        {
            string Ret = "";
            for (int a = 0; a < 6; a++)
            {
                Ret += "Cara " + (a + 1) + " cayo " + dado[a] + " veces." + Environment.NewLine;
            }

            return Ret;
        }//dado 2
        public void Lanzar2()
        {
            int num = ran.Next(1, 7);
            num += ran.Next(1, 7);
            switch (num)
            {
                case 2:
                    Vectores[num - 2] += 1;
                    break;
                case 3:
                    Vectores[num - 2] += 1;
                    break;
                case 4:
                    Vectores[num - 2] += 1;
                    break;
                case 5:
                    Vectores[num - 2] += 1;
                    break;
                case 6:
                    Vectores[num - 2] += 1;
                    break;
                case 7:
                    Vectores[num - 2] += 1;
                    break;
                case 8:
                    Vectores[num - 2] += 1;
                    break;
                case 9:
                    Vectores[num - 2] += 1;
                    break;
                case 10:
                    Vectores[num - 2] += 1;
                    break;
                case 11:
                    Vectores[num - 2] += 1;
                    break;
                case 12:
                    Vectores[num - 2] += 1;
                    break;
            }

        }
        public string toStringVelores()
        {
            string Ret = "";
            for (int a = 0; a < 11; a++)
            {
                Ret += "El valor " + (a + 2) + " cayo " + Vectores[a] + " veces." + Environment.NewLine;
            }
            return Ret;
        }//dado 3
        public void Lanzar3()
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_astratte
{
   public abstract class Figura
    {
       protected string mNome;
       protected int mNumeroLati;

       public Figura(string Nome, int Numerolati)
       {
           mNome = Nome;
           mNumeroLati = Numerolati;
       }

       public string getNome()
       {
           return mNome;
       }
    }
}

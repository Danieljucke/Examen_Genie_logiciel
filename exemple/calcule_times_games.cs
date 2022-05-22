using System;
using System.Collections.Generic;
using System.Text;

namespace exemple
{
    class calcule_times_games
    {
        private int prendre;
        // j'ai déclaré la variable privé pour eviter qu'elle soit manipuler par d'autres classes 
        public void setprendre (int count)
        {
            /* j'ai utilisé un setter pour pouvoir modifier la variable que dans la classe mais en prenant 
            que la variable d'une autre classe
            */            
            this.prendre = count ;
        }
        public int getprendre ()
        {
            /* le getter va retourner la valeur prise par le setter et le modifier dans la classe */
            return this.prendre; 
        }
        protected int a;
        public int incrementer ()
        {
            // après ca reste plus qu'a faire une incrementation et le tout est joué
            a= this.prendre +1;
            return a;
        }
        /* l'autre methode fonctionne aussi mais elle est deconseillé parce qu'elle peut etre modifier a tout moment*/
    }
}

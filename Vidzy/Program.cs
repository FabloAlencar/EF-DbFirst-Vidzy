using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbContext = new VidzyEntities();

            dbContext.AddVideo("Central do Brasil", DateTime.Now, "Family", (byte)Classification.Gold);
            dbContext.AddVideo("Lisbela e o Prisioneiro", DateTime.Now, "Romance", (byte)Classification.Silver);
            dbContext.AddVideo("Tropa de Elite", DateTime.Now, "Action", (byte)Classification.Gold);
            dbContext.AddVideo("O Auto da Compadecida", DateTime.Now, "Comedy", (byte)Classification.Platinum);
            dbContext.AddVideo("Cidade de Deus", DateTime.Now, "Thriller", (byte)Classification.Platinum);
            dbContext.AddVideo("O Home que Desafiou o Diabo", DateTime.Now, "Horror", (byte)Classification.Silver);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Bolo
    {
        List<Ingrediente> ingredientes;
    }

    public class Ingrediente
    {
        string nome = "Farinha de trigo";
        string Cor = "branca";
        decimal PesoEmGramas = 500;
        decimal volumeEmMl = 0;
    }
}

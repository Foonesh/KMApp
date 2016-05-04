using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogicLayer.Interfaces
{
    public interface ICalculatedData
    {
        Dictionary<string, float> CorrectValues { get; set; }

        float PersonIndex { get; set; }







    }
}

//http://www.poradnikzdrowie.pl/diety/abc-odchudzania/wzory-na-idealna-mase-ciala_43234.html
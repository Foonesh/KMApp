using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogicLayer.Interfaces
{
    public interface IUsNavyIndexData
    {
         float abdomen { get; set; }
         float neck { get; set; }
         
         float chest { get; set; }

        float hip { get; set; }

    }
}

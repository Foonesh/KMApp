using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.HelpersData
{
    public class UsNavyIndexData:IUsNavyIndexData
    {
        public float abdomen { get; set; }
        public float neck { get; set; }
        public float chest { get; set; }
        public float hip { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Model
{
    public class Experience
    {
        public SPECIALType CurrentType { get; init; }
        
        public Experience(SPECIALType sp)
        {
            CurrentType = sp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Core.Common
{
    public abstract class ObjectBase
    {
        public static CompositionContainer Container { get; set; }
    }
}

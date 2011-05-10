using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleFormBuilder
{
    public interface IFormDefinition
    {
        void Build(FormBuilder form);
    }
}

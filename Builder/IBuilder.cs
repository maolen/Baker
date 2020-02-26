using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void AddPart(string part);
        string GetProduct();
    }
}

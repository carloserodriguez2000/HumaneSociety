using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class ReptileInmunization : inmunization
    {
        List<string> inmunizations;     
        public void AddInmunization(string inmuniKind)
        {
            inmunizations.Add(inmuniKind);
            throw new System.NotImplementedException();
        }
    }
}
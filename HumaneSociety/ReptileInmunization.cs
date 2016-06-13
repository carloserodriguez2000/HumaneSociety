using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class ReptileInmunization : Inmunization
    {
        List<string> inmunizations= new List<string>();     
        public void AddInmunization(string inmuniKind)
        {
            inmunizations.Add(inmuniKind);
            throw new System.NotImplementedException();
        }
    }
}
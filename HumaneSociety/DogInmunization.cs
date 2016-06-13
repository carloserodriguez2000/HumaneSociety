using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumaneSociety
{
    public class DogInmunization : Inmunization
    {
        private List<string> inmunizationNames = new List<string>();

        public DogInmunization()
        {
            //Open Dog CSv file
            // inmunizationNames.AddRange({ "Canine Parvovirus"});
            // Remove hard coding later.
            inmunizationNames.Add("Canine Parvovirus");
            inmunizationNames.Add("Distemper Parvo Vaccines");
            inmunizationNames.Add("Canine Hepatitis");
            inmunizationNames.Add("Rabies");
            inmunizationNames.Add("Bordetella Bronchiseptica");
            inmunizationNames.Add("Borrelia Burgdorferi");
            inmunizationNames.Add("Leptospira Bacteria");
            inmunizationNames.Add("Corona virus");
            inmunizationNames.Add("Lyme vaccines");
            inmunizationNames.Add("Giardia Vaccine");
        }
    }
}
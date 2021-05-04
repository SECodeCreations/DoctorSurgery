using SoftwareLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLibrary.Models
{
    class MedicationDetails : IMedicationDetails
    {
        public string Dosage { get; set; }
        public string NameOfMedication { get; set; }
    }
}
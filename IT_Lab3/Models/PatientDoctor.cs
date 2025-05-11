using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_Lab3.Models
{
	public class PatientDoctor
	{
        public PatientDoctor()
        {
            Patients = new List<Patient>();
        }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
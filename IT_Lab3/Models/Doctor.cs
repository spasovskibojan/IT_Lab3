using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Lab3.Models
{
	public class Doctor
	{
        public Doctor()
        {
            Patients = new List<Patient>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
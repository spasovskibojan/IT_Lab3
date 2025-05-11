using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Lab3.Models
{
	public class Patient
	{
        public Patient()
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Range(10000, 99999, ErrorMessage = "Kodot mora da bide so 5 cifri")]
        public int PatientCode { get; set; }
        [Required(ErrorMessage ="Zadolzitelno ime na pacientot")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; } // virtual : relacija a ne nova promenliva
    }
}
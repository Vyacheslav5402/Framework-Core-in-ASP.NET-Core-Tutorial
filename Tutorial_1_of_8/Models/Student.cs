﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Tutorial_1_of_8.Models;

namespace Tutorial_1_of_8.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}


//public class Student
//{
//    public int ID { get; set; }
//    [Required]
//    [StringLength(50)]
//    [Display(Name = "Last Name")]
//    public string LastName { get; set; }
//    [Required]
//    [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
//    [Column("FirstName")]
//    [Display(Name = "First Name")]
//    public string FirstMidName { get; set; }
//    [DataType(DataType.Date)]
//    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
//    [Display(Name = "Enrollment Date")]
//    public DateTime EnrollmentDate { get; set; }
//    [Display(Name = "Full Name")]
//    public string FullName
//    {
//        get
//        {
//            return LastName + ", " + FirstMidName;
//        }
//    }

//    public ICollection<Enrollment> Enrollments { get; set; }
//}
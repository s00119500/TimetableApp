using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public abstract class AllClasses
    {
        [Key]
        public int primaryKey { get; set; }
    }
    public abstract class People : AllClasses
    {
        [Display(Name = "First Name")]
        [Required]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Second Name")]
        public string secondName { get; set; }
    }
    public class Student : People
    {   
        [Required]
        [Display(Name = "Age")]
        public int age { get; set; }
        [Required]
        [Display(Name="Date of birth")]
        public DateTime dateOfBirth { get; set; }
        [Required]
        [Display(Name = "Year/Class")]
        public string studentClass { get; set; }
    }
    public class Subject : AllClasses
    {
        [Display(Name = "Subject Name")]
        public string subjectName { get; set; }
    }

    public class Teacher : People
    {}
    public class Room : AllClasses
    {
        [Display(Name = "Room Name")]
        public string roomName { get; set; }
        [Display(Name="Room Number")]
        public string roomNumber { get; set; }
    }
}
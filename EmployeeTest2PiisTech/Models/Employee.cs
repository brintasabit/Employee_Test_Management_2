//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace EmployeeTest2PiisTech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name Required!")]
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<double> Salary { get; set; }
        [DisplayName("Profile")]
        public string ImagePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
        public Employee()
        {
            ImagePath = "~/AppFiles/ImageFiles/Default.png";
        }
    }
}
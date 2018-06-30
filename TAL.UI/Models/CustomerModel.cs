using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TAL.UI.Models
{
    public class CustomerModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Gender gender { get; set; }
    }

    public enum Gender { male,female}
}
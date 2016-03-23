using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpEditor.Models
{
    public class EmpModel
    {
        [Required(ErrorMessage ="Name is required!")]
        [MaxLength(5)]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
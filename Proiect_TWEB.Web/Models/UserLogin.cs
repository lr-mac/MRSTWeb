using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_TWEB.Web.Models
{
     public class UserLogin
     {
          [Required]
          [Display(Name = "Username or Email")]
          public string Credential { get; set; }

          [Required]
          [DataType(DataType.Password)]
          [Display(Name = "Pasword")]
          public string Password { get; set; }
     }
}

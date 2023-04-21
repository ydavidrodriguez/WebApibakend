using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MStudent
    {
        [Key]
        public Guid Id {get; set;}

        #region Names
        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name {get; set;}
        #endregion
        #region LasNames
        [Required(ErrorMessage = "El campo es requerido")]
        [Display(Name = "LastName")]
        [DataType(DataType.Text)]
        public string LastName {get; set;}
        #endregion
        public int Age {get; set;}     
        public DateTime BirthDate {get; set;}     

    }
}

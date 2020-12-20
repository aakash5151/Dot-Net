using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Models
{
   
    public class Users
    {
        [Key]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter field")]
        public string loginName { get; set; }

        [MaxLength(10), MinLength(4)]
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [MaxLength(10), MinLength(4)]
        [Required(ErrorMessage = "Please enter Field")]
        [DataType(DataType.Text)]
        public string fullName { get; set; }

        [Required(ErrorMessage = "Please enter Field")]
        [DataType(DataType.EmailAddress)]
        public string emailId { get; set; }
        public int cityId { get; set; }

        [Required(ErrorMessage = "Please enter Field")]
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$",
           ErrorMessage = "Not a valid Phone number")]

        public string phone { get; set; }
        public IEnumerable<SelectListItem> Cities{ get; set; }


    }
}
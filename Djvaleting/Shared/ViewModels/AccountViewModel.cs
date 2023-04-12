using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Djvaleting.Shared.ViewModels
{
    public class AccountViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get;  set; }
    }
}

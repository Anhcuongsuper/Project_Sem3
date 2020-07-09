﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTM.Mgs.Models
{
   public class LoginModel
    {
        [Required(ErrorMessage = "UserName not emplty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password not emplty")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}

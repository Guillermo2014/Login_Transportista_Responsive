﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Logictrack_listado.Models
{
    public class Login
    {
        public int idUsuario { get; set; }

        [Required]
        public string user { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        public string rol { get; set; }
        public int idTransportista { get; set; }
    }
}
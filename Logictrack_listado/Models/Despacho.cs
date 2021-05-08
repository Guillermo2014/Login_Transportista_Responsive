﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logictrack_listado.Models
{
    public class Despacho
    {
        public int idDespacho { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaDespacho { get; set; }
        public string direccionEntrega { get; set; }
        public string observacion { get; set; }
        public string estado { get; set; }
        public int idSolicitante { get; set; }
        public int idRecepcionista { get; set; }
        // int idTransportista { get; set; }
        public Cliente solicitante { get; set; }

        public Cliente recepcionista { get; set; }

        public List<DetalleDespacho> detallesDespacho { get; set; }
    }
}
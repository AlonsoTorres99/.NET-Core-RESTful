﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tiendas.Queries.GetStoreList
{
    public class StoreListDto
    {
        public int TiendaID { get; set; }
        public string Sucursal { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }
}

﻿using CotizarArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizarArticulos.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Articulos> Articulo { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}

﻿using CotizarArticulos.DAL;
using CotizarArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CotizarArticulos.BLL
{
   public class ArticulosBll
    {
        public static bool Guardar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Articulo.Add(articulos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Articulos articulos)
        {
            bool paso = true;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Articulos articulos = contexto.Articulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static Articulos Buscar(int id)
        {
          
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();
            try
            {
                articulos = contexto.Articulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
    }
}

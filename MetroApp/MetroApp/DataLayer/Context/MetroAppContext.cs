using MetroApp.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MetroApp.DataLayer.Context
{
    public class MetroAppContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }


        public MetroAppContext()
        {
            //LogService w = new LogService();
            try
            {
                string Conexion = WebConfigurationManager.AppSettings["ConnectionString"];
                Database.Connection.ConnectionString = Conexion;
                //w.Write(Conexion);
            }
            catch (Exception ex)
            {

                //w.Write(ex.Message);
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(18, 5));
        }
    }
}
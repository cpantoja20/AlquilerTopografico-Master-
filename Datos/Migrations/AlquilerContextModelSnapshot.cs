using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(AlquilerContext))]
    partial class ProductosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Alquiler", a =>
                {
                    a.Property<string>("IdEquipo")
                        .HasColumnType("nvarchar(10)");

                    a.Property<int>("IdCliente")
                        .HasColumnType("int");

                    a.Property<decimal>("valor")
                        .HasColumnType("valor");

                    a.HasKey("IdCliente");

                    a.ToTable("Alquilers");
                });
#pragma warning restore 612, 618
        }
    }
}

// git remote add origin https://github.com/cpantoja20/AlquilerTopografico-Master-.git
//git push -u origin master -->
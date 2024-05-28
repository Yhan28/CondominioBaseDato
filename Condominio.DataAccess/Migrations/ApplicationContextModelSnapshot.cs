﻿// <auto-generated />
using System;
using Condominio.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Condominio.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.27");

            modelBuilder.Entity("Condominio.DataAccess.Relacion_Viviendas_Comodidades.RentayComodidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Comodidad_ID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vivienda_Renta_ID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("RentayComodidad", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Comodidades.Comodidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Valor")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Comodidad", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Personas.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CI")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vivienda_ID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Viviendas.Vivienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Numeracion")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vivienda", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Inquilinos.Inquilino", b =>
                {
                    b.HasBaseType("Condominio.Domain.Entities.Personas.Persona");

                    b.Property<int>("Duracion_Contrat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fecha_Contrat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Inquilinos", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Propietarios.Propietario", b =>
                {
                    b.HasBaseType("Condominio.Domain.Entities.Personas.Persona");

                    b.ToTable("Propietarios", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Viviendas.Vivienda_Renta", b =>
                {
                    b.HasBaseType("Condominio.Domain.Entities.Viviendas.Vivienda");

                    b.Property<int?>("ComodidadId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Precio")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ComodidadId");

                    b.ToTable("Vivienda_Rentas", (string)null);
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Inquilinos.Inquilino", b =>
                {
                    b.HasOne("Condominio.Domain.Entities.Personas.Persona", null)
                        .WithOne()
                        .HasForeignKey("Condominio.Domain.Entities.Inquilinos.Inquilino", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Propietarios.Propietario", b =>
                {
                    b.HasOne("Condominio.Domain.Entities.Personas.Persona", null)
                        .WithOne()
                        .HasForeignKey("Condominio.Domain.Entities.Propietarios.Propietario", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Viviendas.Vivienda_Renta", b =>
                {
                    b.HasOne("Condominio.Domain.Entities.Comodidades.Comodidad", null)
                        .WithMany("Vivienda_Renta_List")
                        .HasForeignKey("ComodidadId");

                    b.HasOne("Condominio.Domain.Entities.Viviendas.Vivienda", null)
                        .WithOne()
                        .HasForeignKey("Condominio.Domain.Entities.Viviendas.Vivienda_Renta", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Condominio.Domain.Entities.Comodidades.Comodidad", b =>
                {
                    b.Navigation("Vivienda_Renta_List");
                });
#pragma warning restore 612, 618
        }
    }
}
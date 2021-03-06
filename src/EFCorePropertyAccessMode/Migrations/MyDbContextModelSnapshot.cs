﻿// <auto-generated />
using System;
using EFCorePropertyAccessMode;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCorePropertyAccessMode.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCorePropertyAccessMode.Model.MyEntity", b =>
                {
                    b.Property<Guid>("KeyField1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KeyField2")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("KeyField1", "KeyField2");

                    b.ToTable("MyEntities");
                });

            modelBuilder.Entity("EFCorePropertyAccessMode.Model.MyEntity", b =>
                {
                    b.OwnsOne("EFCorePropertyAccessMode.Model.MyOwnedEntityType", "MyOwnedEntity", b1 =>
                        {
                            b1.Property<Guid>("MyEntityKeyField1")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("MyEntityKeyField2")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<decimal>("MyOwnedEntityOwnedEntityTypeField1")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<string>("MyOwnedEntityOwnedEntityTypeField2")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("MyEntityKeyField1", "MyEntityKeyField2");

                            b1.ToTable("MyEntities");

                            b1.WithOwner()
                                .HasForeignKey("MyEntityKeyField1", "MyEntityKeyField2");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

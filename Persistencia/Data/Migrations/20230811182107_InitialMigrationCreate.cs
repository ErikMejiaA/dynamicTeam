using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Arl",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arl", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresas_taller",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nit_empresa = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Representante = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas_taller", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eps",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_eps = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eps", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Servicios_especializados",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_servicio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios_especializados", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_categorias",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_categoria = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_categorias", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_empleados",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_empleados", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_especialidades",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_especialidades", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_sangre",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_sangre", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipos_telefonosMoviles",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_tipoTelMov = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_telefonosMoviles", x => x.IdCodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_pais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Regiones_Paises_Id_pais",
                        column: x => x.Id_pais,
                        principalTable: "Paises",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdCodigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre_producto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_tipoCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Productos_Tipos_categorias_Id_tipoCategoria",
                        column: x => x.Id_tipoCategoria,
                        principalTable: "Tipos_categorias",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_region = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Ciudades_Regiones_Id_region",
                        column: x => x.Id_region,
                        principalTable: "Regiones",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nit_sucursal = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Encargado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_empresa = table.Column<int>(type: "int", nullable: false),
                    Id_ciudad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Sucursales_Ciudades_Id_ciudad",
                        column: x => x.Id_ciudad,
                        principalTable: "Ciudades",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sucursales_Empresas_taller_Id_empresa",
                        column: x => x.Id_empresa,
                        principalTable: "Empresas_taller",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCodigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edad = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_sucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Clientes_Sucursales_Id_sucursal",
                        column: x => x.Id_sucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdCodigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Area_trabajo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edad = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_tipo_sangre = table.Column<int>(type: "int", nullable: false),
                    Id_sucursal = table.Column<int>(type: "int", nullable: false),
                    Id_tipo_especialidad = table.Column<int>(type: "int", nullable: false),
                    Id_eps = table.Column<int>(type: "int", nullable: false),
                    Id_arl = table.Column<int>(type: "int", nullable: false),
                    Id_tipo_empleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Empleados_Arl_Id_arl",
                        column: x => x.Id_arl,
                        principalTable: "Arl",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Eps_Id_eps",
                        column: x => x.Id_eps,
                        principalTable: "Eps",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Sucursales_Id_sucursal",
                        column: x => x.Id_sucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Tipos_empleados_Id_tipo_empleado",
                        column: x => x.Id_tipo_empleado,
                        principalTable: "Tipos_empleados",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Tipos_especialidades_Id_tipo_especialidad",
                        column: x => x.Id_tipo_especialidad,
                        principalTable: "Tipos_especialidades",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleados_Tipos_sangre_Id_tipo_sangre",
                        column: x => x.Id_tipo_sangre,
                        principalTable: "Tipos_sangre",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos_sucursales",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioCompraVU = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PrecioVentaVU = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Estado_producto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_producto = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_sucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos_sucursales", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Productos_sucursales_Productos_Id_producto",
                        column: x => x.Id_producto,
                        principalTable: "Productos",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_sucursales_Sucursales_Id_sucursal",
                        column: x => x.Id_sucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    IdCodigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nit_proveedor = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email_contacto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Forma_pago = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_sucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Proveedores_Sucursales_Id_sucursal",
                        column: x => x.Id_sucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdCodigo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Placa = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Referencia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Motor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Km = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_cliente = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Clientes_Id_cliente",
                        column: x => x.Id_cliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos_proveedores",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_producto = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_proveedor = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos_proveedores", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Productos_proveedores_Productos_Id_producto",
                        column: x => x.Id_producto,
                        principalTable: "Productos",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_proveedores_Proveedores_Id_proveedor",
                        column: x => x.Id_proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TelefonosMoviles",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero_telefonoMovil = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_empleado = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_proveedor = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_cliente = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_tipoTelefonoMovil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonosMoviles", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_TelefonosMoviles_Clientes_Id_cliente",
                        column: x => x.Id_cliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelefonosMoviles_Empleados_Id_empleado",
                        column: x => x.Id_empleado,
                        principalTable: "Empleados",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelefonosMoviles_Proveedores_Id_proveedor",
                        column: x => x.Id_proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TelefonosMoviles_Tipos_telefonosMoviles_Id_tipoTelefonoMovil",
                        column: x => x.Id_tipoTelefonoMovil,
                        principalTable: "Tipos_telefonosMoviles",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingresos_taller",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha_ingreso = table.Column<DateTime>(type: "dateTime", nullable: false),
                    Id_vehiculo = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_servicioEspecializado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresos_taller", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Ingresos_taller_Servicios_especializados_Id_servicioEspecial~",
                        column: x => x.Id_servicioEspecializado,
                        principalTable: "Servicios_especializados",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingresos_taller_Vehiculos_Id_vehiculo",
                        column: x => x.Id_vehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inspecciones_vehiculos",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Puerta_F_izquierda = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Puerta_F_derecha = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Puerta_T_izquierda = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Puerta_T_derecha = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Radio_marca = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Radio_estado = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Techo = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Muebles = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tapetes = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Farola_F_izquierda = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Farola_F_derecha = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Farola_T_izquierda = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Farola_T_derecha = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rueda_F_izquierda = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rueda_F_derecha = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rueda_T_izquierda = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rueda_T_derecha = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Otros = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Diagnostico_cliente = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_ingresoTaller = table.Column<int>(type: "int", nullable: false),
                    Id_empleado = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspecciones_vehiculos", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Inspecciones_vehiculos_Empleados_Id_empleado",
                        column: x => x.Id_empleado,
                        principalTable: "Empleados",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspecciones_vehiculos_Ingresos_taller_Id_ingresoTaller",
                        column: x => x.Id_ingresoTaller,
                        principalTable: "Ingresos_taller",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orden_reparaciones",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha_salidaEstimada = table.Column<DateTime>(type: "dateTime", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_ingresoTaller = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden_reparaciones", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Orden_reparaciones_Ingresos_taller_Id_ingresoTaller",
                        column: x => x.Id_ingresoTaller,
                        principalTable: "Ingresos_taller",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personal_responsables",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tiempo_reparacion = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Diagnostico_taller = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_empleado = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_ingresoTaller = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal_responsables", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Personal_responsables_Empleados_Id_empleado",
                        column: x => x.Id_empleado,
                        principalTable: "Empleados",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personal_responsables_Ingresos_taller_Id_ingresoTaller",
                        column: x => x.Id_ingresoTaller,
                        principalTable: "Ingresos_taller",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado_reparaciones",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_ordenReparacion = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado_reparaciones", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Estado_reparaciones_Orden_reparaciones_Id_ordenReparacion",
                        column: x => x.Id_ordenReparacion,
                        principalTable: "Orden_reparaciones",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Forma_pago = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fecha_salida = table.Column<DateTime>(type: "dateTime", nullable: false),
                    Valor_total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Valor_totalRepuesto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Valor_manoObra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Valor_totalReparacion = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Id_ordenReparacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Facturas_Orden_reparaciones_Id_ordenReparacion",
                        column: x => x.Id_ordenReparacion,
                        principalTable: "Orden_reparaciones",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hallazgos_encontrados",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_hallazgo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_personalResponsable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hallazgos_encontrados", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Hallazgos_encontrados_Personal_responsables_Id_personalRespo~",
                        column: x => x.Id_personalResponsable,
                        principalTable: "Personal_responsables",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Repuestos_cambiar",
                columns: table => new
                {
                    IdCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Valor_unitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Id_personalResponsable = table.Column<int>(type: "int", nullable: false),
                    Id_productoSucursal = table.Column<int>(type: "int", nullable: false),
                    Id_ordenReparacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos_cambiar", x => x.IdCodigo);
                    table.ForeignKey(
                        name: "FK_Repuestos_cambiar_Orden_reparaciones_Id_ordenReparacion",
                        column: x => x.Id_ordenReparacion,
                        principalTable: "Orden_reparaciones",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repuestos_cambiar_Personal_responsables_Id_personalResponsab~",
                        column: x => x.Id_personalResponsable,
                        principalTable: "Personal_responsables",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repuestos_cambiar_Productos_sucursales_Id_productoSucursal",
                        column: x => x.Id_productoSucursal,
                        principalTable: "Productos_sucursales",
                        principalColumn: "IdCodigo",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Arl_Email",
                table: "Arl",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_Id_region",
                table: "Ciudades",
                column: "Id_region");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_Nombre",
                table: "Ciudades",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Documento",
                table: "Clientes",
                column: "Documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Email",
                table: "Clientes",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Id_sucursal",
                table: "Clientes",
                column: "Id_sucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdCodigo",
                table: "Clientes",
                column: "IdCodigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Documento",
                table: "Empleados",
                column: "Documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Email",
                table: "Empleados",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Id_arl",
                table: "Empleados",
                column: "Id_arl");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Id_eps",
                table: "Empleados",
                column: "Id_eps");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Id_sucursal",
                table: "Empleados",
                column: "Id_sucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Id_tipo_empleado",
                table: "Empleados",
                column: "Id_tipo_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Id_tipo_especialidad",
                table: "Empleados",
                column: "Id_tipo_especialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Id_tipo_sangre",
                table: "Empleados",
                column: "Id_tipo_sangre");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_IdCodigo",
                table: "Empleados",
                column: "IdCodigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_taller_Email",
                table: "Empresas_taller",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_taller_Nit_empresa",
                table: "Empresas_taller",
                column: "Nit_empresa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Eps_Email",
                table: "Eps",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_reparaciones_Id_ordenReparacion",
                table: "Estado_reparaciones",
                column: "Id_ordenReparacion");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Id_ordenReparacion",
                table: "Facturas",
                column: "Id_ordenReparacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hallazgos_encontrados_Id_personalResponsable",
                table: "Hallazgos_encontrados",
                column: "Id_personalResponsable");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_taller_Id_servicioEspecializado",
                table: "Ingresos_taller",
                column: "Id_servicioEspecializado");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_taller_Id_vehiculo",
                table: "Ingresos_taller",
                column: "Id_vehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Inspecciones_vehiculos_Id_empleado",
                table: "Inspecciones_vehiculos",
                column: "Id_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Inspecciones_vehiculos_Id_ingresoTaller",
                table: "Inspecciones_vehiculos",
                column: "Id_ingresoTaller");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_reparaciones_Id_ingresoTaller",
                table: "Orden_reparaciones",
                column: "Id_ingresoTaller",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paises_Nombre",
                table: "Paises",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_responsables_Id_empleado",
                table: "Personal_responsables",
                column: "Id_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_responsables_Id_ingresoTaller",
                table: "Personal_responsables",
                column: "Id_ingresoTaller");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Id_tipoCategoria",
                table: "Productos",
                column: "Id_tipoCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCodigo",
                table: "Productos",
                column: "IdCodigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_proveedores_Id_producto",
                table: "Productos_proveedores",
                column: "Id_producto");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_proveedores_Id_proveedor",
                table: "Productos_proveedores",
                column: "Id_proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_sucursales_Id_producto",
                table: "Productos_sucursales",
                column: "Id_producto");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_sucursales_Id_sucursal",
                table: "Productos_sucursales",
                column: "Id_sucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Email_contacto",
                table: "Proveedores",
                column: "Email_contacto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Id_sucursal",
                table: "Proveedores",
                column: "Id_sucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_IdCodigo",
                table: "Proveedores",
                column: "IdCodigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_Id_pais",
                table: "Regiones",
                column: "Id_pais");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_Nombre",
                table: "Regiones",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_cambiar_Id_ordenReparacion",
                table: "Repuestos_cambiar",
                column: "Id_ordenReparacion");

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_cambiar_Id_personalResponsable",
                table: "Repuestos_cambiar",
                column: "Id_personalResponsable");

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_cambiar_Id_productoSucursal",
                table: "Repuestos_cambiar",
                column: "Id_productoSucursal",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_Email",
                table: "Sucursales",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_Id_ciudad",
                table: "Sucursales",
                column: "Id_ciudad");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_Id_empresa",
                table: "Sucursales",
                column: "Id_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_Nit_sucursal",
                table: "Sucursales",
                column: "Nit_sucursal",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefonosMoviles_Id_cliente",
                table: "TelefonosMoviles",
                column: "Id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonosMoviles_Id_empleado",
                table: "TelefonosMoviles",
                column: "Id_empleado");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonosMoviles_Id_proveedor",
                table: "TelefonosMoviles",
                column: "Id_proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonosMoviles_Id_tipoTelefonoMovil",
                table: "TelefonosMoviles",
                column: "Id_tipoTelefonoMovil");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Id_cliente",
                table: "Vehiculos",
                column: "Id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdCodigo",
                table: "Vehiculos",
                column: "IdCodigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Placa",
                table: "Vehiculos",
                column: "Placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Referencia",
                table: "Vehiculos",
                column: "Referencia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Vin",
                table: "Vehiculos",
                column: "Vin",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estado_reparaciones");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Hallazgos_encontrados");

            migrationBuilder.DropTable(
                name: "Inspecciones_vehiculos");

            migrationBuilder.DropTable(
                name: "Productos_proveedores");

            migrationBuilder.DropTable(
                name: "Repuestos_cambiar");

            migrationBuilder.DropTable(
                name: "TelefonosMoviles");

            migrationBuilder.DropTable(
                name: "Orden_reparaciones");

            migrationBuilder.DropTable(
                name: "Personal_responsables");

            migrationBuilder.DropTable(
                name: "Productos_sucursales");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Tipos_telefonosMoviles");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Ingresos_taller");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Arl");

            migrationBuilder.DropTable(
                name: "Eps");

            migrationBuilder.DropTable(
                name: "Tipos_empleados");

            migrationBuilder.DropTable(
                name: "Tipos_especialidades");

            migrationBuilder.DropTable(
                name: "Tipos_sangre");

            migrationBuilder.DropTable(
                name: "Servicios_especializados");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Tipos_categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Empresas_taller");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}

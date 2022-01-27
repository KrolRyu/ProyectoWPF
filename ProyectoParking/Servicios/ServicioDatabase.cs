using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoParking.Servicios
{
    static class ServicioDatabase
    {
        public static void ConnectDatabase()
        {
            /*Instalar el paquete NuGet Microsoft.Data.Sqlite

            //Crea una conexión al fichero de base de datos parking.db
            //Si no existe, lo creará
            SqliteConnection conexion = new SqliteConnection("Data Source=C:/ProyectoParking/database/parking.db");

            //Abre la conexión con la base de datos
            conexion.Open();

            //Creamos una tabla utilizando un comando
            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = @"CREATE TABLE IF NOT EXISTS clientes (
                                        id_cliente INTEGER PRIMARY KEY AUTOINCREMENT,
                                        nombre     TEXT,
                                        documento  TEXT    NOT NULL,
                                        foto       TEXT,
                                        edad       INTEGER,
                                        genero     TEXT,
                                        telefono   TEXT)";
            comando.ExecuteNonQuery(); //Este método ejecuta consultas que no son SELECT

            //Inserción de datos con parámetros
            comando.CommandText = "insert into Clientes (id_cliente, nombre, documento, foto, edad, genero, telefono) values (1, 'Harriott', '106-92-6159', 'hcartin13@networkadvertising.org', 'Progressive tangible interface', 'Female', '2452140252');" +
                                  "insert into Clientes (id_cliente, nombre, documento, foto, edad, genero, telefono) values (2, 'Jocko', '271-78-8979', 'jlumm12@vimeo.com', 'Horizontal grid-enabled hierarchy', 'Male', '4863414850');" +
                                  "insert into Clientes (id_cliente, nombre, documento, foto, edad, genero, telefono) values (3, 'Ofilia', '642-61-2726', 'ocords11@so-net.ne.jp', 'Universal human-resource adapter', 'Genderqueer', '8296305047');" +
                                  "insert into Clientes (id_cliente, nombre, documento, foto, edad, genero, telefono) values (4, 'Rubie', '446-86-1623', 'rplevey10@bloomberg.com', 'Cloned full-range Graphic Interface', 'Genderfluid', '2009434005');" +
                                  "insert into Clientes (id_cliente, nombre, documento, foto, edad, genero, telefono) values (5, 'Pollyanna', '722-55-9858', 'pshippeyz@fotki.com', 'Profound motivating knowledge user', 'Female', '9252836688');";
            comando.ExecuteNonQuery();

            comando.CommandText = @"CREATE TABLE IF NOT EXISTS vehiculos (
                                        id_vehiculo INTEGER PRIMARY KEY AUTOINCREMENT,
                                        id_cliente  INTEGER NOT NULL
                                        REFERENCES clientes (id_cliente),
                                        matricula   TEXT    NOT NULL,
                                        id_marca    INTEGER REFERENCES marcas (id_marca),
                                        modelo      TEXT,
                                        tipo        TEXT    NOT NULL)";
            comando.ExecuteNonQuery();

            comando.CommandText = "insert into vehiculos (id_vehiculo, id_cliente, matricula, id_marca, modelo, tipo) values (1, 1, 'WBAPK5G59BN204645', 1, 'Avalon', 'Female');" +
                                  "insert into vehiculos (id_vehiculo, id_cliente, matricula, id_marca, modelo, tipo) values (2, 2, 'WAUDF78E88A934340', 2, 'Eclipse', 'Female');" +
                                  "insert into vehiculos (id_vehiculo, id_cliente, matricula, id_marca, modelo, tipo) values (3, 2, 'WAUCFAFH3BN051266', 3, 'Continental GT', 'Female');" +
                                  "insert into vehiculos (id_vehiculo, id_cliente, matricula, id_marca, modelo, tipo) values (4, 3, 'WBA3N3C54FF518798', 4, 'Sierra 3500', 'Male');" +
                                  "insert into vehiculos (id_vehiculo, id_cliente, matricula, id_marca, modelo, tipo) values (5, 5, '1FAHP2DW5BG954722', 5, 'Camry Solara', 'Female');";
            //Cerramos la conexión
            conexion.Close();*/
        }
    }
}

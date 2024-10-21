using CENTRO_SALUD_PATZICIA.Modelos;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Data;
using System.Data.SqlClient;
using System.Security.Claims;
namespace CENTRO_SALUD_PATZICIA.Data
{
    public class ConsultasSql
    {
        public static string cadenaConexion { get; set; } = "Data Source=localhost;Initial Catalog=JOSIAS;User ID=sa;Password=123;Encrypt=False";

        public ConsultasSql()
        {
            cadenaConexion = "Data Source=localhost;Initial Catalog=Pruebas;User ID=sa;Password=12345;Encrypt=False";
        }
        //public static string cui { get; set; } = null!;
        public static List<ModeloSexo> obtenerSexo()
        {
            List<ModeloSexo> resultadoConsulta = new List<ModeloSexo>();

            string consulta = @"Select Id_sexo, Descripcion from sexo";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloSexo sexo = new ModeloSexo()
                                {
                                    idSexo = Convert.ToInt32(reader["Id_sexo"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(sexo);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloPueblo> obtenerPueblo()
        {
            List<ModeloPueblo> resultadoConsulta = new List<ModeloPueblo>();

            string consulta = @"Select Id_pueblo, Descripcion from pueblo";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloPueblo pueblo = new ModeloPueblo()
                                {
                                    idPueblo = Convert.ToInt32(reader["Id_pueblo"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(pueblo);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloDiscapacidad> obtenerDiscapacidad()
        {
            List<ModeloDiscapacidad> resultadoConsulta = new List<ModeloDiscapacidad>();

            string consulta = @"Select Id_discapacidad, Descripcion from discapacidad";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloDiscapacidad discapacidad = new ModeloDiscapacidad()
                                {
                                    idDiscapacidad = Convert.ToInt32(reader["Id_discapacidad"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(discapacidad);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloOrientacionSexual> ObtenerOrientacionSexual()
        {
            List<ModeloOrientacionSexual> resultadoConsulta = new List<ModeloOrientacionSexual>();

            string consulta = @"Select Id_orientacion_sexual, Descripcion from orientacion_sexual";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloOrientacionSexual orientacionSexual = new ModeloOrientacionSexual()
                                {
                                    idOrientacionSexual = Convert.ToInt32(reader["Id_orientacion_sexual"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(orientacionSexual);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloEscolaridad> obtenerEscolaridad()
        {
            List<ModeloEscolaridad> resultadoConsulta = new List<ModeloEscolaridad>();

            string consulta = @"Select Id_escolaridad, Descripcion from escolaridad";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloEscolaridad escolaridad = new ModeloEscolaridad()
                                {
                                    idEscolaridad = Convert.ToInt32(reader["Id_escolaridad"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(escolaridad);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloAgricolaMigrante> obtenerAgricolaMigrante()
        {
            List<ModeloAgricolaMigrante> resultadoConsulta = new List<ModeloAgricolaMigrante>();

            string consulta = @"Select Id_agricola_migrante, Descripcion from agricola_migrante";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloAgricolaMigrante agricolaMigrante = new ModeloAgricolaMigrante()
                                {
                                    idAgricolaMigrante = Convert.ToInt32(reader["Id_agricola_migrante"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(agricolaMigrante);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloConsulta> obtenerConsulta()
        {
            List<ModeloConsulta> resultadoConsulta = new List<ModeloConsulta>();

            string consulta = @"Select Id_consulta, Descripcion from consulta";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloConsulta consultaD = new ModeloConsulta()
                                {
                                    idConsulta = Convert.ToInt32(reader["Id_consulta"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(consultaD);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloControlEstablecido> obteberControl()
        {
            List<ModeloControlEstablecido> resultadoConsulta = new List<ModeloControlEstablecido>();

            string consulta = @"Select Id_control_establecido, Descripcion from control_establecido";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloControlEstablecido control = new ModeloControlEstablecido()
                                {
                                    idControlEstablecido = Convert.ToInt32(reader["Id_control_establecido"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(control);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloViene> obtenerViene()
        {
            List<ModeloViene> resultadoConsulta = new List<ModeloViene>();

            string consulta = @"Select Id_sexo, Descripcion from viene";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloViene viene = new ModeloViene()
                                {
                                    idViene = Convert.ToInt32(reader["Id_sexo"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(viene);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloFue> obtenerFue()
        {
            List<ModeloFue> resultadoConsulta = new List<ModeloFue>();

            string consulta = @"Select Id_sexo, Descripcion from fue";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloFue fue = new ModeloFue()
                                {
                                    idFue = Convert.ToInt32(reader["Id_sexo"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(fue);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloProfesion> obtenerProfesion()
        {
            List<ModeloProfesion> resultadoConsulta = new List<ModeloProfesion>();

            string consulta = @"Select Id_profesion, Descripcion from profesion";


            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloProfesion profesion = new ModeloProfesion()
                                {
                                    idProfesion = Convert.ToInt32(reader["Id_profesion"]),
                                    descripcion = reader["Descripcion"].ToString()
                                };
                                resultadoConsulta.Add(profesion);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static void InsertConsultaPaciente(ModeloFormulario formulario)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand("InsertarRegistro", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros si es necesario
                    command.Parameters.AddWithValue("@NombresyApellidos", formulario.nombres_y_apellidos);
                    command.Parameters.AddWithValue("@Cui", formulario.cui);
                    command.Parameters.AddWithValue("@Sexo", formulario.sexo);
                    command.Parameters.AddWithValue("@Pueblo", formulario.pueblo);
                    command.Parameters.AddWithValue("@ComunidadLinguistico", formulario.comunidad_linguistica);
                    command.Parameters.AddWithValue("@FechaNacimiento", formulario.fecha_nacimiento);
                    command.Parameters.AddWithValue("@Discapacidad", formulario.discapacidad);
                    command.Parameters.AddWithValue("@OrientacionSexual", formulario.orientacion_sexual);
                    command.Parameters.AddWithValue("@Escolaridad", formulario.escolaridad);
                    command.Parameters.AddWithValue("@Profesion", formulario.profesion_u_oficio);
                    command.Parameters.AddWithValue("@Presion_Arterial", formulario.presion_arterial);
                    command.Parameters.AddWithValue("@Frecuencia_Cardiaca", formulario.frecuencia_cardiaca);
                    command.Parameters.AddWithValue("@Frecuencia_Respiratoria", formulario.frecuencua_respiratoria);
                    command.Parameters.AddWithValue("@Temperatura", formulario.temperatura);
                    command.Parameters.AddWithValue("@Saturacion_Oxigeno", formulario.saturacion_oxigeno);
                    command.Parameters.AddWithValue("@Peso", formulario.peso);
                    command.Parameters.AddWithValue("@Altura", formulario.altura);
                    command.Parameters.AddWithValue("@Comunidad_o_Direccion", formulario.comunidad_linguistica);
                    command.Parameters.AddWithValue("@Municipio", formulario.municipio);
                    command.Parameters.AddWithValue("@Agricola_Migrante", formulario.agricola_migrante);
                    command.Parameters.AddWithValue("@Consulta", formulario.consulta);
                    command.Parameters.AddWithValue("@Control", formulario.control);
                    command.Parameters.AddWithValue("@Semana_gestacion", formulario.semana_gestacion);
                    command.Parameters.AddWithValue("@Viene", formulario.viene);
                    command.Parameters.AddWithValue("@Fue", formulario.fue);
                    command.Parameters.AddWithValue("@Referido", formulario.referido);
                    command.Parameters.AddWithValue("@Descripcion_Diagnostico_Control", formulario.diadnostico);
                    command.Parameters.AddWithValue("@Codigo_CIE", formulario.codigo_cie);
                    command.Parameters.AddWithValue("@Descripcion", formulario.tratamiento_descripcion);
                    command.Parameters.AddWithValue("@Presentacion", formulario.tratamiento_presentacion);
                    command.Parameters.AddWithValue("@Cantidad_Recetada", formulario.cantidad_recetada);
                    command.Parameters.AddWithValue("@Lugar_Notificacion", formulario.lugar_notificacion);
                    command.Parameters.AddWithValue("@Numero_Notificacion", formulario.numero_notificacion);
                    command.Parameters.AddWithValue("@Nombre_Apellidos_Acompañante", formulario.nombres_y_apellidos_acompañante);
                    connection.Open();
                    try
                    {
                        int guardar = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {

                    }// Usar ExecuteReader, ExecuteScalar o ExecuteNonQuery según el caso
                }
            }

        }
        public static void UpdateConsultaPaciente(ModeloFormulario formulario)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand("ActualizarRegistro", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros si es necesario
                    command.Parameters.AddWithValue("@NombresyApellidos", formulario.nombres_y_apellidos);
                    command.Parameters.AddWithValue("@Cui", formulario.cui);
                    command.Parameters.AddWithValue("@Sexo", formulario.sexo);
                    command.Parameters.AddWithValue("@Pueblo", formulario.pueblo);
                    command.Parameters.AddWithValue("@ComunidadLinguistico", formulario.comunidad_linguistica);
                    command.Parameters.AddWithValue("@FechaNacimiento", formulario.fecha_nacimiento);
                    command.Parameters.AddWithValue("@Discapacidad", formulario.discapacidad);
                    command.Parameters.AddWithValue("@OrientacionSexual", formulario.orientacion_sexual);
                    command.Parameters.AddWithValue("@Escolaridad", formulario.escolaridad);
                    command.Parameters.AddWithValue("@Profesion", formulario.profesion_u_oficio);
                    command.Parameters.AddWithValue("@Presion_Arterial", formulario.presion_arterial);
                    command.Parameters.AddWithValue("@Frecuencia_Cardiaca", formulario.frecuencia_cardiaca);
                    command.Parameters.AddWithValue("@Frecuencia_Respiratoria", formulario.frecuencua_respiratoria);
                    command.Parameters.AddWithValue("@Temperatura", formulario.temperatura);
                    command.Parameters.AddWithValue("@Saturacion_Oxigeno", formulario.saturacion_oxigeno);
                    command.Parameters.AddWithValue("@Peso", formulario.peso);
                    command.Parameters.AddWithValue("@Altura", formulario.altura);
                    command.Parameters.AddWithValue("@Comunidad_o_Direccion", formulario.comunidad_linguistica);
                    command.Parameters.AddWithValue("@Municipio", formulario.municipio);
                    command.Parameters.AddWithValue("@Agricola_Migrante", formulario.agricola_migrante);
                    command.Parameters.AddWithValue("@Consulta", formulario.consulta);
                    command.Parameters.AddWithValue("@Control", formulario.control);
                    command.Parameters.AddWithValue("@Semana_gestacion", formulario.semana_gestacion);
                    command.Parameters.AddWithValue("@Viene", formulario.viene);
                    command.Parameters.AddWithValue("@Fue", formulario.fue);
                    command.Parameters.AddWithValue("@Referido", formulario.referido);
                    command.Parameters.AddWithValue("@Descripcion_Diagnostico_Control", formulario.diadnostico);
                    command.Parameters.AddWithValue("@Codigo_CIE", formulario.codigo_cie);
                    command.Parameters.AddWithValue("@Descripcion", formulario.tratamiento_descripcion);
                    command.Parameters.AddWithValue("@Presentacion", formulario.tratamiento_presentacion);
                    command.Parameters.AddWithValue("@Cantidad_Recetada", formulario.cantidad_recetada);
                    command.Parameters.AddWithValue("@Lugar_Notificacion", formulario.lugar_notificacion);
                    command.Parameters.AddWithValue("@Numero_Notificacion", formulario.numero_notificacion);
                    command.Parameters.AddWithValue("@Nombre_Apellidos_Acompañante", formulario.nombres_y_apellidos_acompañante);
                    connection.Open();
                    try
                    {
                        int guardar = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {

                    }// Usar ExecuteReader, ExecuteScalar o ExecuteNonQuery según el caso
                }
            }

        }
        public static List<ModeloObtenerRegistro> obtenerRegistrosDiario()
        {
            List<ModeloObtenerRegistro> resultadoConsulta = new List<ModeloObtenerRegistro>();

            string consulta = @"select
									fecha_creacion_registro
									,ID_Consulta
									,NombresyApellidos
									,idSexo
									,Sexo
									,idPueblo
									,Pueblo
									,Comunidad_Linguistica
									,Fecha_Nacimiento
									,idDiscapacidad
									,discapacidad
									,idOrientacionSexual
									,orientacionsexual
									,idEscolaridad
									,escolaridad
									,idProfesion
									,profesion
									,Cui
									,Presion_Arterial
									,Frecuencia_Cardiaca
									,Temperatura
									,Saturacion_Oxigeno
									,Peso
									,Altura
									,Comunidad_o_Direccion
									,Municipio
									,idAgricolaMigrante
									,agricolaMigrante
									,idConsulta
									,consulta
									,idControl
									,control_establecido
									,semana_gestacion
									,descripcionViene
									,descripcionFue
									,Referido
									,Codigo_CIE
									,Descripcion_Diagnostico_Control
									,tratamiento
									,Presentacion
									,Cantidad_Recetada
									,Lugar_Notificacion
									,Numero_Notificacion
									,Nombre_Apellidos_Acompañante
									FROM CONSULTA_DIARIO_VW";

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloObtenerRegistro registro = new ModeloObtenerRegistro()
                                {
                                    fechaCreacionConsulta = DateTime.Parse(reader["fecha_creacion_registro"].ToString()),
                                    IdConsulta = Convert.ToInt32(reader["ID_Consulta"]),
                                    nombresYapellidos = reader["NombresyApellidos"].ToString(),
                                    idSexo = Convert.ToInt32(reader["idSexo"]),
                                    sexo = reader["Sexo"].ToString(),
                                    idPueblo = Convert.ToInt32(reader["idPueblo"]),
                                    pueblo = reader["Pueblo"].ToString(),
                                    comunidadLinguistica = reader["Comunidad_Linguistica"].ToString(),
                                    fechaNacimiento = DateTime.Parse(reader["Fecha_Nacimiento"].ToString()),
                                    idDiscapacidad = Convert.ToInt32(reader["idDiscapacidad"]),
                                    discapacidad = reader["discapacidad"].ToString(),
                                    idOrientacionSexual = Convert.ToInt32(reader["idOrientacionSexual"]),
                                    orientacionSexual = reader["orientacionsexual"].ToString(),
                                    idEscolaridad = Convert.ToInt32(reader["idEscolaridad"]),
                                    escolaridad = reader["escolaridad"].ToString(),
                                    idProfesion = Convert.ToInt32(reader["idProfesion"]),
                                    profesion = reader["profesion"].ToString(),
                                    cui = reader["Cui"].ToString(),
                                    presionArterial = reader["Presion_Arterial"].ToString(),
                                    frecuenciaCardica = Convert.ToInt32(reader["Frecuencia_Cardiaca"]),
                                    temperatura = Convert.ToDecimal(reader["Temperatura"]),
                                    saturacionOxigeno = Convert.ToInt32(reader["Saturacion_Oxigeno"]),
                                    peso = Convert.ToDecimal(reader["Peso"]),
                                    altura = Convert.ToInt32(reader["Altura"]),
                                    comunidadOdireccion = reader["Comunidad_o_Direccion"].ToString(),
                                    municipio = reader["Municipio"].ToString(),
                                    idAgricolaMigrante = Convert.ToInt32(reader["idAgricolaMigrante"]),
                                    agricolaMigrante = reader["agricolaMigrante"].ToString(),
                                    idConsulta = Convert.ToInt32(reader["idConsulta"]),
                                    consultaDescripcion = reader["consulta"].ToString(),
                                    idControl = Convert.ToInt32(reader["idControl"]),
                                    controlEstablecido = reader["control_establecido"].ToString(),
                                    semanaGestacion = Convert.ToInt32(reader["semana_gestacion"]),
                                    descripcionViene = reader["descripcionViene"].ToString(),
                                    descripcionFue = reader["descripcionFue"].ToString(),
                                    referido = reader["Referido"].ToString(),
                                    codigoCie = reader["Codigo_CIE"].ToString(),
                                    descripcionDiagnosticoControl = reader["Descripcion_Diagnostico_Control"].ToString(),
                                    tratamiento = reader["tratamiento"].ToString(),
                                    presentacion = reader["Presentacion"].ToString(),
                                    cantidadREcetada = reader["Cantidad_Recetada"].ToString(),
                                    lugarNotificacion = reader["Lugar_Notificacion"].ToString(),
                                    numeroNotificacion = reader["Numero_Notificacion"].ToString(),
                                    nombreYapellidosAcompañante = reader["Nombre_Apellidos_Acompañante"].ToString()
                                };
                                resultadoConsulta.Add(registro);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static List<ModeloObtenerRegistro> obtenerRegistrosDiario(string cui)
        {
            List<ModeloObtenerRegistro> resultadoConsulta = new List<ModeloObtenerRegistro>();

            string consulta = @"select
									fecha_creacion_registro
									,ID_Consulta
									,NombresyApellidos
									,idSexo
									,Sexo
									,idPueblo
									,Pueblo
									,Comunidad_Linguistica
									,Fecha_Nacimiento
									,idDiscapacidad
									,discapacidad
									,idOrientacionSexual
									,orientacionsexual
									,idEscolaridad
									,escolaridad
									,idProfesion
									,profesion
									,Cui
									,Presion_Arterial
									,Frecuencia_Cardiaca
									,Frecuencia_Respiratoria
									,Temperatura
									,Saturacion_Oxigeno
									,Peso
									,Altura
									,Comunidad_o_Direccion
									,Municipio
									,idAgricolaMigrante
									,agricolaMigrante
									,idConsulta
									,consulta
									,idControl
									,control_establecido
									,semana_gestacion
									,idViene
									,descripcionViene
									,idFue
									,descripcionFue
									,Referido
									,Codigo_CIE
									,Descripcion_Diagnostico_Control
									,tratamiento
									,Presentacion
									,Cantidad_Recetada
									,Lugar_Notificacion
									,Numero_Notificacion
									,Nombre_Apellidos_Acompañante
									FROM CONSULTA_DIARIO_VW
									WHERE fecha_creacion_registro IN(
										SELECT MAX (fecha_creacion_registro) FROM CONSULTA_DIARIO_VW
										WHERE Cui = @Cui
									)
									AND Cui = @Cui";

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@cui", cui);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModeloObtenerRegistro registro = new ModeloObtenerRegistro()
                                {
                                    fechaCreacionConsulta = DateTime.Parse(reader["fecha_creacion_registro"].ToString()),
                                    IdConsulta = Convert.ToInt32(reader["ID_Consulta"]),
                                    nombresYapellidos = reader["NombresyApellidos"].ToString(),
                                    idSexo = Convert.ToInt32(reader["idSexo"]),
                                    sexo = reader["Sexo"].ToString(),
                                    idPueblo = Convert.ToInt32(reader["idPueblo"]),
                                    pueblo = reader["Pueblo"].ToString(),
                                    comunidadLinguistica = reader["Comunidad_Linguistica"].ToString(),
                                    fechaNacimiento = DateTime.Parse(reader["Fecha_Nacimiento"].ToString()),
                                    idDiscapacidad = Convert.ToInt32(reader["idDiscapacidad"]),
                                    discapacidad = reader["discapacidad"].ToString(),
                                    idOrientacionSexual = Convert.ToInt32(reader["idOrientacionSexual"]),
                                    orientacionSexual = reader["orientacionsexual"].ToString(),
                                    idEscolaridad = Convert.ToInt32(reader["idEscolaridad"]),
                                    escolaridad = reader["escolaridad"].ToString(),
                                    idProfesion = Convert.ToInt32(reader["idProfesion"]),
                                    profesion = reader["profesion"].ToString(),
                                    cui = reader["Cui"].ToString(),
                                    presionArterial = reader["Presion_Arterial"].ToString(),
                                    frecuenciaCardica = Convert.ToInt32(reader["Frecuencia_Cardiaca"]),
                                    frecuenciaRespiratoria = Convert.ToInt32(reader["Frecuencia_Respiratoria"]),
                                    temperatura = Convert.ToDecimal(reader["Temperatura"]),
                                    saturacionOxigeno = Convert.ToInt32(reader["Saturacion_Oxigeno"]),
                                    peso = Convert.ToDecimal(reader["Peso"]),
                                    altura = Convert.ToInt32(reader["Altura"]),
                                    comunidadOdireccion = reader["Comunidad_o_Direccion"].ToString(),
                                    municipio = reader["Municipio"].ToString(),
                                    idAgricolaMigrante = Convert.ToInt32(reader["idAgricolaMigrante"]),
                                    agricolaMigrante = reader["agricolaMigrante"].ToString(),
                                    idConsulta = Convert.ToInt32(reader["idConsulta"]),
                                    consultaDescripcion = reader["consulta"].ToString(),
                                    idControl = Convert.ToInt32(reader["idControl"]),
                                    controlEstablecido = reader["control_establecido"].ToString(),
                                    semanaGestacion = Convert.ToInt32(reader["semana_gestacion"]),
                                    idViene = Convert.ToInt32(reader["idViene"]),
                                    descripcionViene = reader["descripcionViene"].ToString(),
                                    idFue = Convert.ToInt32(reader["idFue"]),
                                    descripcionFue = reader["descripcionFue"].ToString(),
                                    referido = reader["Referido"].ToString(),
                                    codigoCie = reader["Codigo_CIE"].ToString(),
                                    descripcionDiagnosticoControl = reader["Descripcion_Diagnostico_Control"].ToString(),
                                    tratamiento = reader["tratamiento"].ToString(),
                                    presentacion = reader["Presentacion"].ToString(),
                                    cantidadREcetada = reader["Cantidad_Recetada"].ToString(),
                                    lugarNotificacion = reader["Lugar_Notificacion"].ToString(),
                                    numeroNotificacion = reader["Numero_Notificacion"].ToString(),
                                    nombreYapellidosAcompañante = reader["Nombre_Apellidos_Acompañante"].ToString()
                                };
                                resultadoConsulta.Add(registro);
                            }
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception e)
            {

            }
            return resultadoConsulta;
        }
        public static void InsertEncabezado(ModeloEncabezado encabezado)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand("InsertarEncabezado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros si es necesario
                    command.Parameters.AddWithValue("@Area_Salud", encabezado.areaSalud);
                    command.Parameters.AddWithValue("@DistritoSalud", encabezado.distritoSalud);
                    command.Parameters.AddWithValue("@Municipio", encabezado.municipio);
                    command.Parameters.AddWithValue("@Servicio_Salud", encabezado.servicioSalud);
                    command.Parameters.AddWithValue("@ResponsableInformacion", encabezado.responsableInformacion);
                    command.Parameters.AddWithValue("@Cargo", encabezado.cargo);
                    command.Parameters.AddWithValue("@Firma", encabezado.firma);
                    connection.Open();
                    try
                    {
                        int guardar = command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {

                    }// Usar ExecuteReader, ExecuteScalar o ExecuteNonQuery según el    aso
                }
            }

        }

        public static string obtenerUsuario(string userName, string password)
        {
            string consulta = $"select Nombre_Usuario from Usuario where Nombre_Usuario='{userName}' and Contrasena='{password}'";

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {

                        connection.Open();

                        object result = command.ExecuteScalar();
                        connection.Close();
                        if (result != null)
                        {
                            return result.ToString()!;

                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                } 
            }
            catch 
            {

                return string.Empty;
            }
           
        }
    }
}

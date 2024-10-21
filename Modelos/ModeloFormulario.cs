using System.Data;
using System.Data.SqlTypes;

namespace CENTRO_SALUD_PATZICIA.Modelos
{
	public class ModeloFormulario
	{
		public DateTime dia_consulta { get; set; }
		public int numero_Consulta { get; set; }
		public string nombres_y_apellidos { get; set; } = null!;
		public string cui { get; set; } = null!;
		public int sexo { get; set; }
		public int pueblo { get; set; }
		public string comunidad_linguistica { get; set; } = null!;
		public int edad { get; set; }
		public DateTime fecha_nacimiento { get; set; }
		public int discapacidad { get; set; }
		public int orientacion_sexual { get; set; }
		public int escolaridad { get; set; }
		public int profesion_u_oficio { get; set; }
		public string presion_arterial { get; set; } = null!;
		public int frecuencia_cardiaca { get; set; }
		public int frecuencua_respiratoria { get; set; }
		public int temperatura { get; set; }
		public int saturacion_oxigeno { get; set; }
		public int peso { get; set; }
		public int altura { get; set; }
		public string comunidad_direccion { get; set; } = null!;
		public string municipio { get; set; } = null!;
		public int agricola_migrante { get; set; }
		public int consulta { get; set; }
		public int control { get; set; }
		public int semana_gestacion { get; set; }
		public int viene { get; set; }
		public int fue { get; set; }
		public string referido { get; set; } = null!;
		public string diadnostico { get; set; } = null!;
		public string codigo_cie { get; set; } = null!;
		public string tratamiento_descripcion { get; set; } = null!;
		public string tratamiento_presentacion { get; set; } = null!;
		public string cantidad_recetada { get; set; } = null!;
		public string lugar_notificacion { get; set; } = null!;
		public string numero_notificacion { get; set; } = null!;
		public string nombres_y_apellidos_acompañante { get; set; } = null!;

	}
}

namespace CENTRO_SALUD_PATZICIA.Modelos
{
	public class ModeloObtenerRegistro
	{
        public DateTime fechaCreacionConsulta { get; set; }
        public int IdConsulta { get; set; }
		public string nombresYapellidos { get; set; } = null!;
		public int idSexo { get; set; }
		public string sexo { get; set; } = null!;
		public int idPueblo { get; set; }
		public string pueblo { get; set; } = null!;
		public string comunidadLinguistica { get; set; } = null!;
		public DateTime fechaNacimiento { get; set; }
		public int edad { get; set; }
		public int idDiscapacidad { get; set; }
		public string discapacidad { get; set; } = null!;
		public int idOrientacionSexual { get; set; }
		public string orientacionSexual { get; set; } = null!;
		public int idEscolaridad { get; set; }
		public string escolaridad { get; set; } = null!;
		public int idProfesion { get; set; }
		public string profesion { get; set; } = null!;
		public string cui { get; set; } = null!;
		public string presionArterial { get; set; } = null!;
		public int frecuenciaCardica { get; set; }
		public decimal temperatura { get; set; }
		public int saturacionOxigeno {  get; set; }
		public int frecuenciaRespiratoria { get; set; }
		public decimal peso {  get; set; }
		public int altura {  get; set; }
		public string comunidadOdireccion {  get; set; } = null!;
		public string municipio { get; set;} = null!;
		public int idAgricolaMigrante {  get; set; }
		public string agricolaMigrante { get; set; } = null!;
		public int idConsulta { get; set; }
		public string consultaDescripcion { get; set;} = null!;
        public int idControl { get; set; }
        public string controlEstablecido { get; set; } = null!;
        public int semanaGestacion { get; set; }
		public int idViene { get; set; }
        public string descripcionViene {  get; set; } = null!;
		public int idFue { get; set; }
		public string descripcionFue { get; set; } = null!;
		public string referido {  get; set; } = null!;
		public string codigoCie { get; set;} = null!;
		public string descripcionDiagnosticoControl {  get; set; } = null!;
		public string tratamiento { get; set; } = null!;
		public string presentacion { get; set; } = null!;
		public string cantidadREcetada { get; set; } = null!;
		public string lugarNotificacion { get; set; } = null!;
		public string numeroNotificacion { get; set; } = null!;
		public string nombreYapellidosAcompañante { get; set; } = null!;
	}
}
namespace CENTRO_SALUD_PATZICIA.Modelos
{
	public class ModeloObtenerEncabezado
	{
		public string Area_Salud { get; set; } = null!;
		public string DistritoSalud { get; set; } = null!;
		public string Municipio { get; set; } = null!;
		public string Servicio_Salud { get; set; } = null!;
		public string ResponsableInformacion { get; set; } = null!;
		public string Cargo { get; set; } = null!;
		public string Mes { get; set; } = null!;	
		public int Anio { get; set; }
		public string Firma { get; set; } = null!;
	}
}

using CENTRO_SALUD_PATZICIA.Data;

namespace CENTRO_SALUD_PATZICIA.Authentication
{
	public class UserAccountService
	{
		
		public UserAccount? GetByUserName(string userName,string password)
		{
			string resultadoDb= ConsultasSql.obtenerUsuario(userName, password);
			UserAccount usuario = new();
			if(string.IsNullOrEmpty(resultadoDb))
			{
				usuario.userName = string.Empty;
			}
			else
			{
				usuario.userName = resultadoDb;
				usuario.Password= password;
				usuario.Role = "Admin";
			}
			return usuario; 
		}
	}
}

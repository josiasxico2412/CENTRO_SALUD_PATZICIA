using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace CENTRO_SALUD_PATZICIA.Authentication
{
	public class CustomAuthenticationStateProvider : AuthenticationStateProvider
	{
		private readonly ProtectedSessionStorage _sessionStorage;
		private ClaimsPrincipal _anonymuos = new ClaimsPrincipal(new ClaimsIdentity());

		public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
		{
			_sessionStorage = sessionStorage;
		}
		public override async Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			try
			{
				var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");
				var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;
				if (userSession == null)
					return await Task.FromResult(new AuthenticationState(_anonymuos));
				var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
			{
				new Claim(ClaimTypes.Name, userSession.UserName),
				new Claim(ClaimTypes.Role, userSession.Role)
			}, "CustonAuth"));
				return await Task.FromResult(new AuthenticationState(claimsPrincipal));
			}
			catch
			{
				return await Task.FromResult(new AuthenticationState(_anonymuos));
			}
		}

		public async Task UpdateAuthenticationState(UserSession userSession)
		{
			ClaimsPrincipal claimsPrincipal;

			if (userSession != null)
			{
				await _sessionStorage.SetAsync("UserSession", userSession);
				claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
				{
					new Claim(ClaimTypes.Name, userSession.UserName)
				}));
			}
			else
			{
				await _sessionStorage.DeleteAsync("UserSession");
				claimsPrincipal = _anonymuos;
			}
			NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
		}
        public void Logout()
        {
            // Notifica a los consumidores que el usuario ha cerrado sesión
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}

namespace CENTRO_SALUD_PATZICIA.Authentication
{
	public class UserAccountService
	{
		private List<UserAccount> _users;
		public UserAccountService()
		{
			_users = new List<UserAccount>
			{
				new UserAccount { userName = "admin", Password = "admin", Role = "Administrador" },
				new UserAccount { userName = "user", Password = "user", Role = "User" }
			};
		}
		public UserAccount? GetByUserName(string userName)
		{
			return _users.FirstOrDefault(x => x.userName == userName);
		}
	}
}

using System.Net.Http.Json;
using System.Reflection;
using Blazored.LocalStorage;
using Microsoft.Extensions.Configuration;
using YallaHelpWeb.Shared;
using static System.Net.WebRequestMethods;

namespace YallaHelp2023.AppService
{
    public class MainService
    {
		public ILocalStorageService localStorageService;
		public IConfiguration configuration;
		public HttpClient Http;
        public MainService(ILocalStorageService localStorageService , IConfiguration _configuration) { 
			this.localStorageService = localStorageService;
			this.configuration = _configuration;
			this.Http = new HttpClient { BaseAddress = new Uri($"{configuration.GetConnectionString("ApiConnection")}") };
        }
        public void NotifyStateChanged() => OnChange?.Invoke();
        public event Action? OnChange;
		public bool IsAnyNullOrEmpty(object myObject)
		{
			foreach (PropertyInfo pi in myObject.GetType().GetProperties())
			{
				if (pi.PropertyType == typeof(string))
				{
					string value = (string)pi.GetValue(myObject);
					if (string.IsNullOrEmpty(value))
					{
						return true;
					}
				}
			}
			return false;
		}
		public Account UserAuthData = new Account();
		public User AccountData = new User();
        public bool Loading = false;
		public async Task AutoLogUser(Account account)
		{
			try
			{
				var response = await Http.GetFromJsonAsync<AccountResponse>($"api/User/CheckUserRegistration?PhoneNumber={account.Phone_Number}");
				if (response != null)
				{
                    if (account.Password == response.Data.Password)
					{
						UserAuthData = response.Data;
                        NotifyStateChanged();
                        UserResponse? result = new UserResponse();
						result = await Http.GetFromJsonAsync<UserResponse>($"api/User/UserData?UserId={account.User_Id}");
						if (result.Code == "200")
						{
                            AccountData = result.Data;
							NotifyStateChanged();
						}
					}
					
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
        public async Task LogUserOut()
        {
            try
            {
               await localStorageService.RemoveItemAsync("usdat");
				AccountData = new User();
                NotifyStateChanged();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

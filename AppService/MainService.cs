using System.Reflection;
using YallaHelpWeb.Shared;

namespace YallaHelp2023.AppService
{
    public class MainService
    {
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
	}
}

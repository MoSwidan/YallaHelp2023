namespace YallaHelp2023.AppService
{
    public class AlertService
    {
        public void NotifyStateChanged() => OnChange?.Invoke();
        public event Action? OnChange;
        public List<alert> AlertsList = new List<alert>();
        private async Task Removealert(alert alert, int time)
        {
            time = 5000;
            await Task.Delay(time);
            AlertsList.Remove(alert);
            this.NotifyStateChanged();
        }
        public async void ShowAlert(string? message, string? type)
        {
            alert _alertitem = new alert()
            {
                Massage = message,
                Type = type
            };
            AlertsList.Add(_alertitem);
            this.NotifyStateChanged();
            await Removealert(_alertitem,5000);
        }
    }
    public class alert
    {
        public string? Massage { get; set; }
        public string? Type { get; set; }
    }
}

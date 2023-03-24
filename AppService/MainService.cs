namespace YallaHelp2023.AppService
{
    public class MainService
    {
        public void NotifyStateChanged() => OnChange?.Invoke();
        public event Action? OnChange;

    }
}

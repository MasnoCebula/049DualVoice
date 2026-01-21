using Exiled.API.Interfaces;

public class Config : IConfig
{
    private bool _isEnabled = true;

    public bool IsEnabled
    {
        get { return _isEnabled; }
        set { _isEnabled = value; }
    }
}

namespace NotificationApp;

public class NotificationParser
{
    private readonly List<string> _channels;

    public NotificationParser(List<string> channels)
    {
        this._channels = channels;
    }
    public List<string> ParseNotificationChannels(string msg)
    {
        var tags = msg.Split('[', ']').Where((_, i) => i % 2 != 0).ToList();
        return _channels.Intersect(tags).ToList();
    }
}
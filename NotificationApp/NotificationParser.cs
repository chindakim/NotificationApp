namespace NotificationApp;

public class NotificationParser
{
    private readonly List<string> _channels = new List<string> { "BE", "FE", "QA", "Urgent" };

    public List<string> ParseNotificationChannels(string msg)
    {
        var tags = msg.Split('[', ']').Where((_, i) => i % 2 != 0).ToList();
        return _channels.Intersect(tags).ToList();
    }
}
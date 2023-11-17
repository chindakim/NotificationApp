using NotificationApp;

var notificationTitle = new List<string>()
{
    "[BE][FE][Urgent] there is error",
    "[BE][QA][HAHA][Urgent] there is error"
};
var channels = new List<string> { "BE", "FE", "QA", "Urgent" };
NotificationParser notification = new NotificationParser(channels);
foreach (var title in notificationTitle)
{
    Console.WriteLine($"Notification channels: {string.Join(", ", notification.ParseNotificationChannels(title))}");
}

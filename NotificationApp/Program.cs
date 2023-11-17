using NotificationApp;

var notificationTitle = new List<string>()
{
    "[BE][FE][Urgent] there is error",
    "[BE][QA][HAHA][Urgent] there is error"
};
NotificationParser notification = new NotificationParser();
foreach (var title in notificationTitle)
{
    Console.WriteLine($"Notification channels: {string.Join(", ", notification.ParseNotificationChannels(title))}");
}

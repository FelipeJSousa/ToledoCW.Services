using ToledoCW.Services.Core.Notifications;

namespace ToledoCW.Services.Application.Interfaces;

public interface INotificationService
{
    void Handle(Notification notification, CancellationToken cancellationToken);

    void NewNotification(string key, string message, NotificationType type);

    IEnumerable<Notification> GetAll();

    void Clear();

    IEnumerable<Notification> GetAllErrors();

    bool HasNotifications();

    bool HasNotificationsErrors();
}
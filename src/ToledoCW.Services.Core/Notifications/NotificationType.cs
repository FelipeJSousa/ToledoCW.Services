using System.ComponentModel;

namespace ToledoCW.Services.Core.Notifications;

public enum NotificationType
{
    [Description("Error")] Error,

    [Description("Warning")] Warning,

    [Description("Information")] Information
}
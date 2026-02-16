using System.Diagnostics.CodeAnalysis;
using DesignPatternChallenge.Services.Notification;

namespace balta_desafio_carnacode_2026_3_factory_method.Builders;

public class PushNotificationBuilder
{
    private readonly PushNotification _notification = new();

    public PushNotificationBuilder SetDeviceToken(string token)
    {
        _notification.DeviceToken =  token;
        return this;
    }
    
    public PushNotificationBuilder SetTitle(string title)
    {
        _notification.Title =  title;
        return this;
    }
    public PushNotificationBuilder SetMessage(string message)
    {
        _notification.Message =  message;
        return this;
    }
    public PushNotificationBuilder SetBadge(int badge)
    {
        _notification.Badge = badge;
        return this;
    }
    
    public PushNotification Build()
    {
        return _notification;
    }
    
}
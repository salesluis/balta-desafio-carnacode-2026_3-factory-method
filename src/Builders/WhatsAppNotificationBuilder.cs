using DesignPatternChallenge.Services.Notification;

namespace balta_desafio_carnacode_2026_3_factory_method.Builders;

public class WhatsAppNotificationBuilder
{
    private readonly WhatsAppNotification _notification = new();
    
    public WhatsAppNotificationBuilder SetPhoneNumber(string phoneNumber)
    {
        _notification.PhoneNumber = phoneNumber;
        return this;
    }
    public WhatsAppNotificationBuilder SetMessage(string message)
    {
        _notification.Message = message;
        return this;
    }
    public WhatsAppNotificationBuilder UseTemplate()
    {
        _notification.UseTemplate = true;
        return this;
    }
    public WhatsAppNotification Build()
    {
        return _notification;
    }
}
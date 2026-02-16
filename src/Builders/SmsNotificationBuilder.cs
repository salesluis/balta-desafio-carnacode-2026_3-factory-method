using DesignPatternChallenge.Services.Notification;

namespace balta_desafio_carnacode_2026_3_factory_method.Builders;

public class SmsNotificationBuilder
{
    private readonly SmsNotification _notification = new();

    public SmsNotificationBuilder SetPhoneNumber(string phoneNumber)
    {
        _notification.PhoneNumber = phoneNumber;
        return this;
    }
    public SmsNotificationBuilder SetMessage(string message)
    {
        _notification.Message = message;
        return this;
    }
    
    public SmsNotification Build()
    {
        return _notification;
    }
}
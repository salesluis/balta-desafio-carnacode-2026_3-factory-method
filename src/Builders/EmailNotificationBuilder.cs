using DesignPatternChallenge.Services.Notification;

namespace balta_desafio_carnacode_2026_3_factory_method.Builders;

public class EmailNotificationBuilder
{
    private readonly EmailNotification _notification = new();

    public EmailNotificationBuilder SetRecipient(string recipient)
    {
        _notification.Recipient = recipient;
        return this;
    }
    public EmailNotificationBuilder SetSubject(string subject)
    {
        _notification.Subject = subject;
        return this;
    }
    public EmailNotificationBuilder Body(string body)
    {
        _notification.Body = body;
        return this;
    }
    

    public EmailNotificationBuilder IsHtml()
    {
        _notification.IsHtml = true;
        return this;
    }

    public EmailNotification Build()
    {
        return _notification;
    }
}
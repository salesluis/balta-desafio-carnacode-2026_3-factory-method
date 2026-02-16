using balta_desafio_carnacode_2026_3_factory_method.Builders;
using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Services.Notification;

namespace DesignPatternChallenge.Factories;

public class WhatsAppCreator : NotificationCreator
{
    public override INotification CriateNotification() => new WhatsAppNotification();
    public WhatsAppNotificationBuilder CreateBuilder() => new WhatsAppNotificationBuilder();

}
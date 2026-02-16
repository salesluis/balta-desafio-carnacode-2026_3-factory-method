using balta_desafio_carnacode_2026_3_factory_method.Builders;
using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Services.Notification;

namespace DesignPatternChallenge.Factories;

public class PushCreator : NotificationCreator
{
    public override INotification CriateNotification() => new PushNotification();
    public PushNotificationBuilder CreateBuilder() => new PushNotificationBuilder();

}
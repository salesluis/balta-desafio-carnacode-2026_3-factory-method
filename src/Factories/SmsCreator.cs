using balta_desafio_carnacode_2026_3_factory_method.Builders;
using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Services.Notification;

namespace DesignPatternChallenge.Factories;

public class SmsCreator : NotificationCreator
{
    public override INotification CriateNotification() => new SmsNotification();
    public SmsNotificationBuilder CreateBuilder() => new SmsNotificationBuilder();

}
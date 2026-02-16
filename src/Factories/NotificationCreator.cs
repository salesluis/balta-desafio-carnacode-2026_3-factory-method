using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Services.Notification;

namespace DesignPatternChallenge.Factories;

public abstract class NotificationCreator
{
    // Factory Method
    public abstract INotification CriateNotification();
    public void SendNotification()
    {
        var service = CriateNotification();
        service.Send();
    }
}

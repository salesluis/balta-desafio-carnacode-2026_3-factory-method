using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Services.Notification;

public class WhatsAppNotification : INotification
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    public bool UseTemplate { get; set; }

    public void Send()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {PhoneNumber}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   Template: {UseTemplate}");
    }
}
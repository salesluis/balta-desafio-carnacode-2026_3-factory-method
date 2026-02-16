// // DESAFIO: Sistema de Notificações Multi-Canal
// // PROBLEMA: Uma aplicação de e-commerce precisa enviar notificações por diferentes canais
// // (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação
// // O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações

using DesignPatternChallenge.Factories;

Console.Clear();
Console.WriteLine();
Console.WriteLine("###########  Email notification ###########");
var emailCreator = new EmailCreator();
var email = emailCreator
    .CreateBuilder()
    .SetRecipient("cliente@email.com")
    .SetSubject("12345")
    .Body("Email")
    .IsHtml()
    .Build();

email.Send();

Console.WriteLine();
Console.WriteLine("###########  SMS notification ###########");
var smsCreator = new SmsCreator();
var sms = smsCreator
    .CreateBuilder()
    .SetPhoneNumber("+5511999999999")
    .SetMessage("hello world")
    .Build();

sms.Send();

Console.WriteLine();
Console.WriteLine("###########  WhatsApp notification ###########");
var wppCreator = new WhatsAppCreator();
var wpp = wppCreator
    .CreateBuilder()
    .SetPhoneNumber("+5511999999999")
    .UseTemplate()
    .SetMessage("hello world")
    .Build();

wpp.Send();


Console.WriteLine();
Console.WriteLine("###########  WhatsApp notification ###########");
var pushCreator = new PushCreator();
var push = pushCreator
    .CreateBuilder()
    .SetTitle("pedido enviado")
    .SetMessage("pedido enviado")
    .SetBadge(1)
    .Build();

push.Send();

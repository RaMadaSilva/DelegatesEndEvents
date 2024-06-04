namespace DelegatesAndEvents.Services
{
    public class EmailService
    {
        public void SendEmail(object source)
        {
            //Colocar aqui a logica de envio de email. 
            Console.WriteLine($"EmailService: Enviando email de Notificação do producto");
        }
    }
}

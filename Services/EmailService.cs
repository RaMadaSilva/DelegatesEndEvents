namespace DelegatesAndEvents.Services
{
    public class EmailService
    {
        public void OnProductAdded(object source, ProductEventArgs e)
        {
            //Colocar aqui a logica de envio de email. 
            Console.WriteLine($"EmailService: Enviando email de Notificação do producto: {e.Product.Name}");
        }
    }
}

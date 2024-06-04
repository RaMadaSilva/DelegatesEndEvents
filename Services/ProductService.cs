using DelegatesAndEvents.Models;

namespace DelegatesAndEvents.Services; 

public class ProductService
{
    //Declarando o Delegate
    public delegate void ProductAddedEventHandler(object source); 

    //Evento baseado no delegate
    public event ProductAddedEventHandler? OnProductAdded;

    public void AddProduct(Product product)
    { 
        //Adicionar a logica para adicionar um produto. 

        //gerar ou disparar o evento!
        OnProductAdded?.Invoke(product); 
    }
}

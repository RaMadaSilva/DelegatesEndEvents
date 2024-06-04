using DelegatesAndEvents.Models;

namespace DelegatesAndEvents.Services; 

public class ProductService
{
    //Declarando o Delegate
    public delegate void ProductAddedEventHandler(object source, ProductEventArgs args); 

    //Evento baseado no delegate
    public event ProductAddedEventHandler ProductAdded;

    protected virtual void OnProductAdded(Product product)
    {
        if (ProductAdded != null)
        {
            ProductAdded(this, new ProductEventArgs()
            {
                Product = product
            });
        }
    }

    public void AddProduct(Product product) 
    { 
        //Aqui deve ser colocado a logica para adicionar um producto, 

        OnProductAdded(product);
    }
}

    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; set; } = new(); 
    }

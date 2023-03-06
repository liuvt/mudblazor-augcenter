using Microsoft.AspNetCore.Components;
using mudblazor_augcenter.Models;
using MudBlazor;
using Microsoft.AspNetCore.Components.Forms;

namespace mudblazor_augcenter.Pages
{
    public class ProductsBase: ComponentBase
    {
        protected string ErrorMessage { get; set; }        
        protected string TittlePage { get; set; }
        protected Product productModel = new Product();
        protected List<Product> listProducts = new List<Product>();
        [Inject]
        protected ProductsInit initProducts { get; set; }
        protected bool success;        
        
        protected override async Task OnInitializedAsync()
        {
            try
            {
                listProducts = initProducts.Products;
                TittlePage = "This is my project with plugin MudBlazor.";
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected void OnValidSubmit(EditContext context)
        {
            success = true;
            listProducts.Add(productModel);
            StateHasChanged();
        }
    }
}
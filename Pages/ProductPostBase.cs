using Microsoft.AspNetCore.Components;
using mudblazor_augcenter.Models;
using MudBlazor;
using Microsoft.AspNetCore.Components.Forms;
using mudblazor_augcenter.Data;

namespace mudblazor_augcenter.Pages
{
    public class ProductPostBase : ComponentBase
    {
        [Inject]
        protected ISnackbar snackBar { get; set; }
        [Inject]
        protected ProductsInit _Products { get; set; }
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected Product productPost = new Product();
        protected List<Product> listProducts = new List<Product>();
        protected string searchString = "";
        protected string result { get; set; } 
        //HTML Editor
        //be sure to set the default font as the first in the list
        protected List<string> Fonts = new List<string> { "Courier", "Impact", "MSGothic", "Comic", "Bahnschrift" }; 
        protected WYSIWYGTextEditor.TextEditor MyEditor;

        //Processing
        protected bool _processing = false;

        protected override async Task OnInitializedAsync()
        {
            listProducts = _Products.Products;
        }

        protected async Task ProductPost_Click()
        {
            try
            {
                listProducts.Add(productPost);

                snackBar.Add($"Đã tạo sản phẩm thành công.", Severity.Success);
                NavigationManager.NavigateTo("/products/list", true);
            }
            catch (Exception ex)
            {
                _processing = false;
                result = ex.Message;
                snackBar.Add(ex.Message, Severity.Error);
            }
        }

        protected async void OnValidSubmit(EditContext context)
        {
            _processing = true;
            await ProductPost_Click();
            StateHasChanged(); //re-rendered
        }

        protected void ResetModel_Click()
        {
            //StateHasChanged();
            productPost = new Product(); // Resetting model to clear the input
        }
        
        protected string QuillHTMLContent;
        protected string QuillContent;

        protected async void GetHTML()
        {
            try{
                QuillHTMLContent = await this.MyEditor.GetHTML();
            }catch(Exception ex)
            {
                result = ex.Message;
            }
        }
        protected async void GetContent()
        {
            try{
                QuillContent = await this.MyEditor.GetContent();
            }catch(Exception ex)
            {
                result = ex.Message;
            }
        }
    }
}
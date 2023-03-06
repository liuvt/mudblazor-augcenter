using Microsoft.AspNetCore.Components;
using mudblazor_augcenter.Models;
using MudBlazor;
using mudblazor_augcenter.Data;

namespace mudblazor_augcenter.Pages
{
    public class ProductsListBase: ComponentBase
    {
        protected List<string> _events = new();
        protected IEnumerable<Product> Elements = new List<Product>();
        protected string _searchString;
        protected bool _sortNameByLength;
        [Inject] 
        protected ProductsInit _Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Elements = _Products.Products;
        }

        // custom sort by name length
        protected Func<Product, object> _sortBy => x =>
        {
            if (_sortNameByLength)
                return x.ProductName.Length;
            else
                return x.ProductName;
        };

        // quick filter - filter gobally across multiple columns with the same input
        protected Func<Product, bool> _quickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(_searchString))
                return true;

            if (x.ProductName.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.ProductCartDesc.Contains(_searchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.ProductPrice} {x.ProductId} {x.ProductSku}".Contains(_searchString))
                return true;

            return false;
        };

        // events
        protected void RowClicked(DataGridRowClickEventArgs<Product> args)
        {
            _events.Insert(0, $"Event = RowClick, Index = {args.RowIndex}, Data = {System.Text.Json.JsonSerializer.Serialize(args.Item)}");
        }

        protected void SelectedItemsChanged(HashSet<Product> items)
        {
            _events.Insert(0, $"Event = SelectedItemsChanged, Data = {System.Text.Json.JsonSerializer.Serialize(items)}");
        }

        // events
        protected void StartedEditingItem(Product item)
        {
            _events.Insert(0, $"Event = StartedEditingItem, Data = {System.Text.Json.JsonSerializer.Serialize(item)}");
        }

        protected void CanceledEditingItem(Product item)
        {
            _events.Insert(0, $"Event = CanceledEditingItem, Data = {System.Text.Json.JsonSerializer.Serialize(item)}");
        }

        protected void CommittedItemChanges(Product item)
        {
            _events.Insert(0, $"Event = CommittedItemChanges, Data = {System.Text.Json.JsonSerializer.Serialize(item)}");
        }

        // style the cells according to the element's physical classification and the molar mass.
        protected Func<Product, string> _cellStyleFunc => x =>
        {
            string style = "";

            if (x.ProductId == 1)
                style += "background-color:#8CED8C;font-weight:bold";
            else if (x.ProductId == 2)
                style += "background-color:#E5BDE5;font-weight:bold";
            else if (x.ProductId == 3)
                style += "background-color:#EACE5D;font-weight:bold";
            else if (x.ProductId == 4)
                style += "background-color:#F1F165;font-weight:bold";
            else if (x.ProductId == 5)
                style += ";color:#F1F165;font-weight:bold";
            //Neu ID > 5 font chu in dam
            if (x.ProductId > 5)
                style += ";font-weight:bold";
            //Tra ve mat dinh
            return style;
        };

                // style the cells according to the element's physical classification and the molar mass.
        protected Func<Product, string> _cellStyleFuncProductPrice => x =>
        {
            return ";color:#F32432;font-weight:bold";
        };
    }
}
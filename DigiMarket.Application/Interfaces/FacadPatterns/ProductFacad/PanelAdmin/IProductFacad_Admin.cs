using DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewCategory;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.DeleteCategory;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.DeleteFeatureProduct;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.DeleteImageProduct;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.RemoveProduct;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.UpdateProduct;
using DigiMarket.Application.Services.Products.Queries.GetAllCategory;
using DigiMarket.Application.Services.Products.Queries.GetCategories;
using DigiMarket.Application.Services.Products.Queries.GetProductDetailForAdmin;
using DigiMarket.Application.Services.Products.Queries.GetProductForAdmin;

namespace DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.PanelAdmin
{
    public interface IProductFacad_Admin
    {
        AddNewCategoryService AddNewCategoryService { get; }
        GetCategoriesService GetCategoriesService { get; }
        DeleteCategoryService DeleteCategoryService { get; }
        AddNewProductService AddNewProductService { get; }
        GetAllCategoryService GetAllCategoryService { get; }
        IGetProductForAdminService GetProductForAdminService { get; }
        GetProductDetailForAdminService GetProductDetailForAdminService { get; }
        RemoveProductService RemoveProductService { get; }

        DeleteFeatureProductService DeleteFeatureProductService { get; }
        DeleteImageProductService DeleteImageProductService { get; }

        UpdateProductService UpdateProductService { get; }
    }
}

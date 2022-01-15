using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.PanelAdmin;
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
using Microsoft.AspNetCore.Hosting;

namespace DigiMarket.Application.Services.Products.PanelAdmin.FasadPattern
{
   public class ProductFacad_Admin:IProductFacad_Admin
   {
       private readonly IDigiMarketContext _context;
       private readonly IHostingEnvironment _environment;

        public ProductFacad_Admin(IDigiMarketContext context, IHostingEnvironment environment)
       {
           _context = context;
           _environment = environment;
       }

       private AddNewCategoryService _addNewCategoryService;
       public AddNewCategoryService AddNewCategoryService
       {
           get
           {
               return _addNewCategoryService = _addNewCategoryService ?? new AddNewCategoryService(_context);
           }
       }

       private GetCategoriesService _getCategoriesService;

       public GetCategoriesService GetCategoriesService
       {
           get
           {
               return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
           }
       }

       private DeleteCategoryService _deleteCategoryService;

       public DeleteCategoryService DeleteCategoryService
       {
           get
           {
               return _deleteCategoryService = _deleteCategoryService ?? new DeleteCategoryService(_context);
           }
       }


       private AddNewProductService _addNewProductService;
       public AddNewProductService AddNewProductService
       {
           get
           {
               return _addNewProductService = _addNewProductService ?? new AddNewProductService(_context, _environment);
           }

       }

       private GetAllCategoryService _allCategoryService;

       public GetAllCategoryService GetAllCategoryService
       {
           get
           {
               return _allCategoryService = _allCategoryService ?? new GetAllCategoryService(_context);
           }
       }

       private IGetProductForAdminService _getProductForAdminService;

       public IGetProductForAdminService GetProductForAdminService
       {
           get
           {
               return _getProductForAdminService = _getProductForAdminService ?? new GetProductForAdminService(_context);

            }
        }
       private GetProductDetailForAdminService _getProductDetailForAdminService;

       public GetProductDetailForAdminService GetProductDetailForAdminService
       {
           get
           {
               return _getProductDetailForAdminService = _getProductDetailForAdminService ?? new GetProductDetailForAdminService(_context);

            }
        }

       private RemoveProductService _removeProductService;

       public RemoveProductService RemoveProductService
       {
           get
           {
               return _removeProductService = _removeProductService ?? new RemoveProductService(_context);
           }
       }




       private DeleteFeatureProductService _deleteFeatureProductService;

       public DeleteFeatureProductService DeleteFeatureProductService
       {
           get
           {
               return _deleteFeatureProductService =
                   _deleteFeatureProductService ?? new DeleteFeatureProductService(_context);
           }
       }





       private DeleteImageProductService _deleteImageProductService;

       public DeleteImageProductService DeleteImageProductService
       {
           get
           {
               return _deleteImageProductService =
                   _deleteImageProductService ?? new DeleteImageProductService(_context);
           }
       }


       private UpdateProductService _updateProductService;

       public UpdateProductService UpdateProductService
       {
           get
           {
               return _updateProductService = _updateProductService ?? new UpdateProductService(_context , _environment);
           }

       }
   }
}

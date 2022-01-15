using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.PanelAdmin;
using Microsoft.AspNetCore.Authorization;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PaysController : Controller
    {
        private IFinancesFacad_Admin _financesFacadAdmin;

        public PaysController(IFinancesFacad_Admin financesFacadAdmin)
        {
            _financesFacadAdmin = financesFacadAdmin;
        }
        public IActionResult Index()
        {
            return View(_financesFacadAdmin.GetPaysForAdminService.Execute().Data);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Finances.Site.Command.AddRequestPay;
using DigiMarket.Application.Services.Finances.Site.Queries.GetAuthorityAndRefIdForRequestPay;
using DigiMarket.Application.Services.Finances.Site.Queries.GetInformationForFailedpayment;
using DigiMarket.Application.Services.Finances.Site.Queries.GetRequestPay;

namespace DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.Site
{
   public interface IFinancesFacad_Site
    {

        AddRequestPayService AddRequestPayService { get; }
        GetRequestPayService GetRequestPayService { get; }
        GetAuthorityAndRefIdForRequestPayService GetAuthorityAndRefIdForRequestPayService { get; }
        GetInformationForFailedPaymentService GetInformationForFailedPaymentService { get; }
    }
}

using System.Collections.Generic;
using Afonsoft.NewTemplate.Editions.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Payments;

namespace Afonsoft.NewTemplate.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
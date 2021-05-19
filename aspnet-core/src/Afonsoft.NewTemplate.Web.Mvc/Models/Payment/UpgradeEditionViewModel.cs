﻿using System.Collections.Generic;
using Afonsoft.NewTemplate.Editions.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Payments;

namespace Afonsoft.NewTemplate.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
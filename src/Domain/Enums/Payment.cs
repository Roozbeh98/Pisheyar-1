using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum CreatePaymentState
    {
        Success = 1,
        UserNotFound = 2,
        ContractorNotFound = 3,
        NullReferencePaymentRequest = 4
    }

    public enum VerifyPaymentState
    {
        Success = 1,
        PaymentNotFound = 2,
        InvalidPayment = 3
    }

    public enum GetAllPaymentsState
    {
        Success = 1,
        UserNotFound = 2,
        AdminNotFound = 3,
        PaymentNotFound = 4,
        NotAnyPaymentsFound = 5
    }
}

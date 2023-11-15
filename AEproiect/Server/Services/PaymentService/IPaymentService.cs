using AEproiect.Shared;
using Stripe.Checkout;

namespace AEproiect.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(List<CartItem> cartItems);
    }
}

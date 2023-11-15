using AEproiect.Shared;
using Stripe;
using Stripe.Checkout;

namespace AEproiect.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51OCMRRGibB2LvxPRLsbUBfR8hcIWsSJDHU8AZ6HWiFMpzm3qKvebRBJFnBlulT3qFvDSzM7tw7naP8zRmbi2CKEH00guKPymvq";
        }
        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency="usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image }
                    }
                },
                Quantity=ci.Quantity
            }));

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                LineItems = lineItems,
                Mode="payment",
                SuccessUrl= "https://localhost:7152/order-success",
                CancelUrl= "https://localhost:7152/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }
    }
}

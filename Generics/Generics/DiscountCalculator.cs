namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            float discount = 5;
            return product.Price - discount;
        }
    }
}

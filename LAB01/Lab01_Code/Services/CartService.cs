public class CartService
{
    public static List<Cart> getAllCarts(CartRepository cartRepository)
    {
        List<Cart> localCarts = cartRepository.getAllCarts();
        foreach (Cart cart in localCarts)
        {
            foreach (Article article in cart.getArticles())
            {
                cart.setValue(cart.getValue() + article.getPrice() * article.getQuantity());
            }
        }

        return localCarts;
    }
}
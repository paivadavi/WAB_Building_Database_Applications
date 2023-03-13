public class CartView
{
    static CartRepository cartRepository = new CartRepository();
    List<Cart> allCarts = CartService.getAllCarts(cartRepository);
}
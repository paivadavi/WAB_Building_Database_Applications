public class CartRepository
{
    private List<Cart> carts;

    public Cart getCart(int id)
    {
        Cart localCart = new Cart();
        foreach (Cart cart in getCarts())
        {
            if (cart.getId() == id)
            {
                return cart;
            }
        }
        return localCart;

    }

    public List<Cart> getAllCarts(DateTime updateDate)
    {
        List<Cart> localCarts = new List<Cart>();
        foreach (Cart cart in getCarts())
        {
            if (cart.getUpdatedDate().Equals(updateDate))
            {
                localCarts.Add(cart);
            }
        }
        return localCarts;
    }

    public List<Cart> getAllCarts()
    {
        return this.carts;
    }

    // GETTERS AND SETTERS
    public void setCarts(List<Cart> carts)
    {
        this.carts = carts;
    }
    public List<Cart> getCarts()
    {
        return this.carts;
    }
}
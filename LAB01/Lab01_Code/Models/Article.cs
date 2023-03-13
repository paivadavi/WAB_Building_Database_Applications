public class Article
{
    private int id;
    private string name;
    private decimal price;
    private int quantity;
    private string unit;

    // GETTERS AND SETTERS

    //id
    public void setId(int id)
    {
        this.id = id;
    }
    public int getId()
    {
        return this.id;
    }
    //name
    public void setName(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return this.name;
    }
    //price
    public void setPrice(decimal price)
    {
        this.price = price;
    }
    public decimal getPrice()
    {
        return this.price;
    }
    //quantity
    public void setQuantity(int quantity)
    {
        this.quantity = quantity;
    }
    public int getQuantity()
    {
        return this.quantity;
    }
    //unit
    public void setUnit(string unit)
    {
        this.unit = unit;
    }
    public string getUnit()
    {
        return this.unit;
    }

    //TO STRING

    public string toString()
    {
        return "id: " + this.id +
        "name: " + this.name +
        "price: " + this.price +
        "quantity: " + this.quantity +
        "unit: " + this.unit;
    }
}
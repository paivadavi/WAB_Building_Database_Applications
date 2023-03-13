public class Cart
{
    private int id;
    private DateTime createdDate;
    private DateTime updatedDate;
    private int userId;
    private List<Article> articles;
    private decimal value;

    //GETTERS AND SETTERS

    //id
    public void setId(int id)
    {
        this.id = id;
    }
    public int getId()
    {
        return this.id;
    }
    //userId
    public void setUserId(int userId)
    {
        this.userId = userId;
    }
    public int getUserId()
    {
        return userId;
    }
    //createdDate
    public void setCreatedDate(DateTime createdDate)
    {
        this.createdDate = createdDate;
    }
    public DateTime getCreatedDate()
    {
        return this.createdDate;
    }
    //updatedDate
    public void setUpdatedDate(DateTime updatedDate)
    {
        this.updatedDate = updatedDate;
    }
    public DateTime getUpdatedDate()
    {
        return this.updatedDate;
    }
    //articles
    public void setArticles(List<Article> articles)
    {
        this.articles = articles;
    }
    public List<Article> getArticles()
    {
        return this.articles;
    }
    //value
    public void setValue(decimal value)
    {
        this.value = value;
    }
    public decimal getValue()
    {
        return this.value;
    }

    //TO STRING 
    public string toString()
    {
        return "id: " + this.id +
        "createdDate: " + this.createdDate +
        "updatedDate: " + this.updatedDate +
        "userId: " + this.userId +
        "articles: " + this.articles.ToString +
        "value: " + this.value;
    }
}
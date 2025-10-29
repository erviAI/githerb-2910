public class BasketOfHerbs 
{
    public required int Id { get; set; }
    public List<Herb> Herbs { get; set; } = new();

    public bool IsReadyToSend()
    {
        if (Herbs.Count == 0)
        {
            return false;
        }
        if (Herbs.Count == 7)
        {
            throw new Exception("Basket cannot have 7 Herbs");
        }
        if (Herbs.Count >= 10)
        {
            throw new Exception("Basket cannot have more than 10 herbs");
        }
        return true;
    }
}

namespace githerb.Tests;

public class BasketOfHerbsIsReadyToSendTest()
{
    [Fact]
    public void ShouldBeFalse_IfNoHerbs()
    {
        var basket = new BasketOfHerbs { Id = 1 };
        Assert.False(basket.IsReadyToSend(), "Basket is not ready to send");
    }
}
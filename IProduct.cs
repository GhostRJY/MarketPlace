using MessagePack;


namespace MarketPlace
{
    
    internal interface IProduct
    {
        //объект должен
        abstract public void ShowProduct();
        abstract public void ShowProductSmallInfo();
        abstract public string ToString();
        abstract public void Serialize();

    }
}

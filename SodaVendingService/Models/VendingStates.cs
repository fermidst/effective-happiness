namespace SodaVendingService.Models
{
    public enum VendingStates
    {
        NoMoney = 0,
        HasMoney = 1,
        Success = 2,
        Failure = 3,
        NotEnough = 4,
        Refund = 5
    }
}
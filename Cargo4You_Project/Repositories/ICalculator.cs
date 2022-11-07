namespace Cargo4You_Project.Repositories
{
    public interface ICalculator
    {
        void calculatePriceByVolume();
        void calculatePriceByWeight();
        void calculateTotalPrice();

    }
}

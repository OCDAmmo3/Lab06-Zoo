namespace Animals
{
    interface IAnimal
    {
        string Diet { get; }
        string Home { get; }
        string Name { get; }
        bool Omnivore { get; }
        string Sound { get; }
    }
}
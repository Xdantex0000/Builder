namespace Builder.Abstractions
{
    interface IProduct
    {
        string Name { get; }

        string GetDescription();
    }
}

namespace Builder.Abstractions
{
    abstract class Product : IProduct
    {
        private List<string> features = new();
        public virtual string Name { get; } = nameof(Product);

        protected void SetFeature(string feature)
        {
            features.Add(feature);
        }

        public string GetDescription()
            => $"Product: {Name} {GetFeatures()}";

        private string GetFeatures()
            => $"Features: {string.Join(", ", features)}";
    }
}

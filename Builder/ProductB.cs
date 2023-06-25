using Builder.Abstractions;

namespace Builder
{
    class ProductB : Product
    {
        public override string Name { get; } = nameof(ProductB);

        public void SetFeatureA() => SetFeature("featureA");
        public void SetFeatureB() => SetFeature("featureB");
        public void SetFeatureF() => SetFeature("featureF");
        public void SetFeatureG() => SetFeature("featureG");
        public void SetFeatureX() => SetFeature("featureX");
    }
}

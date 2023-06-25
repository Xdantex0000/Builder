using Builder.Abstractions;

namespace Builder
{
    class ProductA : Product
    {
        public override string Name { get; } = nameof(ProductA);

        public void SetFeatureA() => SetFeature("featureA");
        public void SetFeatureB() => SetFeature("featureB");
        public void SetFeatureC() => SetFeature("featureC");
        public void SetFeatureD() => SetFeature("featureD");
        public void SetFeatureE() => SetFeature("featureE");
    }
}

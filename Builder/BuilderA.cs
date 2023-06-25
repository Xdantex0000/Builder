using Builder.Abstractions;

namespace Builder
{
    class BuilderA : IBuilder
    {
        private ProductA result = new();

        public IBuilder BuildStepA()
        {
            result.SetFeatureA();
            result.SetFeatureB();

            return this;
        }

        public IBuilder BuildStepB()
        {
            result.SetFeatureC();

            return this;
        }

        public IBuilder BuildStepC()
        {
            result.SetFeatureD();
            result.SetFeatureE();

            return this;
        }

        public IProduct GetResult()
            => result;

        public void Reset()
        {
            result = new ProductA();
        }
    }
}

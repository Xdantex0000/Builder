using Builder.Abstractions;

namespace Builder
{
    class BuilderB : IBuilder
    {
        private ProductB result = new();

        public IBuilder BuildStepA()
        {
            result.SetFeatureA();
            result.SetFeatureB();

            return this;
        }

        public IBuilder BuildStepB()
        {
            result.SetFeatureF();

            return this;
        }

        public IBuilder BuildStepC()
        {
            result.SetFeatureG();
            result.SetFeatureX();

            return this;
        }

        public IProduct GetResult()
            => result;

        public void Reset()
        {
            result = new ProductB();
        }
    }
}

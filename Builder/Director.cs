using Builder.Abstractions;

namespace Builder
{
    class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void Make(string type = "full")
        {
            switch (type)
            {
                case "simple":
                    builder
                        .BuildStepA()
                        .BuildStepB();
                    break;
                case "full":
                    builder
                        .BuildStepA()
                        .BuildStepB()
                        .BuildStepC();
                    break;
            }
        }

        public void ChangeBuilder(IBuilder builder)
        {
            this.builder = builder;
        }
    }
}

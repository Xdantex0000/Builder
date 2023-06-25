namespace Builder.Abstractions
{
    interface IBuilder
    {
        IBuilder BuildStepA();
        IBuilder BuildStepB();
        IBuilder BuildStepC();
        IProduct GetResult();
        void Reset();
    }
}

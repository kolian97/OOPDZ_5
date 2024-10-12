namespace OOPDZ_5
{
    internal interface ICalc
    {
        event EventHandler<EventArgs> GotResult;

        void Sum(int Value);
        void Substruct(int Value);
        void Multiply(int Value);
        void Divide(int Value);
        void CancelLast();
    }
}

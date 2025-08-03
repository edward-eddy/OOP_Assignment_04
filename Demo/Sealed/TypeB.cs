namespace Demo.Sealed
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public sealed override int X { get => base.X; set => base.X = value; }

        public sealed override void MyFun()
        {
            base.MyFun();
        }
    }
}

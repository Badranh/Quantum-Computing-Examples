namespace Bell
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation addTwoInts (a:Int,b:Int) : Int {
        body{
            mutable c = 0;
            set c = a + b;
            return c;
        }
    }
}
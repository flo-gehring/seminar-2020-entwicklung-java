// From: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/covariance-contravariance/creating-variant-generic-interfaces
// out R: R ist Covariant
// in A:  A ist Contravariant
interface IVariant<out R, in A>
{
    R GetSomething();
    void SetSomething(A sampleArg);
    R GetSetSomethings(A sampleArg);

    // Fehler:
    // A GetSomethingDifferent();
    // void SetSomethingDifferent(R sampleArg);
}

class Variant<R, A> : IVariant<R,  A>{
    R rMember;
    A aMember;
    
    public R GetSomething() { return rMember;}
    public void SetSomething(A a) {aMember = a;}
    public R GetSetSomethings(A a) 
    {
        aMember = a;
        return rMember;
    }
}
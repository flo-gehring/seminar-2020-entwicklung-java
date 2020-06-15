class InvariantClassesDemo 
{
    public static void test() 
    {
        // The interface is variant.
        IVariant<Derived, Base> variant = new Variant<Derived, Base>();
        IVariant<Base, Derived> co_contra_variant = variant;

        // The class is invariant.
        Variant<Derived, Base> invariant = new Variant<Derived, Base>();
        // The following statement generates a compiler error
        // because classes are invariant.
        // Variant<Base, Derived> invariant2 = 
        //    new Variant<Derived, Base>();
    }
}
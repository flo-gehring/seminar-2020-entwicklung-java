class InvariantClassesDemo 
{
    public static void test() 
    {
        // Das Interface ist Variant.
        IVariant<Derived, Base> variant = new Variant<Derived, Base>();
        IVariant<Base, Derived> co_contra_variant = variant;

        // Klassenvariablen sind Invariant
        Variant<Derived, Base> invariant = new Variant<Derived, Base>();
        // Klassen sind invariant: 
        // Variant<Base, Derived> invariant2 = invariant
    }
}
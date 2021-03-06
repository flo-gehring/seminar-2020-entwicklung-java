using System;
class GenericClass<T, U> 
    // T kann verglichen werden, 
    // ist von U abgeleitet
    // und hat einen parameterlosen Konstruktor
    where T : IComparable, U, new()
    // U ist eine Klasse (kein Struct o.Ä.)
    where U : class {
        T tMember;
        U uMember;
        Boolean comp<C>(C c) where C: IComparable<T> {
            return c.CompareTo(t) < 0;
        }
}
class NonGenericClass {
    public static void printGreaterIf<T> (T toPrint, T  check) 
                                        where T: IComparable {
        if (toPrint.CompareTo(check) > 0){
            System.Console.Write(toPrint);
        }
    }
}
IEnumerable<Derived> d = new List<Derived>();
IEnumerable<Base> b = d;

public delegate R DVariant<in A, out R>(A a);  

IComparer<Base> b = new BaseComparer(); // Implements IComparer<Base>
IComparer<Derived> d = b;
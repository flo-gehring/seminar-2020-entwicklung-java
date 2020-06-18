public class GenericDemo<T extends  Comparable<T>, U >  {
    T tMember;
    U uMember;
    // Generische Methode
    // C implementiert vergleich mit U.
    <C extends Comparable<T>> boolean comp(C c){
        return c.compareTo(tMember) < 0;
    }
}
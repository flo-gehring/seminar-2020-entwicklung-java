public class GenericDemo<T extends  Comparable<T>, U >  {

    U uMember;
    // Generische Methode
    // C implementiert vergleich mit U.
    <C extends Comparable<U>> boolean comp(C c){
        return c.compareTo(uMember) < 0;
    }
}
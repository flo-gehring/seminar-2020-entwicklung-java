
// T unbounded
// U Number oder Unterklasse und implementiert Comparable
public class GenericDemo<T, U extends Number & Comparable<U>>{

    U uMember;
    // Generische Methode
    // C implementiert vergleich mit U.
    <C extends Comparable<U>> boolean comp(C c){
        return c.compareTo(uMember) < 0;
    }

}
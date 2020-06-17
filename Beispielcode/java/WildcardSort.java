import java.util.Comparator;
import java.util.List;

public class WildcardSort<T> {
    Comparator<? super T> c;
    WildcardSort(List<? extends T> e, Comparator<? super T> c){
        this.c = c;
        c.compare(e.get(0), e.get(1));
    }
}
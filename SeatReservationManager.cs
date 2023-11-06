public class SeatManager {
    private int last;
    private SortedSet<int> pq;

    public SeatManager(int n) {
        this.last = 0;
        this.pq = new SortedSet<int>();
    }

    public int Reserve() {
        if (!pq.Any()) {
            return ++last;
        } else {
            int seat = pq.Min;
            pq.Remove(seat);
            return seat;
        }
    }

    public void Unreserve(int seatNumber) {
        if (seatNumber == last) {
            --last;
        } else {
            pq.Add(seatNumber);
        }
    }
}
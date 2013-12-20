public class FibonacciNumber {
	private delegate long Direction();

	private long previous = 0;
	private long current = 1;
	private int index = 1;

	public FibonacciNumber() {
	}

	public FibonacciNumber(long previous, long current, int index) {
		this.previous = previous;
		this.current = current;
		this.index = index;
	}

	public FibonacciNumber(FibonacciNumber number) {
		this.previous = number.getPrevious();
		this.current = number.getCurrent();
		this.index = number.getIndex();
	}

	public FibonacciNumber(int index) {
		this.moveToIndex(index);
	}

	public long getPrevious() {
		return this.previous;
	}

	public long getCurrent() {
		return this.current;
	}

	public int getIndex() {
		return this.index;
	}

	public long moveToNext() {
		long next = this.current + this.previous;

		this.previous = this.current;
		this.current = next;
		this.index++;

		return this.current;
	}

	public long moveToPrevious() {
		long previous = this.current - this.previous;

		this.current = this.previous;
		this.previous = previous;
		this.index--;

		return this.current;
	}

	public long move(int n) {
		Direction action = null;

		if (n < 0) {
			action = this.moveToPrevious;
		}
		else {
			action = this.moveToNext;
		}

		for (int i = 0; i < Math.Abs(n); i++) {
			action();
		}

		return this.current;
	}

	public long moveToIndex(int index) {
		return this.move(index - this.index);
	}

	public override string ToString() {
		string result = "";

		result += "FibonacciNumber(";
		result += "previous:" + this.previous + ",";
		result += "current:" + this.current + ",";
		result += "index:" + this.index + ")";

		return result;
	}
}
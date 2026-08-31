public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> numbers = new Stack<int>();
        int res = 0;
        for (int i = 0; i < operations.Length; i++) {
            if (int.TryParse(operations[i], out int result))
            {
                numbers.Push(result);
                res += result;
            }
            else {
                if (operations[i] == "+") {
                    int previousRecordOne = 0;
                    int previousRecordTwo = 0;
                    numbers.TryPop(out previousRecordOne);
                    numbers.TryPop(out previousRecordTwo);
                    numbers.Push(previousRecordTwo);
                    numbers.Push(previousRecordOne);
                    int last = previousRecordOne + previousRecordTwo;
                    numbers.Push(last);
                    res += last;
                }
                if (operations[i] == "C") {
                    res -= numbers.Pop();
                }
                if (operations[i] == "D") {
                    numbers.TryPop(out int previousRecordForD);
                    numbers.Push(previousRecordForD);
                    numbers.Push(2 * previousRecordForD);
                    res += (2*previousRecordForD);
                }
            }
        }
        return res;
    }
}
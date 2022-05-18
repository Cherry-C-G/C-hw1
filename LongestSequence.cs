class Program
{
    static void Main(string[] args)
    {
        var elemts = new int[] { 2 ,1 ,1 ,2 ,3 ,3 ,2 ,2 ,2 ,1 };

        var result = LongestSequence(elemts);

        foreach (var i in result)
        {
            Console.Write(i + "\t");
        }

        Console.ReadLine();
    }

    public static int[] LongestSequence(int[] elems)
    {
        var longSequenceEqualElem = new List<int>();
        return LongestSequenceRec(elems, longSequenceEqualElem, 0);
    }

    private static int[] LongestSequenceRec(int[] elems, List<int> sequence, int pos)
    {
        if (pos < elems.Length)
        {
            if (sequence.Contains(elems[pos]))
            {
                sequence.Add(elems[pos]);
                return LongestSequenceRec(elems, sequence, pos + 1);
            }
            else
            {
                var newSeq = LongestSequenceRec(elems, new List<int> { elems[pos] }, pos + 1);
                return (newSeq.Length > sequence.Count) ? newSeq.ToArray() : sequence.ToArray();
            }
        }
        return sequence.ToArray();
    }
}
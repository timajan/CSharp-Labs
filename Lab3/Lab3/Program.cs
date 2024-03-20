using SequenceAnalysis;

List<int> list1 = new List<int> { 1, 2, 4, 8, 16, 32};
List<int> list2 = new List<int> { 10, 8, 6, 4, 2, 0, -2, -4, -6 };
List<int> list3 = new List<int> { 1, 2, 4, 8, 16, 32 };
List<int> list4 = new List<int> { 1, 2, 4, 2, 1, 0, 3, 5 };

Sequence sequence1 = new Sequence(list1);
Sequence sequence2 = new Sequence(list2);
Sequence sequence3 = new Sequence(list3);
Sequence sequence4 = new Sequence(list4);


// Sequence 1
Console.WriteLine(sequence1.Max());
Console.WriteLine(sequence1.Min());

Console.WriteLine(sequence1.ElementBelongs(4));

foreach (string type in sequence1.GetTypeOfSequence())
{
    Console.Write(type + "  ");
}
Console.WriteLine();
Console.WriteLine();


// Sequence 2
Console.WriteLine(sequence2.Max());
Console.WriteLine(sequence2.Min());

Console.WriteLine(sequence2.ElementBelongs(7));

foreach (string type in sequence2.GetTypeOfSequence())
{
    Console.Write(type + "  ");
}
Console.WriteLine();

Console.WriteLine(sequence1.CompareSequences(sequence3));

sequence4.GetLocalExtremes(true);

Console.WriteLine("WRITE");
sequence4.WriteSequence();
sequence4.WriteSubSequences();
Console.WriteLine();



Console.WriteLine();

sequence1.SaveToJson("C:\\Users\\Tima\\source\\repos\\C-sharp_labs\\hello.json");


foreach (int num in sequence4.LargestSubsequence())
{
    Console.Write(num + " ");
}
Console.WriteLine();
Console.WriteLine();


Console.ReadKey();



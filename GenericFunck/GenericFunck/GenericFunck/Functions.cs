// See https://aka.ms/new-console-template for more information
// Opgave 1

internal class Functions
{
    public  static int FindLargest(List<int> intList)
    {
        if (intList == null || intList.Count == 0)
            return 0;
        int largest = intList[0];
        foreach(int i in intList)
        {
            if (i > largest)
                largest = i;
        }
        return largest;
    }
    public static T? FindLargest<T>(List<T> list) where T : IComparable<T>
    {
        if (list == null || list.Count == 0)
            throw new ArgumentException();
        T largest = list[0];
        foreach (T i in list)
        {
            if (i.CompareTo(largest)>0)
                largest = i;
        }
        return largest;
    }
}
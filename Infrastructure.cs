public static class Infrastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max))
                .ToArray();
     }
     
    public static int[] Show(this int[] array, string separator = ",") // Можно так же добавить
    //string, чтобы затем использловать как переменную, с дефолтным разделителем вместо привычного Join
    {
        string output = string.Join(separator, array);
        Console.WriteLine($"[{output}]");
        return array;
    }
}
using Byte_Stream_Reverse.ByteReverse;

internal class Program
{
    private static void Main(string[] args)
    {
        ByteStreamReverse reverse = new ByteStreamReverse();

        byte[] bytes = { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };

        reverse.ShowArray(bytes);

        reverse.ShowArray(reverse.ReverseByte(bytes));

    }
}
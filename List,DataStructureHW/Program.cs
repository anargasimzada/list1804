using List_DataStructureHW.Moduls;

namespace List_DataStructureHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList();
            list.Add(1);
            list.GetElements();
            list.IndexOf(5);
        }
    }
}

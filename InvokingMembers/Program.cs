using System.Reflection;
namespace InvokingMembers;

internal class Program
{
    static void Main(string[] args)
    {
        Type myTestClass = typeof(MyTestClass);

        var members = myTestClass.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var item in members)
        {
            Console.WriteLine(item.Name);
        }
    }
}
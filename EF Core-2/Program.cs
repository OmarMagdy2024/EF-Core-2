using EF_Core_2.Classes;
using EF_Core_2.Connection;

namespace EF_Core_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDBContext iTIDBContext=new ITIDBContext();
            Student student=new Student() { FName="omar",LName="magdy",Age=27,Address="helwan"};
            Console.WriteLine(student.ToString());
            //iTIDBContext.Add(student);
            Topic topic=new Topic() { Name="FrontEnd"};
            iTIDBContext.Add(topic);
            iTIDBContext.SaveChanges();
            //iTIDBContext.SaveChanges();
        }
    }
}

namespace csharpintro
{
    internal class Structures
    {
        public void Go()
        {
            Console.WriteLine("go structs");

            StudentClass studentClass = new StudentClass();
            studentClass.GetId();

            StudentClass studentClass1 = studentClass;
            studentClass1.id = 908;
            studentClass.GetId();
            studentClass1.GetId();

            Console.WriteLine();

            StudentStruct studentStruct = new StudentStruct();
            studentStruct.GetId();

            StudentStruct studentStruct1 = studentStruct;
            studentStruct1.id = 78;

            studentStruct.GetId();
            studentStruct1.GetId();

            StudentClass studentClass2;
            //studentClass2.id = 123; // does not work

            StudentStruct studentStruct2;
            studentStruct2.id = 45;

            // Ex1
            // Create and use a struct that is related to your current work domain
            // Min reqs: at least two properties and at least one method

            studentClass1.Status = Status.InProgress;

            Console.WriteLine("--------------enums");
            Console.WriteLine(Status.InReview);
            Console.WriteLine((int)Status.InReview);
            Console.WriteLine(Enum.GetName(typeof(Status), 987));
        }
    }

    public enum Status
    {
        InReview = 56,
        Approved = 89,
        InProgress = 4,
        Done = 43
    }

    public class StudentClass
    {
        public int id;

        public Status Status { get; set; }

        public StudentClass()
        {
            id = 1;
        }

        public void GetId()
        {
            Console.WriteLine(id);
        }
    }

    public struct StudentStruct
    {
        public int id;

        public StudentStruct()
        {
            id = 2;
        }

        public void GetId()
        {
            Console.WriteLine(id);
        }
    }
}

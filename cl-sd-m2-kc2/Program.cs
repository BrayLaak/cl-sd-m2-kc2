using cl_sd_m2_kc2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<InheritingClass>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new InheritingClass();

            Console.WriteLine("Enter the value for name");
            myClass.name = Console.ReadLine();
            Console.WriteLine("Enter the value for description");
            myClass.description = Console.ReadLine();
            Console.WriteLine("Enter the value for type");
            myClass.type = Console.ReadLine();


            recordList.Add(myClass);
        }

        // Print out the list of records using Console.WriteLine()
        foreach (var record in recordList)
        {
            record.DisplayProperties();
        }

    }
}
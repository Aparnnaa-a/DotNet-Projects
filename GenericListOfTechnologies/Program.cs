using GenericListOfTechnologies;

List<Technologies> technology = new List<Technologies>()
    {
        new Technologies{ Name = ".NET", Vendor = "Microsoft" },
        new Technologies { Name = "Java", Vendor = "Oracle" },
        new Technologies { Name = "Python", Vendor = "Python Software Foundation" },
        new Technologies { Name = "Android", Vendor = "Google" }
    };

foreach (var tech in technology)
{
    Console.WriteLine($"Name: {tech.Name}, Vendor: {tech.Vendor}");
}

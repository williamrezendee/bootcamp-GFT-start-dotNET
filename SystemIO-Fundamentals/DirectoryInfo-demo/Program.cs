var path = @"C:\_Dev\bootcamp-GFT-start-dotNET\SystemIO-Fundamentals\Directory-And-DirectoryInfo\globo";

ReadDirectories(path);

static void ReadDirectories(string path)
{
    var directories = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);
    foreach (var dir in directories)
    {
        var dirInfo = new DirectoryInfo(dir);
        Console.WriteLine($"[Nome]:{dirInfo.Name}");
        Console.WriteLine($"[Raiz]:{dirInfo.Root}");
        if (dirInfo.Parent != null)
            Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");
        Console.WriteLine("---------------------------------");
    }
}
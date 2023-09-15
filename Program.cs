internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> dicccionario = new Dictionary<int, string>();
        Console.WriteLine("El total de el emento es: " + dicccionario.Count);
        
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");

        if(openWith.ContainsKey("txt")){
            Console.WriteLine("La clave \"txt\" esta presente");
        }
        
        try
        {
            openWith.Add("txt", "winword.exe");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Un elemento con la clave \"txt\" ya existe.");
        }

        Dictionary<string, string>.KeyCollection keyCol1 = openWith.Keys;
        foreach (string key in keyCol1){
            Console.WriteLine(key);
        }

        foreach(KeyValuePair<string, string> kvp in openWith){
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }

        Dictionary<string, string>.ValueCollection valueCol1 = openWith.Values;
        foreach (string val in valueCol1){
            Console.WriteLine(val);
        }

        if(openWith.ContainsKey("txt")){
            Console.WriteLine("La clave \"txt\" esta presente");
        }

        openWith.Remove("dib");
        /*openWith.Clear();
        Console.WriteLine("El total de el emento es: " + openWith.Count);*/
    }
}
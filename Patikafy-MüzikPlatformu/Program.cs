internal class Program
{
    public class Singer
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int DebutYear { get; set; }
        public int AlbumSales { get; set; }

        public Singer(string name, string genre, int debutYear, int albumSales)
        {
            Name = name;
            Genre = genre;
            DebutYear = debutYear;
            AlbumSales = albumSales;
        }
    }

    static void Main(string[] args)
    {
        List<Singer> singers = new List<Singer>()
        {
            new Singer("Ajda Pekkan", "Pop", 1968, 20000000),
            new Singer("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10000000),
            new Singer("Funda Arar", "Pop", 1999, 3000000),
            new Singer("Sertab Erener", "Pop", 1994, 5000000),
            new Singer("Sıla", "Pop", 2009, 3000000),
            new Singer("Serdar Ortaç", "Pop", 1994, 10000000),
            new Singer("Tarkan", "Pop", 1992, 40000000),
            new Singer("Hande Yener", "Pop", 1999, 7000000),
            new Singer("Hadise", "Pop", 2005, 5000000),
            new Singer("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10000000),
            new Singer("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2000000)
        };

        // 1. Adı 'S' ile başlayan şarkıcılar
        var singersStartingWithS = singers.Where(s => s.Name.StartsWith("S")).ToList();
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var singer in singersStartingWithS)
        {
            Console.WriteLine(singer.Name);
        }

        // 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var singersWithHighSales = singers.Where(s => s.AlbumSales > 10000000).ToList();
        Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        foreach (var singer in singersWithHighSales)
        {
            Console.WriteLine(singer.Name);
        }

        // 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
        var singersBefore2000Pop = singers
        .Where(s => s.DebutYear < 2000 && s.Genre.Contains("Pop"))
            .OrderBy(s => s.DebutYear)
            .ThenBy(s => s.Name)
            .GroupBy(s => s.DebutYear)
            .ToList();

        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar (Çıkış yıllarına göre gruplanmış):");
        foreach (var group in singersBefore2000Pop)
        {
            Console.WriteLine($"\nÇıkış Yılı: {group.Key}");
            foreach (var singer in group)
            {
                Console.WriteLine($"- {singer.Name}");
            }
        }

        // 4. En çok albüm satan şarkıcı
        var bestSellingSinger = singers.OrderByDescending(s => s.AlbumSales).First();
        Console.WriteLine($"\nEn çok albüm satan şarkıcı: {bestSellingSinger.Name} ({bestSellingSinger.AlbumSales} satış)");

        // 5. En yeni çıkış yapan ve en eski çıkış yapan şarkıcı
        var newestSinger = singers.OrderByDescending(s => s.DebutYear).First();
        var oldestSinger = singers.OrderBy(s => s.DebutYear).First();

        Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {newestSinger.Name} ({newestSinger.DebutYear})");
        Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldestSinger.Name} ({oldestSinger.DebutYear})");
    }
}
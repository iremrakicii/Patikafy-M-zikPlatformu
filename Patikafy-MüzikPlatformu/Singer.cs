namespace Patikafy_MüzikPlatformu
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
}

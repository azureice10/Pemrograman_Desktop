// collection
// array, fixed sized
/*
string[] kota = { "JKT", "BDG", "SBY" };

//int[] nums = { 1, 2, 3, 4 };
//int[] nums2 = { 1, 2, 6, 7 };

//Console.WriteLine(kota[0]);

//// loop foreach untuk collection
//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}

//kota[1] = "SMG";
//Console.WriteLine(kota[1]);

//// LINQ method
//Console.WriteLine(nums.Average());
//Console.WriteLine(nums.Sum());

//var a = nums.Union(nums2);
//var b = nums.Except(nums2);
//var c = nums.Intersect(nums2);

//foreach (int i in c) {
//    Console.Write(i);
//}

// List
List<int> numbers1 = new() { 1, 2, 5, 7, 8, 10, 10 };

List<string> strList = new();
// mengisi list dengan collection
strList.AddRange(kota);
// menambah item ke List
strList.Add("ABC");
strList.Insert(1, "XYZ");
// menghapus item dari list
strList.Remove("ABc");
strList.RemoveAt(1);
// Count = jumlah elemen dalam list
Console.WriteLine(strList.Count + " " + strList.Capacity);

foreach (string i in strList)
{
    Console.WriteLine($"{i}");
}
*/


// Class dan Object

class Buku
{
    public string Judul { get; set; } = string.Empty;
    public string Penulis { get; set; } = string.Empty;
    public decimal Harga { get; set; }
    public int Stok { get; set; }

    // constructor buku
    public Buku(string judul, string penulis, decimal harga, int stok)
    {
        Judul = judul;
        Penulis = penulis;
        Harga = harga;
        Stok = stok;
    }
}

class Program
{
    static void Main()
    {
        List<Buku> ListBuku = new()
        {
            new Buku("Book 1 Title", "bob", 1000m, 10),
            new Buku("Cooking", "Budi", 2000m, 5),
            new Buku("Book 4 Title", "Bob Budi", 3000m, 2),
            new Buku("Book 4 Title", "Test Bob", 1500m, 10)
        };
        // Mengurutkan berdasarkan judul
        ListBuku.Sort((x,y)=>x.Judul.CompareTo(y.Judul));
           foreach (var buku in ListBuku)
        {
            Console.WriteLine($"Judul: {buku.Judul}, Penulis: {buku.Penulis}");
        }
        // Pencarian
        List<Buku> MyBooks = ListBuku.Where(b => b.Penulis == "Bob").ToList();
        List<Buku> BobBooks = ListBuku.Where(b => b.Penulis.Contains("Bob")).ToList();

        foreach (var item in BobBooks)
        {
            Console.WriteLine($"Judul: {item.Judul}, Penulis: {item.Penulis}");
        }

        // Pencarian First/Last
        var Buku1 = ListBuku.FirstOrDefault(x => x.Judul == "Book Title");
        if ( Buku1 != null ) { 
        Console.WriteLine(Buku1.Judul +" "+ Buku1.Penulis);
        }

        // Any return boolean
        var valid = ListBuku.Any(x => x.Penulis.ToLower() == "bob");
        Console.WriteLine(valid);

        // Sort with orderby 
        List<Buku> sortedBooks = ListBuku.OrderBy(b => b.Harga).ToList();
        foreach (var item in sortedBooks)
        {
            Console.WriteLine($"Judul: {item.Judul}, Harga: {item.Harga}");
        }
    }
}
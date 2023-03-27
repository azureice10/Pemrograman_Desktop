/*// Console Input & Output
Console.WriteLine("Hello, World!");
Console.Write("Input Nama:");
// Readline untuk satu baris inputan
string nama = Console.ReadLine();
// Combine string dan variabel
Console.WriteLine("Selamat Datang " + nama);
// Console Read untuk membaca ascii char
int ch = Console.Read();
Console.WriteLine(ch);
// mengubah int menjadi char
Console.WriteLine((char)ch);

// Variable & data types
int umur = 20;
float nilai = 68.5f;
decimal harga = 1000.0m;
bool valid = true;
char grade = 'c';
string judul = "Pemrograman Desktop";

// tipe data generik var
var x = 10;
var y = "Test";

// string format
Console.WriteLine($"Matkul: {judul}, nilai:{nilai}, Grade: {grade}");
Console.WriteLine("{0}, {1}, {2}, {3}", umur, valid, judul, x);

// Konversi Tipe Data Implisit
long bignum;
bignum = umur;
Console.WriteLine(bignum);

// Explicit conversions
int int_nilai = (int)nilai;
Console.WriteLine(int_nilai);

string tahun = "2023";
int year = Convert.ToInt16(tahun) + 1;
string score = nilai.ToString();

Console.WriteLine(year);
Console.WriteLine(int_nilai); */

/*float UTS = 80;
if (UTS == 90 || UTS == 80)
{
    Console.WriteLine("90 atau 80");
}
else if (UTS < 60 && UTS > 50)
{
    Console.WriteLine("<60 dan > 50");
}
else
{
    Console.WriteLine("Lainnya");
}

// switch case
int Value = 50;
switch (Value)
{
    case 50:
        Console.WriteLine("The value is 50");
        break;
    case 51:
        Console.WriteLine("The value is 51");
        break;
    case 52:
    case 53:
    case 54:
        Console.WriteLine("The value is between 52 and 54");
        break;
    default:
        Console.WriteLine("The value is something else");
        break;
}

// ternary operator
Console.WriteLine(UTS < 50 ? "Dibawah 50" : "Lebih besar atau sama dengan 50");

Console.WriteLine("Input Angka: ");
int x = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(x % 2 == 1 ? "Ganjil" : "Genap");*/

/*// for loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// while loop
int j = 10;
while (j == 0);
Console.WriteLine(j);
j--;

// do-while loop
string inputStr = "";
Console.WriteLine("The do-while loop:");
do
{
    inputStr = Console.ReadLine();

    Console.WriteLine("You entered: {0}", inputStr);
} while (inputStr != "exit");
Console.WriteLine();*/

// deklarasi function
using System.Reflection.Metadata.Ecma335;

static void myFunc()
{
    Console.WriteLine("Test Function");
}

// memanggil function
myFunc();

// with parameter & return value
Console.WriteLine("Input angka:");
int num = int.Parse(Console.ReadLine());

int result = Square(num);
Console.WriteLine("Kuadrat dari {0} adalah {1}.", num, result);

// function dengan param dan return value 
static int Square(int num)
{
    return num * num;
}

// default param
static void PrintNama(string nama, string gelar_Depan = "Dr.")
{
    Console.WriteLine($"{gelar_Depan} {nama}");
}

PrintNama("Test");
PrintNama(gelar_Depan: "Mr.", nama: "Budi");
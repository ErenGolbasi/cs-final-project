int ogrenciSayisi = 0;
while (true)
{
    try
    {
        Console.Write("Öğrenci sayısını giriniz: ");
        ogrenciSayisi = int.Parse(Console.ReadLine());
        if (ogrenciSayisi > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Lütfen sıfırdan daha büyük bir sayı giriniz!!!");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayısal bir değer giriniz!!!");
    }
}

string[] isim = new string[ogrenciSayisi];
string[] soyisim = new string[ogrenciSayisi];
long[] ogrenciNumaralari = new long[ogrenciSayisi];
double[] vizeler = new double[ogrenciSayisi];
double[] finaller = new double[ogrenciSayisi];
double[] ortalamalar = new double[ogrenciSayisi];
string[] harfNotlari = new string[ogrenciSayisi];

for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine($"\n--- {i + 1}. Öğrenci Bilgileri ---");

    while (true)
    {
        try
        {
            Console.Write("Öğrenci okul numarasını giriniz: ");
            ogrenciNumaralari[i] = long.Parse(Console.ReadLine());
            if (ogrenciNumaralari[i] > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Lütfen sıfırdan daha büyük değer giriniz!!!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lütfen sayısal bir değer giriniz!!!");
        }
    }

    Console.Write("Öğrenci ismini giriniz: ");
    isim[i] = Console.ReadLine().Trim().ToUpper();

    Console.Write("Öğrenci soyismini giriniz: ");
    soyisim[i] = Console.ReadLine().Trim().ToUpper();

    while (true)
    {
        try
        {
            Console.Write("Lütfen öğrencinin vize notunu giriniz: ");
            vizeler[i] = double.Parse(Console.ReadLine());
            if (vizeler[i] >= 0 && vizeler[i] <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz!!!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lütfen sayısal bir değer giriniz!!!");
        }
    }

    while (true)
    {
        try
        {
            Console.Write("Lütfen öğrencinin final notunu giriniz: ");
            finaller[i] = double.Parse(Console.ReadLine());
            if (finaller[i] >= 0 && finaller[i] <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz!!!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lütfen sayısal bir değer giriniz!!!");
        }
    }

    ortalamalar[i] = (vizeler[i] * 0.40) + (finaller[i] * 0.60);
    if (ortalamalar[i] >= 85) harfNotlari[i] = "AA";
    else if (ortalamalar[i] >= 70) harfNotlari[i] = "BA";
    else if (ortalamalar[i] >= 60) harfNotlari[i] = "BB";
    else if (ortalamalar[i] >= 50) harfNotlari[i] = "CB";
    else if (ortalamalar[i] >= 40) harfNotlari[i] = "CC";
    else if (ortalamalar[i] >= 30) harfNotlari[i] = "DC";
    else if (ortalamalar[i] >= 20) harfNotlari[i] = "DD";
    else if (ortalamalar[i] >= 10) harfNotlari[i] = "FD";
    else harfNotlari[i] = "FF";
}

double sinifToplami = 0;
double enYuksek = 0;
double enDusuk = 100;
for (int i = 0; i < ogrenciSayisi; i++)
{
    sinifToplami += ortalamalar[i];
    if (ortalamalar[i] > enYuksek) enYuksek = ortalamalar[i];
    if (ortalamalar[i] < enDusuk) enDusuk = ortalamalar[i];
}

Console.Clear();
Console.WriteLine("======================================================================================");
Console.WriteLine("| {0,-3} | {1,-11}| {2,-12} | {3,-12} | {4,-5} | {5,-5} | {6,-8} | {7,-4} |",
    "NO", "ÖĞRENCİ NO", "İSİM", "SOYİSİM", "VİZE", "FİNAL", "ORTALAMA", "HARF");
Console.WriteLine("======================================================================================");
for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.WriteLine("| {0,-3} | {1,-11}| {2,-12} | {3,-12} | {4,-5} | {5,-5} | {6,-8} | {7,-4} |",
    i + 1,
    ogrenciNumaralari[i],
    isim[i],
    soyisim[i],
    vizeler[i],
    finaller[i],
    ortalamalar[i],
    harfNotlari[i]);
}
Console.WriteLine("======================================================================================");
Console.WriteLine("\n*** SINIF İSTATİSTİKLERİ ***");
Console.WriteLine($"Sınıf Ortalaması   : {sinifToplami / ogrenciSayisi:F2}");
Console.WriteLine($"En Yüksek Ortalama : {enYuksek:F2}");
Console.WriteLine($"En Düşük  Ortalama : {enDusuk:F2}");

Console.ReadKey();
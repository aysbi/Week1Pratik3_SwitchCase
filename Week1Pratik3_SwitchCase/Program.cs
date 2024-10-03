Console.WriteLine("Rüya manavında fiyatlar çok uygun! " +
    "\nElma = 2 TL \nArmut = 3 TL \nÇilek = 2 TL \nMuz = 3 TL \nDiğer bütün meyveler = 4 TL");

Console.WriteLine("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string? Secim = Console.ReadLine();
string Cevap = Secim.ToUpper(); // secim klasorundeki karsidan gelen cevabin tum harflerini buyuk harfe cevirdik 
                                // boylelikle statement yazarken tek bir secenegimiz oluyor

#region If/ElseIf

//if (Cevap == "ELMA")
//   Console.WriteLine("Sectiginiz meyvenin fiyati: 2TL'dir");
//else if (Cevap == "ARMUT")
//    Console.WriteLine("Sectiginiz meyvenin fiyati: 3TL'dir");
//else if (Cevap == "ÇİLEK")
//    Console.WriteLine("Sectiginiz meyvenin fiyati: 2TL'dir");
//else if (Cevap == "MUZ")
//    Console.WriteLine("Sectiginiz meyvenin fiyati: 3TL'dir");
//else (Cevap == "DİĞER")
//    Console.WriteLine("Sectiginiz meyvenin fiyati: 4TL'dir");

#endregion

#region Switch-case
switch (Cevap)
{
    case "ELMA":
        Console.WriteLine("Sectiginiz meyvenin fiyati: 2TL'dir");
        break;
    case "ARMUT":
        Console.WriteLine("Sectiginiz meyvenin fiyati: 3TL'dir");
        break;
    case "ÇİLEK":
        Console.WriteLine("Sectiginiz meyvenin fiyati: 2TL'dir");
        break;
    case "MUZ":
        Console.WriteLine("Sectiginiz meyvenin fiyati: 3TL'dir");
        break;
    default:
        Console.WriteLine("Sectiginiz meyvenin fiyati: 4TL'dir");
        break;
}
#endregion
// Bu kod yazilirken switch case daha iyi bir cozum olacaktir cunku okunabilirligi daha iyidir ve ileride 
// yeni meyveler eklenmesi daha basittir
Console.ReadKey();

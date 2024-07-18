Console.WriteLine("Rüya Manavına Hoşgeldiniz! ");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger bütün meyveler = 4 TL");


Console.Write("Hangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");

string meyve = Console.ReadLine();
//burada kullanıcıdan aldığım meyve girdisinin ilk harfini büyük harfe çeviriyorum ardından 1. indexten sonra yani 2.harften sonra kelimenin harflerini küçük harfe çeviriyorum.
meyve = char.ToUpper(meyve[0]) + meyve.Substring(1).ToLower();

// if else yapısıyla kullanıcının girdiği meyveyi kontrol ettirip ekrana fiyatını yazdırıyorum.


//if(meyve == "Muz")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyati: 3TL");
//}
//else if(meyve == "Elma")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyati: 2TL");

//}
//else if(meyve == "Armut")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyati: 3TL");

//}
//else if (meyve == "Çilek")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyati: 2TL");

//}
//else
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyati: 4 TL");
//}



// Bu örnekte switch case kullanımının daha mantıklı olduğunu düşünüyorum. Daha iyi okunabilirlik sağladığını ve temiz bir kodlama yapılabildiğini düşünüyorum.

switch (meyve)
{
    case "Muz":
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyati: 3TL");
            break;
        }
    case "Elma":
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyati: 2TL");
            break;
        }
    case "Armut":
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyati: 3TL");
            break;
        }
    case "Çilek":
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyati: 2TL");
            break;
        }
    default:
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyati: 4 TL");
            break;
        }
}
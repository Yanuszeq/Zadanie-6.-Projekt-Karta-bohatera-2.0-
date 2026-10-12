Console.WriteLine("Podaj Imię bohatera: ");
String Imie = Console.ReadLine();

Console.WriteLine("Podaj ilość miejsca w plecaku (MAX 10): ");
int Miejsce_w_plecaku = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj ilość zdrowia (MAX 100)(Tylko liczby całkowite): ");
double Zdrowie = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Podaj ilość siły : ");
int Siła = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj ilość osób w grupie : ");
int Ilosc_osob_w_grupie = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj ilość złota : ");
int Ilosc_zlota = Convert.ToInt32(Console.ReadLine()); 

double mnożnik_obrażeń = 1.5;

int Obrażenia_od_Broni = 10;

double Obrażenia_całkowite = (mnożnik_obrażeń * (Siła + Obrażenia_od_Broni));

char Symbol_na_mapie = 'X';

int złoto_na_osobę = Ilosc_zlota / Ilosc_osob_w_grupie;

double XP = 0;

Console.WriteLine("+=======================================+");
Console.WriteLine("|            KARTA BOHATERA             |");
Console.WriteLine("+=======================================+");
Console.WriteLine($"| Imię bohatera: {Imie}\t\t\t|");
Console.WriteLine($"| Symbol na mapie: {Symbol_na_mapie}\t\t\t|");
Console.WriteLine($"| Miejsce w plecaku: {Miejsce_w_plecaku}/10\t\t|");
Console.WriteLine($"| Doświadczenie: {XP}\t\t\t|");
Console.WriteLine($"| HP: {Zdrowie}\t\t\t\t|");
Console.WriteLine($"| Siła: {Siła}\t\t\t\t|");
Console.WriteLine($"| Mnożnik obrażeń: {mnożnik_obrażeń}\t\t\t|");
Console.WriteLine($"| Obrażenia od broni: {Obrażenia_od_Broni}\t\t|");
Console.WriteLine($"| Obrażenia całkowite: {Obrażenia_całkowite}\t\t|");
Console.WriteLine($"| Ilość osób w grupie: {Ilosc_osob_w_grupie}\t\t|");
Console.WriteLine($"| Ilość złota: {Ilosc_zlota}\t\t\t|");
Console.WriteLine($"| Ilość złota na osobę: {złoto_na_osobę} reszta: {Ilosc_zlota % Ilosc_osob_w_grupie}\t|");

bool mapa = true;
bool leczenie = (Zdrowie < 100) ? true : false;
bool gotowość = (Zdrowie == 100) ? true : false;
int wolne_miejsce_w_plecaku = (Miejsce_w_plecaku < 10) ? 10 - Miejsce_w_plecaku : 0;

Console.WriteLine("+=======================================+");
Console.WriteLine("|                 Info                  |");
Console.WriteLine("+=======================================+");
Console.WriteLine($"| Symbol na mapie: {mapa}\t\t\t|");
Console.WriteLine($"| Leczenie wymagane?: {leczenie}\t\t|");
Console.WriteLine($"| Gotowy do drogi?: {gotowość}\t\t|");
Console.WriteLine($"| Wolne miejsce w plecaku: {wolne_miejsce_w_plecaku}/10\t\t|");


XP += 10;
Ilosc_zlota += 3;



Console.WriteLine("+=======================================+");
Console.WriteLine("|               PO Misji                |");
Console.WriteLine("+=======================================+");
Console.WriteLine($"| Doświadczenie: {XP}\t\t\t|");
Console.WriteLine($"| Zdrowie: {Zdrowie - 7.75}\t\t\t|");
Console.WriteLine($"| Siła: {Siła + 3}\t\t\t\t|");
Console.WriteLine($"| Ilość złota: {Ilosc_zlota}\t\t\t|");
Console.WriteLine($"| Ilość złota na osobę: {złoto_na_osobę} reszta: {Ilosc_zlota % Ilosc_osob_w_grupie}\t|");
Console.WriteLine("+=======================================+");
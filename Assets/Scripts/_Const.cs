using System.Collections.Generic;
using UnityEngine;

namespace EcoGame
{
    namespace Buildings
    {
        // Klucze do BuildingManager.Buildings
        public enum BUILDINGS
        {
            B_MINE_OIL                      = 0,
            B_MINE_COAL                     = 1,
            B_MINE_GAS                      = 2,
            B_MINE_URANIUM                  = 3,
            B_MINE_PEAT                     = 4,
            B_POWERPLANT_COAL               = 5,
            B_POWERPLANT_SOLAR              = 6,
            B_POWERPLANT_WIND               = 7,
            B_POWERPLANT_WATER              = 8,
            B_POWERPLANT_NUCLEAR            = 9,
            B_POWERPLANT_BIOMASS            = 10,
            B_FOOD_PROCESSEDFOOD            = 11,
            B_FOOD_FISHING                  = 12,
            B_FOOD_ANIMALFARM               = 13,
            B_FOOD_DRINKINGWATER            = 14,
            B_FOOD_EXPERIMENTALMEAT         = 15,
            B_FOOD_FARMLAND                 = 16,
            B_TRASH_RECYCLING               = 17,
            B_TRASH_GARBAGEINCINERATOR      = 18,
            B_TRASH_GARBAGEDUMP             = 19,
            B_TRASH_COMPOSTINGPLANT         = 20,
            B_TRASH_GARBAGESHIP             = 21,
            B_GOODS_ELECTRONICSFACTORY      = 22,
            B_GOODS_CLOTHESSEWING           = 23,
            B_GOODS_CARFACTORY              = 24,
            B_POWERPLANT_GAS                = 25,
        }

        // Koszta bazowe budynk�w
        public enum BUILDINGS_BASE_COSTS
        {
            B_COST_MINE_OIL                   = 100,
            B_COST_MINE_COAL                  = 100,
            B_COST_MINE_GAS                   = 100,
            B_COST_MINE_URANIUM               = 100,
            B_COST_MINE_PEAT                  = 100,
            B_COST_POWERPLANT_COAL            = 100,
            B_COST_POWERPLANT_SOLAR           = 100,
            B_COST_POWERPLANT_WIND            = 100,
            B_COST_POWERPLANT_WATER           = 100,
            B_COST_POWERPLANT_NUCLEAR         = 100,
            B_COST_POWERPLANT_BIOMASS         = 100,
            B_COST_FOOD_PROCESSEDFOOD         = 100,
            B_COST_FOOD_FISHING               = 100,
            B_COST_FOOD_ANIMALFARM            = 100,
            B_COST_FOOD_DRINKINGWATER         = 100,
            B_COST_FOOD_EXPERIMENTALMEAT      = 100,
            B_COST_FOOD_FARMLAND              = 100,
            B_COST_TRASH_RECYCLING            = 100,
            B_COST_TRASH_GARBAGEINCINERATOR   = 100,
            B_COST_TRASH_GARBAGEDUMP          = 100,
            B_COST_TRASH_COMPOSTINGPLANT      = 100,
            B_COST_TRASH_GARBAGESHIP          = 100,
            B_COST_GOODS_ELECTRONICSFACTORY   = 100,
            B_COST_GOODS_CLOTHESSEWING        = 100,
            B_COST_GOODS_CARFACTORY           = 100,
            B_COST_POWERPLANT_GAS             = 100,
        }

        // Poziomy technologiczne budynk�w
        public enum BUILDINGS_TECH_LEVEL
        {
            B_TECH_MINE_OIL                   = 1,
            B_TECH_MINE_COAL                  = 1,
            B_TECH_MINE_GAS                   = 1,
            B_TECH_MINE_URANIUM               = 1,
            B_TECH_MINE_PEAT                  = 1,
            B_TECH_POWERPLANT_COAL            = 1,
            B_TECH_POWERPLANT_SOLAR           = 1,
            B_TECH_POWERPLANT_WIND            = 1,
            B_TECH_POWERPLANT_WATER           = 1,
            B_TECH_POWERPLANT_NUCLEAR         = 1,
            B_TECH_POWERPLANT_BIOMASS         = 1,
            B_TECH_FOOD_PROCESSEDFOOD         = 1,
            B_TECH_FOOD_FISHING               = 1,
            B_TECH_FOOD_ANIMALFARM            = 1,
            B_TECH_FOOD_DRINKINGWATER         = 1,
            B_TECH_FOOD_EXPERIMENTALMEAT      = 1,
            B_TECH_FOOD_FARMLAND              = 1,
            B_TECH_TRASH_RECYCLING            = 1,
            B_TECH_TRASH_GARBAGEINCINERATOR   = 1,
            B_TECH_TRASH_GARBAGEDUMP          = 1,
            B_TECH_TRASH_COMPOSTINGPLANT      = 1,
            B_TECH_TRASH_GARBAGESHIP          = 1,
            B_TECH_GOODS_ELECTRONICSFACTORY   = 1,
            B_TECH_GOODS_CLOTHESSEWING        = 1,
            B_TECH_GOODS_CARFACTORY           = 1,
            B_TECH_POWERPLANT_GAS             = 1,
        }
        // Bazowa produkcja budynkow
        public enum BUILDINGS_BASE_PRODUCTION
        {
            B_PROD_MINE_OIL                   = 1,
            B_PROD_MINE_COAL                  = 1,
            B_PROD_MINE_GAS                   = 1,
            B_PROD_MINE_URANIUM               = 1,
            B_PROD_MINE_PEAT                  = 1,
            B_PROD_POWERPLANT_COAL            = 1,
            B_PROD_POWERPLANT_SOLAR           = 1,
            B_PROD_POWERPLANT_WIND            = 1,
            B_PROD_POWERPLANT_WATER           = 1,
            B_PROD_POWERPLANT_NUCLEAR         = 1,
            B_PROD_POWERPLANT_BIOMASS         = 1,
            B_PROD_FOOD_PROCESSEDFOOD         = 1,
            B_PROD_FOOD_FISHING               = 1,
            B_PROD_FOOD_ANIMALFARM            = 1,
            B_PROD_FOOD_DRINKINGWATER         = 1,
            B_PROD_FOOD_EXPERIMENTALMEAT      = 1,
            B_PROD_FOOD_FARMLAND              = 1,
            B_PROD_TRASH_RECYCLING            = 1,
            B_PROD_TRASH_GARBAGEINCINERATOR   = 1,
            B_PROD_TRASH_GARBAGEDUMP          = 1,
            B_PROD_TRASH_COMPOSTINGPLANT      = 1,
            B_PROD_TRASH_GARBAGESHIP          = 1,
            B_PROD_GOODS_ELECTRONICSFACTORY   = 1,
            B_PROD_GOODS_CLOTHESSEWING        = 1,
            B_PROD_GOODS_CARFACTORY           = 1,
            B_PROD_POWERPLANT_GAS             = 1,
        }
        // Bazowe zanieczyszczenia budynkow
        public enum BUILDINGS_BASE_POLLUTION
        {
            B_POLLUTION_MINE_OIL                   = 4,
            B_POLLUTION_MINE_COAL                  = 5,
            B_POLLUTION_MINE_GAS                   = 3,
            B_POLLUTION_MINE_URANIUM               = 5,
            B_POLLUTION_MINE_PEAT                  = 2,
            B_POLLUTION_POWERPLANT_COAL            = 6,
            B_POLLUTION_POWERPLANT_SOLAR           = 0,
            B_POLLUTION_POWERPLANT_WIND            = 0,
            B_POLLUTION_POWERPLANT_WATER           = 0,
            B_POLLUTION_POWERPLANT_NUCLEAR         = 1,
            B_POLLUTION_POWERPLANT_BIOMASS         = 1,
            B_POLLUTION_FOOD_PROCESSEDFOOD         = 1,
            B_POLLUTION_FOOD_FISHING               = 1,
            B_POLLUTION_FOOD_ANIMALFARM            = 1,
            B_POLLUTION_FOOD_DRINKINGWATER         = 1,
            B_POLLUTION_FOOD_EXPERIMENTALMEAT      = 1,
            B_POLLUTION_FOOD_FARMLAND              = 1,
            B_POLLUTION_TRASH_RECYCLING            = 1,
            B_POLLUTION_TRASH_GARBAGEINCINERATOR   = 1,
            B_POLLUTION_TRASH_GARBAGEDUMP          = 1,
            B_POLLUTION_TRASH_COMPOSTINGPLANT      = 1,
            B_POLLUTION_TRASH_GARBAGESHIP          = 1,
            B_POLLUTION_GOODS_ELECTRONICSFACTORY   = 1,
            B_POLLUTION_GOODS_CLOTHESSEWING        = 1,
            B_POLLUTION_GOODS_CARFACTORY           = 1,
            B_POLLUTION_POWERPLANT_GAS             = 1,
        }
        // Bazowe uzycie surowcow przez budynek
        public enum BUILDINGS_USED_RESOURCE_AMOUNTS
        {
            B_USED_RES_AMOUNT_MINE_OIL                   = 1,
            B_USED_RES_AMOUNT_MINE_COAL                  = 1,
            B_USED_RES_AMOUNT_MINE_GAS                   = 1,
            B_USED_RES_AMOUNT_MINE_URANIUM               = 1,
            B_USED_RES_AMOUNT_MINE_PEAT                  = 1,
            B_USED_RES_AMOUNT_POWERPLANT_COAL            = 1,
            B_USED_RES_AMOUNT_POWERPLANT_SOLAR           = 1,
            B_USED_RES_AMOUNT_POWERPLANT_WIND            = 1,
            B_USED_RES_AMOUNT_POWERPLANT_WATER           = 1,
            B_USED_RES_AMOUNT_POWERPLANT_NUCLEAR         = 1,
            B_USED_RES_AMOUNT_POWERPLANT_BIOMASS         = 1,
            B_USED_RES_AMOUNT_FOOD_PROCESSEDFOOD         = 1,
            B_USED_RES_AMOUNT_FOOD_FISHING               = 1,
            B_USED_RES_AMOUNT_FOOD_ANIMALFARM            = 1,
            B_USED_RES_AMOUNT_FOOD_DRINKINGWATER         = 1,
            B_USED_RES_AMOUNT_FOOD_EXPERIMENTALMEAT      = 1,
            B_USED_RES_AMOUNT_FOOD_FARMLAND              = 1,
            B_USED_RES_AMOUNT_TRASH_RECYCLING            = 1,
            B_USED_RES_AMOUNT_TRASH_GARBAGEINCINERATOR   = 1,
            B_USED_RES_AMOUNT_TRASH_GARBAGEDUMP          = 1,
            B_USED_RES_AMOUNT_TRASH_COMPOSTINGPLANT      = 1,
            B_USED_RES_AMOUNT_TRASH_GARBAGESHIP          = 1,
            B_USED_RES_AMOUNT_GOODS_ELECTRONICSFACTORY   = 1,
            B_USED_RES_AMOUNT_GOODS_CLOTHESSEWING        = 1,
            B_USED_RES_AMOUNT_GOODS_CARFACTORY           = 1,
            B_USED_RES_AMOUNT_POWERPLANT_GAS             = 1,
        }

        // Do ustalenia jakie mno�niki DEFAULTOWE b�dziemy mie�
        public enum BUILDINGS_MULTIPLIERS
        {
            B_MULT_COST_MINE_OIL                 = 100,
            B_MULT_COST_MINE_COAL                = 100,
            B_MULT_COST_MINE_GAS                 = 100,
            B_MULT_COST_MINE_URANIUM             = 100,
            B_MULT_COST_MINE_PEAT                = 100,
            B_MULT_COST_POWERPLANT_COAL          = 100,
            B_MULT_COST_POWERPLANT_SOLAR         = 100,
            B_MULT_COST_POWERPLANT_WIND          = 100,
            B_MULT_COST_POWERPLANT_WATER         = 100,
            B_MULT_COST_POWERPLANT_NUCLEAR       = 100,
            B_MULT_COST_POWERPLANT_BIOMASS       = 100,
            B_MULT_COST_FOOD_PROCESSEDFOOD       = 100,
            B_MULT_COST_FOOD_FISHING             = 100,
            B_MULT_COST_FOOD_ANIMALFARM          = 100,
            B_MULT_COST_FOOD_DRINKINGWATER       = 100,
            B_MULT_COST_FOOD_EXPERIMENTALMEAT    = 100,
            B_MULT_COST_FOOD_FARMLAND            = 100,
            B_MULT_COST_TRASH_RECYCLING          = 100,
            B_MULT_COST_TRASH_GARBAGEINCINERATOR = 100,
            B_MULT_COST_TRASH_GARBAGEDUMP        = 100,
            B_MULT_COST_TRASH_COMPOSTINGPLANT    = 100,
            B_MULT_COST_TRASH_GARBAGESHIP        = 100,
            B_MULT_COST_GOODS_ELECTRONICSFACTORY = 100,
            B_MULT_COST_GOODS_CLOTHESSEWING      = 100,
            B_MULT_COST_GOODS_CARFACTORY         = 100,
            B_MULT_COST_POWERPLANT_GAS           = 100,

            B_MULT_PROD_MINE_OIL                 = 100,
            B_MULT_PROD_MINE_COAL                = 500,
            B_MULT_PROD_MINE_GAS                 = 100,
            B_MULT_PROD_MINE_URANIUM             = 100,
            B_MULT_PROD_MINE_PEAT                = 100,
            B_MULT_PROD_POWERPLANT_COAL          = 200,
            B_MULT_PROD_POWERPLANT_SOLAR         = 100,
            B_MULT_PROD_POWERPLANT_WIND          = 100,
            B_MULT_PROD_POWERPLANT_WATER         = 100,
            B_MULT_PROD_POWERPLANT_NUCLEAR       = 100,
            B_MULT_PROD_POWERPLANT_BIOMASS       = 100,
            B_MULT_PROD_FOOD_PROCESSEDFOOD       = 100,
            B_MULT_PROD_FOOD_FISHING             = 100,
            B_MULT_PROD_FOOD_ANIMALFARM          = 100,
            B_MULT_PROD_FOOD_DRINKINGWATER       = 100,
            B_MULT_PROD_FOOD_EXPERIMENTALMEAT    = 100,
            B_MULT_PROD_FOOD_FARMLAND            = 100,
            B_MULT_PROD_TRASH_RECYCLING          = 100,
            B_MULT_PROD_TRASH_GARBAGEINCINERATOR = 100,
            B_MULT_PROD_TRASH_GARBAGEDUMP        = 100,
            B_MULT_PROD_TRASH_COMPOSTINGPLANT    = 100,
            B_MULT_PROD_TRASH_GARBAGESHIP        = 100,
            B_MULT_PROD_GOODS_ELECTRONICSFACTORY = 100,
            B_MULT_PROD_GOODS_CLOTHESSEWING      = 100,
            B_MULT_PROD_GOODS_CARFACTORY         = 100,
            B_MULT_PROD_POWERPLANT_GAS           = 100,
        }

        public static class BUILDINGS_DESCRIPTIONS
        {
	        public static readonly string B_DESC_MINE_OIL = "Platformy wiertnicze to skomplikowane budowle/urz�dzenia s�u��ce do wykonywania odwiert�w pod dnem morza. Przez uzyskane otwory wydobywana jest ropa naftowa, gaz ziemny oraz inne surowce. Uniwersalno�� to du�y plus platform wiertniczych. Platformy mog� p�ywa� na powierzchni wody lub by� zamontowane na s�upach. Na platformie zamontowana jest wie�a wiertnicza, kt�ra za pomoc� naciskanego i obracanego przez ni� wiert�a wykonuje otw�r.";
	        public static readonly string B_DESC_MINE_COAL = "W�giel jest to pocz�tkowy i najbardziej podstawowy surowiec energetyczny. Praca w kopalni w�gla jest bardzo niebezpieczna i wymaga od pracownik�w stosowania odpowiedniego sprz�tu ochronnego oraz przestrzegania okre�lonych procedur bezpiecze�stwa, co nie pozostaje bez w p�ywu na opini� publiczn�. Kopalnie w�gla s� wa�nym �r�d�em energii na pocz�tku gry, jednak nale�y pami�ta�, �e ich dzia�alno�� ma r�wnie� negatywny wp�yw na �rodowisko naturalne, taki jak emisja dwutlenku w�gla i innych zanieczyszcze� do atmosfery oraz degradacja terenu wok� kopalni. Sam surowiec jest r�wnie� nieodnawialny i kiedy� jego z�o�a si� wyczerpi�, niemniej, s� ca�kiem �atwo dost�pne, przez co to najta�sze �r�d�o energii w grze.";
			public static readonly string B_DESC_MINE_GAS = "Gaz ziemny, b��kitne paliwo lub po prostu gaz to kolejne nieodnawialne �r�d�o energii wydobywane z wn�trza skorupy ziemskiej. Z�o�a gazu ziemnego mog� wyst�powa� niezale�nie lub towarzyszy� z�o�om ropy naftowej oraz wcze�niej wspomnianego w�gla kamiennego. Gaz ziemny wydobywa si� przez wykonywanie odwiert�w w skorupie ziemskiej, cz�sto te� pod dnem m�rz i ocean�w oraz przy odmetanowywaniu kopalni. B��kitne paliwo jest stosunkowo tanim i skutecznym surowcem energetycznym, a przy tym przyjaznym dla �rodowiska, gdy� przy jego spalaniu nie wydobywaj� si� �adne py�y, a emisja dwutlenku w�gla jest mniejsza ni� w przypadku ropy naftowej i w�gla kamiennego.";
	        public static readonly string B_DESC_MINE_URANIUM = "Kopalnie uranu to miejsca, w kt�rych wydobywana jest rud� uranu, czyli surowiec mineralny zawieraj�cy ten radioaktywny pierwiastek. Uran jest wykorzystywany jako paliwo w reaktorach j�drowych do produkcji energii elektrycznej. Mimo, �e uran jest paliwem kopalnym i kiedy� si� sko�czy, to jest on stosunkowo trwa�y, wi�c jego zasoby starcz� na du�o d�u�ej ni� zasoby w�gla, gazu ziemnego czy ropy naftowej. Wydobywanie uranu ma te� niestety par� wad. Podczas jego przetwarzania emitowane s� gazy cieplarniane, a przy niekt�rych metodach chemikalia zatruwaj�ce wody podziemne.";
			public static readonly string B_DESC_MINE_PEAT = "Kopalnie ska�y osadowej powsta�e w wyniku zachodz�cych w szczeg�lnych, wilgotnych warunkach przemian obumar�ych szcz�tk�w ro�linnych. Kolejne warstwy torfu naciskaj� na siebie co raz bardziej ograniczaj�c tlen i zwi�kszaj�c ci�nienie. Proces ten trwa nawet przez tysi�ce lat. Miejsce nagromadzenia torfu to torfowisko. Torf to najm�odszy rodzaj w�gla ze wszystkich w�gli kopalnych. Wykorzystywany jest jako materia� opa�owy, ale te� do uprawy ro�lin. Wydobycie tego surowca jest czasoch�onne i kosztowne, gdy� trzeba go osuszy� specjalistycznymi maszynami. Poza tym wydobywanie torfu wi��e si� z ingerencj� w naturalny ekosystem torfowisk oraz prowadzi do emisji gaz�w cieplarnianych do atmosfery.";
	        public static readonly string B_DESC_POWERPLANT_COAL = "Elektrownie w�glowe to budynki z instalacjami zdolnymi do wykorzystywania energii uzyskanej w wyniku spalania w�gla do produkcji energii elektrycznej. W�giel jest spalany w specjalnych kot�ach, a ciep�o, kt�re powstaje podczas tego procesu przekszta�cane jest w par� wodn�, kt�ra trafia do turbin parowych, w wyniku czego wytwarzana jest energia elektrycznych. Mimo, �e nie jest to zbyt ekologiczne �r�d�o energii, to jest ono jednym z najwa�niejszych i najpowszechniejszych na �wiecie. Spalanie w�gla w elektrowniach powoduje emisj� szkodliwych substancji do atmosfery, kt�re negatywnie wp�ywaj� na klimat i zdrowie ludzi.";
	        public static readonly string B_DESC_POWERPLANT_SOLAR = "Elektrownie solarne s� rodzajem elektrowni wykorzystuj�cych energi� s�oneczn� do wytworzenia energii elektrycznej. Elektrownie solarne mog� by� ma�ymi przydomowymi instalacjami fotowoltaicznymi lub nawet ogromnymi, wielkopowierzchniowymi farmami solarnymi sk�adaj�cymi si� z setek, a nawet tysi�cy paneli fotowoltaicznych. Du�ym plusem elektrowni s�onecznych jest brak emisji gaz�w cieplarnianych podczas produkcji energii oraz du�a niezawodno��, s� praktycznie bezobs�ugowe, przez co bardzo wygodne w u�ytkowaniu. Ich wydajno�� jednak nie jest a� tak du�a w por�wnaniu do innych rodzaj�w elektrowni.";
	        public static readonly string B_DESC_POWERPLANT_WIND = "Elektrownie wiatrowe maj� posta� farm wielkich wiatrak�w lub ma�ych przydomowych elektrowni, kt�re zamieniaj� energi� kinetyczn� wiatru na energi� mechaniczn� przekazywan� na pr�dnice wytwarzaj�ce energi� elektryczn�. Elektrownie tego typu s� uwa�ane zaraz obok wiatrowych i wodnych za najczystsze i najbardziej ekologiczne �r�d�a energii. Nie emituj� one prawie �adnych szkodliwych substancji ani do atmosfery, ani do �rodowiska. Elektrownie maj� te� par� wad. Wymagaj� du�ej przestrzeni do instalacji przy wi�kszych inwestycjach, a generowane przez nie d�wi�ki, szumy i infrad�wi�ki mog� stanowi� problem dla okolicznych mieszka�c�w obni�aj�c ich komfort �ycia.";
	        public static readonly string B_DESC_POWERPLANT_WATER = "Budowle, kt�re do produkcji energii elektrycznej wykorzystuj� p�yn�c� wod� to w�a�nie elektrownie wodne. Elektrownie wodne, podobnie jak elektrownie wiatrowe i s�oneczne s� doceniane za swoj� bardzo nisk� emisj� gaz�w cieplarnianych podczas produkcji energii. Ich budowa jednak mo�e nie�� za sob� pewne kontrowersje ze wzgl�du na znaczn� ingerencj� w �rodowisko i �ycie lokalnej spo�eczno�ci. Du�ym plusem tego rodzaju elektrowni jest prostota budowy i brak wymaga� co do skomplikowanej infrastruktury np. Ruroci�g�w. Elektrownie na biomas� s� niestety mniej wydajne ni� elektrownie w�glowe czy j�drowe. Aby wyprodukowa� tak� sam� ilo�� energii elektrycznej potrzeba o wiele wi�cej biomasy.";
	        public static readonly string B_DESC_POWERPLANT_NUCLEAR = "Elektrownie atomowe to du�e kompleksy sk�adaj�ce si� m.in. z reaktora j�drowego, generatora pary, kondensator�w i transformator�w. Energia z tego rodzaju elektrowni pochodzi z reakcji j�drowej, podczas kt�rej nast�puje rozszczepienie atom�w uranu i wytworzenia przez to ciep�a. Ca�y proces zachodzi w reaktorze, nast�pnie ciep�o z niego wykorzystywane jest do produkcji pary w generatorze, kt�ra ulatniaj�c si� w g�r� obraca turbin�. Jest to jeden z najwydajniejszych rodzaj�w elektrowni. Mo�e on pracowa� ca�� dob�, co jest jednocze�nie plusem i minusem. Zazwyczaj nieop�acalne jest regularne wygaszanie i ponowne uruchamianie reaktora, wi�c dzia�a on ca�odobowo.";
	        public static readonly string B_DESC_POWERPLANT_BIOMASS = "Elektrownie na biomas� to rodzaj elektrowni, kt�ra generuje energi� elektryczn� poprzez spalanie biologicznie rozk�adaj�cych si� organicznych odpad�w, np. Drewno, kukurydza, s�oma, specjalnie hodowane na t� okazj� odmiany ro�lin energetycznych czy odpady spo�ywcze. Ca�e spalanie odbywa si� specjalnym kotle, gdzie podgrzewana jest woda przekszta�caj�ca si� w par� wodn� poruszaj�c� turbin� parow�. Ruch turbiny sprawia, �e generowany jest pr�d elektryczny. ";
	        public static readonly string B_DESC_FOOD_PROCESSEDFOOD = "Fabryki �ywno�ci przetworzonej to miejsca, w kt�rych dzi�ki specjalnym procesom z podstawowych produkt�w spo�ywczych uzyskujemy bardziej z�o�one. To w�a�nie te �ywno�ci s� bardziej po��dane przez wi�kszo�� spo�ecze�stwa. Do ich produkcji zu�ywa si� du�o plastiku, a niekt�re procesy u�yte w fabrykach powoduj� znaczn� emisj� szkodliwych substancji do atmosfery.";
	        public static readonly string B_DESC_FOOD_FISHING = "Po��w ryb jest to dziedzina zajmuj�ca si� pozyskiwaniem stworze� �yj�cych w wi�kszych zbiornikach wodnych takich jak oceany, morza, jeziora czy rzeki. Najbardziej powszechne jest wy�awianie ryb w masowych ilo�ciach z ogromnych akwen�w (m�rz i ocean�w), w kt�rych tych zwierz�t jest najwi�cej. G��wnymi sposobami na wydobycie ich z wody to sieci rybackie, haki czy w�dki. Warto wspomnie�, �e zbyt du�e po�owy ryb mo�e spowodowa� niechciane skutki takie jak wyniszczanie ekosystemu wodnego czy zaburzanie �a�cucha pokarmowego zwierz�t. Dlatego bardzo wa�ne jest dobre zarz�dzanie sposobem i ilo�ci� wykonywanych po�ow�w. Statystyki i koszty wzrastaj� w miar� kupna kolejnych miejsc tego samego rodzaju.";
	        public static readonly string B_DESC_FOOD_ANIMALFARM = "Hodowla byd�a to dziedzina dotycz�ca zajmowania si� i rozmna�ania zwierz�t. W zale�no�ci od wybranego rodzaju zwierz�cia nale�y zapewni� mu odpowiednie warunki do �ycia. Ka�demu z nich nale�y dostarczy� wy�ywienie, schron oraz miejsce, w kt�rym b�dzie mog�o si� swobodnie wypasa�. Jednym z minus�w posiadania byd�a hodowlanego to stosunkowa spora emisja dwutlenku w�gla z ich fekali�w. Kolejnym minusem mog� by� nieprzewidziane choroby zwierz�t. Wi��� si� one z dodatkowymi kosztami i mog� powodowa� zmniejszenie liczebno�ci stada. Ponadto zwierz�ta takie jak owce, kozy czy krowy potrzebuj� du�ych teren�w do wypasania. Z drugiej strony zwierz�ta te maj� te� sporo plus�w.";
	        public static readonly string B_DESC_FOOD_DRINKINGWATER = "Uzdatnianie wody z rzek do picia to proces polegaj�cy na pozbywania si� niechcianych substancji, filtracji i dezynfekcji wody. Aby by�a ona gotowa do spo�ycia trzeba pozby� si� p�ywaj�cych w niej substancji takich jak mu� czy piasek. Opr�cz tego warto by by�o, aby nie by�o w niej szkodliwych bakterii czy wirus�w, ale r�wnie� o to, aby zawiera�a ona cenne dla cz�owieka minera�y. W zale�no�ci od u�ytych sposob�w filtracji i stopnia ska�enia wody tak d�ugi b�dzie proces jej uzdatniania.";
	        public static readonly string B_DESC_FOOD_EXPERIMENTALMEAT = "Mi�so �z prob�wki� to specjalnie wyhodowane kom�rki zwierz�t. Dzi�ki tej technologii jeste�my w stanie wyprodukowa� prawdziwe mi�so unikaj�c uboju. To rozwi�zanie pozwoli przeciwdzia�a� masowym hodowl�, kt�re nie zbaj� o warunki trzymania zwierz�t i ignoruj� ich potrzeby. Jest to nowoczesny spos�b hodowania �ywno�ci, kt�ry z pewno�ci� mo�e wywo�a� kontrowersje spo�eczne. Niekt�rzy mog� nies�usznie uwa�a�, �e takie rozwi�zanie spowoduje rozw�j chor�b czy z�y wp�yw na zdrowie ludzkie.";
	        public static readonly string B_DESC_FOOD_FARMLAND = "Pola uprawne s� to obszary ziemi przeznaczone do uprawy ro�lin i zb�. W celu uzyskania dobrych plon�w musz� by� odpowiednio piel�gnowane, nawo�one, podlewane czy spryskiwane �rodkami owadob�jczymi. Ich g��wn� zalet� jest generowanie dobrej jako�ci �ywno�ci proporcjonalnie niskimi kosztami. Jednak im bardziej wymagaj�ca ro�lina oraz im gorsze warunki zewn�trzne dla niej tym gorsze plony otrzymamy. Pola uprawne zajmuj� du�e powierzchnie z kt�rych mo�na wygenerowa� du�o �ywno�ci.";
	        public static readonly string B_DESC_TRASH_RECYCLING = "Recykling to proces poddawania odpad�w r�nego rodzaju specjalnym procesom, dzi�ki kt�rym s� one przetwarzane na materia�y i surowce, kt�re mog� by� ponownie wykorzystane. Dzia�ania te maj� na celu zmniejszenie ilo�ci odpad�w w obiegu, co prowadzi do mniejszej ilo�ci sk�adowanych odpad�w na wysypiskach i ograniczenia potrzeby wydobywania nowych surowc�w. Recyklingowi mog� by� poddane r�ne rodzaje odpad�w: papier, metal, szk�o, tworzywa sztuczne itp. Proces recyklingu zaczyna si� od segregacji i zebrania odpad�w wed�ug ich rodzaju. Nast�pnie za pomoc� r�nych proces�w mechanicznych i chemicznych zostaj� one przetworzone na surowiec lub materia� zdolny do ponownego wykorzystania. ";
	        public static readonly string B_DESC_TRASH_GARBAGEINCINERATOR = "Spalarnie �mieci to miejsce, gdzie utylizacja odpad�w odbywa si� poprzez ich spalenie. Proces spalania powoduje ca�kowite strawienie lub roz�o�enie odpad�w w prostsze zwi�zki chemiczne. Spalarnie �mieci s� dobr� alternatyw� dla wysypisk komunalnych, poniewa� znacznie redukuj� ilo�� odpad�w i zajmuj� mniej miejsca. Spalarnie mog� r�wnie� przynosi� korzy�ci ekologiczne, poniewa� wytworzona w nich energia cieplna mo�e by� wykorzystana do ogrzania budynk�w w mie�cie lub wytworzenia energii elektrycznej. Mimo tych wszystkich zalet spalarnie �mieci s� te� cz�sto krytykowane ze wzgl�du na emisj� szkodliwych substancji do powietrza, co nie do ko�ca jest prawd�, gdy� nowoczesne spalarnie wyposa�one s� w szereg filtr�w wy�apuj�cych zanieczyszczenia.";
	        public static readonly string B_DESC_TRASH_GARBAGEDUMP = "Wysypiska komunalne to miejsca sk�adowania i przetwarzania odpad�w z gospodarstw domowych, przedsi�biorstw i innych instytucji i miejsc. S� one zarz�dzane przez lokalne samorz�dy lub powo�ane w tym celu przedsi�biorstwa wyspecjalizowane w gospodarce odpadami. Wysypiska to bardzo trudne w zbudowaniu obiekty, poniewa� tw�rcom zale�y na tym, aby by�y one jak najbardziej szczelne i jak najmniej oddzia�ywa�y na �rodowisko, a jednocze�nie musz� one mie� jak najwi�ksz� powierzchni�, aby m�c je eksploatowa� przez lata. Przy wysypisku cz�sto dzia�aj� r�wnie� r�nego rodzaju instalacje, takie jak na przyk�ad sortownie. ";
	        public static readonly string B_DESC_TRASH_COMPOSTINGPLANT = "Kompostownie zielonych odpad�w to miejsca w kt�rych sk�adowane s� odpady organiczne,       z kt�rych wytworzy� mo�na kompost. Zbierane s� tam resztki jedzenia, li�cie, ga��zie, skoszona trawa itp., kt�re dzi�ki dzia�aniu mikroorganizm�w ulegaj� rozk�adowi i przeradzaj� si� w kompost. Proces kompostowania odpad�w odbywa si� przy u�yciu tlenu i wody. W rezultacie powstaje substancja zawieraj�ca wysok� ilo�� sk�adnik�w od�ywczych. S� one wykorzystywane jako naw�z do upraw rolnych i ogrodowych.";
	        public static readonly string B_DESC_TRASH_GARBAGESHIP = "temp";
	        public static readonly string B_DESC_GOODS_ELECTRONICSFACTORY = "temp";
	        public static readonly string B_DESC_GOODS_CLOTHESSEWING = "temp";
	        public static readonly string B_DESC_GOODS_CARFACTORY = "temp";
	        public static readonly string B_DESC_POWERPLANT_GAS = "temp";
        }
    }
    namespace Resources
    {
        // Klucze do ResourceManager.Resources
        public enum RESOURCES
        {

	        R_NULL = 99,
            R_COAL = 0,
            R_GAS = 1,
            R_OIL = 2,
            R_URANIUM = 3,
            R_PEAT = 4,
            R_POWER = 5,
            R_BUDGET = 6,
            R_TRASH = 7,
            R_FOOD  = 8,
            R_GOODS = 9,
            R_POLLUTION = 10,
            R_LEAF  = 11,
            R_HAPPY = 12,
            R_POLLUTION_MAXIMUM = 10000,
        }

        public enum RESOURCE_PRICES
        {
            R_PRICE_COAL = 3,
            R_PRICE_GAS = 4,
            R_PRICE_OIL = 6,
            R_PRICE_URANIUM = 20,
            R_PRICE_PEAT = 1,
            R_PRICE_POWER = 2,
            R_PRICE_FOOD = 1,
            R_PRICE_GOODS = 2,
        }
    }
    
    // Kolory dla wyswietlania zadowolenia
    public static class Colors
    {
        public static Color Good = new(0.1529412f, 0.682353f, 0.3764706f);
        public static Color Bad = new(0.9058824f, 0.2980392f, 0.2352941f);
        public static Color Medium = new(0.9529412f, 0.6117647f, 0.07058824f);
    }
    

    namespace Json
    {
        public static class JsonConsts 
        {
	        public static readonly string TECHNOLOGY_FILE_NAME = "technologies.json";
			public static readonly string EVENT_FILE_NAME       = "events.json";
            public static readonly string SAVE_FILE_NAME        = "save.json";
        }
    }
}

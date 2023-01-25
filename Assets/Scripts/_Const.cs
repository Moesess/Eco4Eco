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

        // Koszta bazowe budynków
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

        // Poziomy technologiczne budynków
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

        // Do ustalenia jakie mno¿niki DEFAULTOWE bêdziemy mieæ
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
	        public static readonly string B_DESC_MINE_OIL = "Platformy wiertnicze to skomplikowane budowle/urz¹dzenia s³u¿¹ce do wykonywania odwiertów pod dnem morza. Przez uzyskane otwory wydobywana jest ropa naftowa, gaz ziemny oraz inne surowce. Uniwersalnoœæ to du¿y plus platform wiertniczych. Platformy mog¹ p³ywaæ na powierzchni wody lub byæ zamontowane na s³upach. Na platformie zamontowana jest wie¿a wiertnicza, która za pomoc¹ naciskanego i obracanego przez ni¹ wiert³a wykonuje otwór.";
	        public static readonly string B_DESC_MINE_COAL = "Wêgiel jest to pocz¹tkowy i najbardziej podstawowy surowiec energetyczny. Praca w kopalni wêgla jest bardzo niebezpieczna i wymaga od pracowników stosowania odpowiedniego sprzêtu ochronnego oraz przestrzegania okreœlonych procedur bezpieczeñstwa, co nie pozostaje bez w p³ywu na opiniê publiczn¹. Kopalnie wêgla s¹ wa¿nym Ÿród³em energii na pocz¹tku gry, jednak nale¿y pamiêtaæ, ¿e ich dzia³alnoœæ ma równie¿ negatywny wp³yw na œrodowisko naturalne, taki jak emisja dwutlenku wêgla i innych zanieczyszczeñ do atmosfery oraz degradacja terenu wokó³ kopalni. Sam surowiec jest równie¿ nieodnawialny i kiedyœ jego z³o¿a siê wyczerpi¹, niemniej, s¹ ca³kiem ³atwo dostêpne, przez co to najtañsze Ÿród³o energii w grze.";
			public static readonly string B_DESC_MINE_GAS = "Gaz ziemny, b³êkitne paliwo lub po prostu gaz to kolejne nieodnawialne Ÿród³o energii wydobywane z wnêtrza skorupy ziemskiej. Z³o¿a gazu ziemnego mog¹ wystêpowaæ niezale¿nie lub towarzyszyæ z³o¿om ropy naftowej oraz wczeœniej wspomnianego wêgla kamiennego. Gaz ziemny wydobywa siê przez wykonywanie odwiertów w skorupie ziemskiej, czêsto te¿ pod dnem mórz i oceanów oraz przy odmetanowywaniu kopalni. B³êkitne paliwo jest stosunkowo tanim i skutecznym surowcem energetycznym, a przy tym przyjaznym dla œrodowiska, gdy¿ przy jego spalaniu nie wydobywaj¹ siê ¿adne py³y, a emisja dwutlenku wêgla jest mniejsza ni¿ w przypadku ropy naftowej i wêgla kamiennego.";
	        public static readonly string B_DESC_MINE_URANIUM = "Kopalnie uranu to miejsca, w których wydobywana jest rud¹ uranu, czyli surowiec mineralny zawieraj¹cy ten radioaktywny pierwiastek. Uran jest wykorzystywany jako paliwo w reaktorach j¹drowych do produkcji energii elektrycznej. Mimo, ¿e uran jest paliwem kopalnym i kiedyœ siê skoñczy, to jest on stosunkowo trwa³y, wiêc jego zasoby starcz¹ na du¿o d³u¿ej ni¿ zasoby wêgla, gazu ziemnego czy ropy naftowej. Wydobywanie uranu ma te¿ niestety parê wad. Podczas jego przetwarzania emitowane s¹ gazy cieplarniane, a przy niektórych metodach chemikalia zatruwaj¹ce wody podziemne.";
			public static readonly string B_DESC_MINE_PEAT = "Kopalnie ska³y osadowej powsta³e w wyniku zachodz¹cych w szczególnych, wilgotnych warunkach przemian obumar³ych szcz¹tków roœlinnych. Kolejne warstwy torfu naciskaj¹ na siebie co raz bardziej ograniczaj¹c tlen i zwiêkszaj¹c ciœnienie. Proces ten trwa nawet przez tysi¹ce lat. Miejsce nagromadzenia torfu to torfowisko. Torf to najm³odszy rodzaj wêgla ze wszystkich wêgli kopalnych. Wykorzystywany jest jako materia³ opa³owy, ale te¿ do uprawy roœlin. Wydobycie tego surowca jest czasoch³onne i kosztowne, gdy¿ trzeba go osuszyæ specjalistycznymi maszynami. Poza tym wydobywanie torfu wi¹¿e siê z ingerencj¹ w naturalny ekosystem torfowisk oraz prowadzi do emisji gazów cieplarnianych do atmosfery.";
	        public static readonly string B_DESC_POWERPLANT_COAL = "Elektrownie wêglowe to budynki z instalacjami zdolnymi do wykorzystywania energii uzyskanej w wyniku spalania wêgla do produkcji energii elektrycznej. Wêgiel jest spalany w specjalnych kot³ach, a ciep³o, które powstaje podczas tego procesu przekszta³cane jest w parê wodn¹, która trafia do turbin parowych, w wyniku czego wytwarzana jest energia elektrycznych. Mimo, ¿e nie jest to zbyt ekologiczne Ÿród³o energii, to jest ono jednym z najwa¿niejszych i najpowszechniejszych na œwiecie. Spalanie wêgla w elektrowniach powoduje emisjê szkodliwych substancji do atmosfery, które negatywnie wp³ywaj¹ na klimat i zdrowie ludzi.";
	        public static readonly string B_DESC_POWERPLANT_SOLAR = "Elektrownie solarne s¹ rodzajem elektrowni wykorzystuj¹cych energiê s³oneczn¹ do wytworzenia energii elektrycznej. Elektrownie solarne mog¹ byæ ma³ymi przydomowymi instalacjami fotowoltaicznymi lub nawet ogromnymi, wielkopowierzchniowymi farmami solarnymi sk³adaj¹cymi siê z setek, a nawet tysiêcy paneli fotowoltaicznych. Du¿ym plusem elektrowni s³onecznych jest brak emisji gazów cieplarnianych podczas produkcji energii oraz du¿a niezawodnoœæ, s¹ praktycznie bezobs³ugowe, przez co bardzo wygodne w u¿ytkowaniu. Ich wydajnoœæ jednak nie jest a¿ tak du¿a w porównaniu do innych rodzajów elektrowni.";
	        public static readonly string B_DESC_POWERPLANT_WIND = "Elektrownie wiatrowe maj¹ postaæ farm wielkich wiatraków lub ma³ych przydomowych elektrowni, które zamieniaj¹ energiê kinetyczn¹ wiatru na energiê mechaniczn¹ przekazywan¹ na pr¹dnice wytwarzaj¹ce energiê elektryczn¹. Elektrownie tego typu s¹ uwa¿ane zaraz obok wiatrowych i wodnych za najczystsze i najbardziej ekologiczne Ÿród³a energii. Nie emituj¹ one prawie ¿adnych szkodliwych substancji ani do atmosfery, ani do œrodowiska. Elektrownie maj¹ te¿ parê wad. Wymagaj¹ du¿ej przestrzeni do instalacji przy wiêkszych inwestycjach, a generowane przez nie dŸwiêki, szumy i infradŸwiêki mog¹ stanowiæ problem dla okolicznych mieszkañców obni¿aj¹c ich komfort ¿ycia.";
	        public static readonly string B_DESC_POWERPLANT_WATER = "Budowle, które do produkcji energii elektrycznej wykorzystuj¹ p³yn¹c¹ wodê to w³aœnie elektrownie wodne. Elektrownie wodne, podobnie jak elektrownie wiatrowe i s³oneczne s¹ doceniane za swoj¹ bardzo nisk¹ emisjê gazów cieplarnianych podczas produkcji energii. Ich budowa jednak mo¿e nieœæ za sob¹ pewne kontrowersje ze wzglêdu na znaczn¹ ingerencjê w œrodowisko i ¿ycie lokalnej spo³ecznoœci. Du¿ym plusem tego rodzaju elektrowni jest prostota budowy i brak wymagañ co do skomplikowanej infrastruktury np. Ruroci¹gów. Elektrownie na biomasê s¹ niestety mniej wydajne ni¿ elektrownie wêglowe czy j¹drowe. Aby wyprodukowaæ tak¹ sam¹ iloœæ energii elektrycznej potrzeba o wiele wiêcej biomasy.";
	        public static readonly string B_DESC_POWERPLANT_NUCLEAR = "Elektrownie atomowe to du¿e kompleksy sk³adaj¹ce siê m.in. z reaktora j¹drowego, generatora pary, kondensatorów i transformatorów. Energia z tego rodzaju elektrowni pochodzi z reakcji j¹drowej, podczas której nastêpuje rozszczepienie atomów uranu i wytworzenia przez to ciep³a. Ca³y proces zachodzi w reaktorze, nastêpnie ciep³o z niego wykorzystywane jest do produkcji pary w generatorze, która ulatniaj¹c siê w górê obraca turbinê. Jest to jeden z najwydajniejszych rodzajów elektrowni. Mo¿e on pracowaæ ca³¹ dobê, co jest jednoczeœnie plusem i minusem. Zazwyczaj nieop³acalne jest regularne wygaszanie i ponowne uruchamianie reaktora, wiêc dzia³a on ca³odobowo.";
	        public static readonly string B_DESC_POWERPLANT_BIOMASS = "Elektrownie na biomasê to rodzaj elektrowni, która generuje energiê elektryczn¹ poprzez spalanie biologicznie rozk³adaj¹cych siê organicznych odpadów, np. Drewno, kukurydza, s³oma, specjalnie hodowane na tê okazjê odmiany roœlin energetycznych czy odpady spo¿ywcze. Ca³e spalanie odbywa siê specjalnym kotle, gdzie podgrzewana jest woda przekszta³caj¹ca siê w parê wodn¹ poruszaj¹c¹ turbin¹ parow¹. Ruch turbiny sprawia, ¿e generowany jest pr¹d elektryczny. ";
	        public static readonly string B_DESC_FOOD_PROCESSEDFOOD = "Fabryki ¿ywnoœci przetworzonej to miejsca, w których dziêki specjalnym procesom z podstawowych produktów spo¿ywczych uzyskujemy bardziej z³o¿one. To w³aœnie te ¿ywnoœci s¹ bardziej po¿¹dane przez wiêkszoœæ spo³eczeñstwa. Do ich produkcji zu¿ywa siê du¿o plastiku, a niektóre procesy u¿yte w fabrykach powoduj¹ znaczn¹ emisjê szkodliwych substancji do atmosfery.";
	        public static readonly string B_DESC_FOOD_FISHING = "Po³ów ryb jest to dziedzina zajmuj¹ca siê pozyskiwaniem stworzeñ ¿yj¹cych w wiêkszych zbiornikach wodnych takich jak oceany, morza, jeziora czy rzeki. Najbardziej powszechne jest wy³awianie ryb w masowych iloœciach z ogromnych akwenów (mórz i oceanów), w których tych zwierz¹t jest najwiêcej. G³ównymi sposobami na wydobycie ich z wody to sieci rybackie, haki czy wêdki. Warto wspomnieæ, ¿e zbyt du¿e po³owy ryb mo¿e spowodowaæ niechciane skutki takie jak wyniszczanie ekosystemu wodnego czy zaburzanie ³añcucha pokarmowego zwierz¹t. Dlatego bardzo wa¿ne jest dobre zarz¹dzanie sposobem i iloœci¹ wykonywanych po³owów. Statystyki i koszty wzrastaj¹ w miarê kupna kolejnych miejsc tego samego rodzaju.";
	        public static readonly string B_DESC_FOOD_ANIMALFARM = "Hodowla byd³a to dziedzina dotycz¹ca zajmowania siê i rozmna¿ania zwierz¹t. W zale¿noœci od wybranego rodzaju zwierzêcia nale¿y zapewniæ mu odpowiednie warunki do ¿ycia. Ka¿demu z nich nale¿y dostarczyæ wy¿ywienie, schron oraz miejsce, w którym bêdzie mog³o siê swobodnie wypasaæ. Jednym z minusów posiadania byd³a hodowlanego to stosunkowa spora emisja dwutlenku wêgla z ich fekaliów. Kolejnym minusem mog¹ byæ nieprzewidziane choroby zwierz¹t. Wi¹¿¹ siê one z dodatkowymi kosztami i mog¹ powodowaæ zmniejszenie liczebnoœci stada. Ponadto zwierzêta takie jak owce, kozy czy krowy potrzebuj¹ du¿ych terenów do wypasania. Z drugiej strony zwierzêta te maj¹ te¿ sporo plusów.";
	        public static readonly string B_DESC_FOOD_DRINKINGWATER = "Uzdatnianie wody z rzek do picia to proces polegaj¹cy na pozbywania siê niechcianych substancji, filtracji i dezynfekcji wody. Aby by³a ona gotowa do spo¿ycia trzeba pozbyæ siê p³ywaj¹cych w niej substancji takich jak mu³ czy piasek. Oprócz tego warto by by³o, aby nie by³o w niej szkodliwych bakterii czy wirusów, ale równie¿ o to, aby zawiera³a ona cenne dla cz³owieka minera³y. W zale¿noœci od u¿ytych sposobów filtracji i stopnia ska¿enia wody tak d³ugi bêdzie proces jej uzdatniania.";
	        public static readonly string B_DESC_FOOD_EXPERIMENTALMEAT = "Miêso “z probówki” to specjalnie wyhodowane komórki zwierz¹t. Dziêki tej technologii jesteœmy w stanie wyprodukowaæ prawdziwe miêso unikaj¹c uboju. To rozwi¹zanie pozwoli przeciwdzia³aæ masowym hodowl¹, które nie zbaj¹ o warunki trzymania zwierz¹t i ignoruj¹ ich potrzeby. Jest to nowoczesny sposób hodowania ¿ywnoœci, który z pewnoœci¹ mo¿e wywo³aæ kontrowersje spo³eczne. Niektórzy mog¹ nies³usznie uwa¿aæ, ¿e takie rozwi¹zanie spowoduje rozwój chorób czy z³y wp³yw na zdrowie ludzkie.";
	        public static readonly string B_DESC_FOOD_FARMLAND = "Pola uprawne s¹ to obszary ziemi przeznaczone do uprawy roœlin i zbó¿. W celu uzyskania dobrych plonów musz¹ byæ odpowiednio pielêgnowane, nawo¿one, podlewane czy spryskiwane œrodkami owadobójczymi. Ich g³ówn¹ zalet¹ jest generowanie dobrej jakoœci ¿ywnoœci proporcjonalnie niskimi kosztami. Jednak im bardziej wymagaj¹ca roœlina oraz im gorsze warunki zewnêtrzne dla niej tym gorsze plony otrzymamy. Pola uprawne zajmuj¹ du¿e powierzchnie z których mo¿na wygenerowaæ du¿o ¿ywnoœci.";
	        public static readonly string B_DESC_TRASH_RECYCLING = "Recykling to proces poddawania odpadów ró¿nego rodzaju specjalnym procesom, dziêki którym s¹ one przetwarzane na materia³y i surowce, które mog¹ byæ ponownie wykorzystane. Dzia³ania te maj¹ na celu zmniejszenie iloœci odpadów w obiegu, co prowadzi do mniejszej iloœci sk³adowanych odpadów na wysypiskach i ograniczenia potrzeby wydobywania nowych surowców. Recyklingowi mog¹ byæ poddane ró¿ne rodzaje odpadów: papier, metal, szk³o, tworzywa sztuczne itp. Proces recyklingu zaczyna siê od segregacji i zebrania odpadów wed³ug ich rodzaju. Nastêpnie za pomoc¹ ró¿nych procesów mechanicznych i chemicznych zostaj¹ one przetworzone na surowiec lub materia³ zdolny do ponownego wykorzystania. ";
	        public static readonly string B_DESC_TRASH_GARBAGEINCINERATOR = "Spalarnie œmieci to miejsce, gdzie utylizacja odpadów odbywa siê poprzez ich spalenie. Proces spalania powoduje ca³kowite strawienie lub roz³o¿enie odpadów w prostsze zwi¹zki chemiczne. Spalarnie œmieci s¹ dobr¹ alternatyw¹ dla wysypisk komunalnych, poniewa¿ znacznie redukuj¹ iloœæ odpadów i zajmuj¹ mniej miejsca. Spalarnie mog¹ równie¿ przynosiæ korzyœci ekologiczne, poniewa¿ wytworzona w nich energia cieplna mo¿e byæ wykorzystana do ogrzania budynków w mieœcie lub wytworzenia energii elektrycznej. Mimo tych wszystkich zalet spalarnie œmieci s¹ te¿ czêsto krytykowane ze wzglêdu na emisjê szkodliwych substancji do powietrza, co nie do koñca jest prawd¹, gdy¿ nowoczesne spalarnie wyposa¿one s¹ w szereg filtrów wy³apuj¹cych zanieczyszczenia.";
	        public static readonly string B_DESC_TRASH_GARBAGEDUMP = "Wysypiska komunalne to miejsca sk³adowania i przetwarzania odpadów z gospodarstw domowych, przedsiêbiorstw i innych instytucji i miejsc. S¹ one zarz¹dzane przez lokalne samorz¹dy lub powo³ane w tym celu przedsiêbiorstwa wyspecjalizowane w gospodarce odpadami. Wysypiska to bardzo trudne w zbudowaniu obiekty, poniewa¿ twórcom zale¿y na tym, aby by³y one jak najbardziej szczelne i jak najmniej oddzia³ywa³y na œrodowisko, a jednoczeœnie musz¹ one mieæ jak najwiêksz¹ powierzchniê, aby móc je eksploatowaæ przez lata. Przy wysypisku czêsto dzia³aj¹ równie¿ ró¿nego rodzaju instalacje, takie jak na przyk³ad sortownie. ";
	        public static readonly string B_DESC_TRASH_COMPOSTINGPLANT = "Kompostownie zielonych odpadów to miejsca w których sk³adowane s¹ odpady organiczne,       z których wytworzyæ mo¿na kompost. Zbierane s¹ tam resztki jedzenia, liœcie, ga³êzie, skoszona trawa itp., które dziêki dzia³aniu mikroorganizmów ulegaj¹ rozk³adowi i przeradzaj¹ siê w kompost. Proces kompostowania odpadów odbywa siê przy u¿yciu tlenu i wody. W rezultacie powstaje substancja zawieraj¹ca wysok¹ iloœæ sk³adników od¿ywczych. S¹ one wykorzystywane jako nawóz do upraw rolnych i ogrodowych.";
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

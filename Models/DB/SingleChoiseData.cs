using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codie.Models.DB
{
    public class SingleChoiseData
    {
        public static List<SingleChoiseModel> singleData = new List<SingleChoiseModel>
{
    new SingleChoiseModel
    {
        Id = 2,
        Statement = "C# on objektorienteeritud programmeerimiskeel.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 3,
        Statement = "C# toetab automaatset mäluhaldust.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 4,
        Statement = "C#-i kood peab alati algama klassi määratlemisega.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 5,
        Statement = "Versioonil .NET Framework pole tähtsust C# koodis.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 6,
        Statement = "C# toetab struktureeritud programmeerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 7,
        Statement = "C# põhineb keelel C++.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 8,
        Statement = "C# toetab ainult Windowsi platvorme.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 9,
        Statement = "C#-is saab kasutada ka käsurea tööriistu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 10,
        Statement = "C#-i kasutamiseks on vajalik Visual Studio.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 11,
        Statement = "C# on rakendatav ainult töölauarakendustes.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 12,
        Statement = "C# toetab nii sünkroonset kui ka asünkroonset programmeerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 13,
        Statement = "C# saab kasutada koos erinevate andmebaasidega.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 14,
        Statement = "C# on avatud lähtekoodiga keel.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 15,
        Statement = "C# toetab dünaamilist tüüpi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 16,
        Statement = "C# on osa .NET platvormist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 17,
        Statement = "C# avaldise lõpus peab alati olema semikoolon.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 18,
        Statement = "Klassi nimi võib alata numbriga.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 19,
        Statement = "Veariidestused algavad märksõnaga using.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 20,
        Statement = "Muudetavate väljade väärtusi saab muuta.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 21,
        Statement = "C# kasutab sõlmitud silmuste jaoks for-loopi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 22,
        Statement = "Konstruktorid peavad alati tagastama väärtuse.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 23,
        Statement = "Verbegeneratsioon on Visual Studio omadus.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 24,
        Statement = "C# toetab mõlemaid: deklaratiivset ja imperatiivset stiili.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 25,
        Statement = "Verba \"int\" tähistab täisarvude tüüpi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 26,
        Statement = "C#-i stringitüübid on muutumatud.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 27,
        Statement = "C# toetab kahekordset täpsustusega ujukoma tüüpi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 28,
        Statement = "C#-i meetodid võivad tagastada massiive.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 29,
        Statement = "Versiooninumbrid on olulised ainult veebirakendustes.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 30,
        Statement = "C#-is kasutatakse \"return\" väärtuse tagastamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 31,
        Statement = "C# toetab staatilisi muutujaid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 32,
        Statement = "Muutuja nimi võib sisaldada tühikuid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 33,
        Statement = "Massiivi saab luua märksõnaga var.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 34,
        Statement = "C# toetab nii väärtuse- kui ka viitetüüpe.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 35,
        Statement = "Decimal on kasutatav rahaliste arvutuste jaoks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 36,
        Statement = "Verba \"bool\" tähistab täisarvu tüüpi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 37,
        Statement = "Massiivide pikkus saab muutuda pärast deklaratsiooni.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 38,
        Statement = "C# toetab tüüpi \"object\" kõigi väärtuste hoidmiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 39,
        Statement = "Kordumatu identifikaator luuakse Guid tüübi abil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 40,
        Statement = "C# võimaldab vaikimisi väärtusi tüüpidel.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 41,
        Statement = "Muutujad saavad olla nii lokaalsetes kui ka globaalsetes ulatustes.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 42,
        Statement = "Stringi väärtuseid saab muuta pärast nende loomist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 43,
        Statement = "Double tüüpi väärtused võtavad rohkem mälu kui int.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 44,
        Statement = "C#-i switch-lause toetab string tüüpi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 45,
        Statement = "Muutuja nimi võib sisaldada erimärke, nagu @.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 46,
        Statement = "C# toetab klasside ja objektide loomist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 47,
        Statement = "Abstraktsed klassid saavad sisaldada meetodite definitsioone.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 48,
        Statement = "C#-is saab klassi pärida mitmest baasiklassist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 49,
        Statement = "Konstruktorid on spetsiaalsed meetodid objektide loomiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 50,
        Statement = "Seadistajad (Setters) võimaldavad määrata omaduste väärtusi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 51,
        Statement = "Polümorfism lubab meetodeid omada sama nime, kuid erinevaid signatuure.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 52,
        Statement = "Verib omadust override saab kasutada virtuaalse meetodi asendamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 53,
        Statement = "Liidesed saavad sisaldada ainult staatilisi meetodeid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 54,
        Statement = "C# toetab sõnastikku Dictionary tüübina.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 55,
        Statement = "Virtuaalsed meetodid on kohustuslikud kõigis klassides.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 56,
        Statement = "Konstruktor võib olla ülekoormatud erinevate argumentidega.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 57,
        Statement = "Klasside ja liideste kombinatsioon võimaldab kasutada pärilust.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 58,
        Statement = "Seesmiseid klasse saab deklareerida teistes klassides.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 59,
        Statement = "Konstruktorit võib käsitsi välja kutsuda.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 60,
        Statement = "Verib static lubab meetoditel töötada ilma objekti loomata.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 61,
        Statement = "C# haldab mälu automaatselt.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 62,
        Statement = "Prügikoguja käivitub alati käsitsi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 63,
        Statement = "Verib \"GC.Collect()\" võimaldab prügikogujat käsitsi käivitada.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 64,
        Statement = "Prügikoguja eemaldab alati viidatud objektid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 65,
        Statement = "Kõik objektid C#-is luuakse hallatavas mälus.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 66,
        Statement = "C# toetab destruktorite loomist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 67,
        Statement = "Prügikogumine toimub alati protsessi alguses.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 68,
        Statement = "Verib \"Dispose()\" vabastab hallatavat mälu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 69,
        Statement = "Klass \"IDisposable\" on seotud ressursihaldusega.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 70,
        Statement = "C# toetab lõplikke meetodeid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 71,
        Statement = "Hallatava mälu jaoks pole vaja käsitsi vabanemist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 72,
        Statement = "Hallatamatud ressursid nõuavad alati käsitsi puhastamist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 73,
        Statement = "Finalizer töötab alati deterministlikult.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 74,
        Statement = "Kõik mälulekked tuvastatakse automaatselt.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 75,
        Statement = "Verib \"using\" aitab ressursse automaatselt vabastada.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 76,
        Statement = "C# toetab erandite käsitlemist märksõnadega try ja catch.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 77,
        Statement = "Finally plokk täidetakse ainult siis, kui erandit ei visata.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 78,
        Statement = "Märksõna throw võimaldab erandit visata.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 79,
        Statement = "Verib \"catch\" saab määrata mitu korda.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 80,
        Statement = "Süsteemi määratud erandid pärinevad Exception klassist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 81,
        Statement = "Verib \"finally\" kasutatakse puhastuskoodi jaoks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 82,
        Statement = "Erandid visatakse ainult siis, kui esineb runtime viga.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 83,
        Statement = "C#-is saab luua kohandatud erandeid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 84,
        Statement = "Verib \"catch(Exception e)\" püüab kõik erandid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 85,
        Statement = "Try plokk peab alati olema seotud vähemalt ühe catch plokiga.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 86,
        Statement = "Erandeid saab käsitleda rekursiivselt.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 87,
        Statement = "Verib \"throw new Exception()\" loob uue erandi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 88,
        Statement = "Verib \"catch\" saab määrata erandi tüübi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 89,
        Statement = "Verib \"try\" saab sisaldada ainult puhastuskoodi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 90,
        Statement = "Erandite käsitlemine on oluline rakenduste stabiilsuse tagamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 91,
        Statement = "C# toetab generilisi kogusid nagu List<T> ja Dictionary<TKey, TValue>.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 92,
        Statement = "Verib \"Array\" on staatilise pikkusega kogum.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 93,
        Statement = "Liides IEnumerable võimaldab kasutada foreach-tsüklit.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 94,
        Statement = "C# toetab järjekorda (Queue) ja virna (Stack) kogudena.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 95,
        Statement = "List<T> lubab duplikaate.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 96,
        Statement = "Dictionary<TKey, TValue> toetab võtme unikaalsust.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 97,
        Statement = "C#-is on HashSet kogum, mis ei luba duplikaate.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 98,
        Statement = "C# generilised kogud asuvad nimede ruumis System.Collections.Generic.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 99,
        Statement = "LinkedList võimaldab kahesuunalist liikumist elementide vahel.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 100,
        Statement = "C# massiivide pikkus saab muutuda pärast deklareerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 101,
        Statement = "ObservableCollection on kasulik andmete jälgimiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 102,
        Statement = "ConcurrentBag on mõeldud mitmelõimeliseks tööks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 103,
        Statement = "C#-is kasutatakse kogude filtreerimiseks sageli LINQ-päringuid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 104,
        Statement = "C# ei toeta massiivide sorteerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 105,
        Statement = "KeyValuePair kasutatakse võtme ja väärtuse hoidmiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 106,
        Statement = "Delegaadid võimaldavad viidata meetoditele.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 107,
        Statement = "C# toetab multicast-delegaate.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 108,
        Statement = "Verib \"Action\" on sisseehitatud delegaat.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 109,
        Statement = "Func<T> delegaat võib tagastada väärtuse.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 110,
        Statement = "Lambdaväljendid on anonüümsed meetodid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 111,
        Statement = "Sündmused põhinevad delegeeritud mehhanismil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 112,
        Statement = "C#-is on sündmuse deklareerimiseks vajalik märksõna event.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 113,
        Statement = "Lambdaväljendid võimaldavad kasutada märksõna return.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 114,
        Statement = "Delegaadid võivad viidata rohkem kui ühele meetodile.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 115,
        Statement = "Sündmused saab alati käsitsi vallandada.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 116,
        Statement = "C# toetab sündmusi ka liideste kaudu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 117,
        Statement = "Lambdaväljendid saavad sisaldada parameetreid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 118,
        Statement = "Delegaadid on tüübiturvalised.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 119,
        Statement = "C# sündmused võimaldavad mitut tellijat.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 120,
        Statement = "Func ja Action on omavahel asendatavad.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 121,
        Statement = "C# toetab töövooge FileStream ja StreamReader kaudu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 122,
        Statement = "FileStream võimaldab binäärfailidega töötamist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 123,
        Statement = "StreamReader on kasulik tekstifailide lugemiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 124,
        Statement = "C#-is saab faili kirjutada StreamWriteri abil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 125,
        Statement = "BinaryReader loeb ainult tekstifailidest.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 126,
        Statement = "File.Exists võimaldab kontrollida, kas fail eksisteerib.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 127,
        Statement = "C#-is saab faili avada mitmes režiimis (nt kirjutamiseks, lugemiseks).",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 128,
        Statement = "FileMode määrab faili avamisviisi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 129,
        Statement = "C# toetab asünkroonset failidega töötamist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 130,
        Statement = "Verib \"using\" tagab voogude automaatse sulgemise.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 131,
        Statement = "FileStream saab kasutada mälu otsese haldamise jaoks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 132,
        Statement = "C#-is ei saa kaustu luua.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 133,
        Statement = "File.AppendText lisab faili lõppu sisu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 134,
        Statement = "Tekstifailid tuleb alati käsitsi sulgeda.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 135,
        Statement = "C#-i vood saavad olla nii sünkroonsed kui ka asünkroonsed.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 136,
        Statement = "Asünkroonne programmeerimine võimaldab vältida põhivoo blokeerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 137,
        Statement = "C#-is kasutatakse märksõnu async ja await asünkroonsuseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 138,
        Statement = "Task on asünkroonsuse põhielement C#-is.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 139,
        Statement = "Async meetodid tagastavad alati Task või Task<T>.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 140,
        Statement = "C#-is saab kasutada märksõna await ilma async meetodita.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 141,
        Statement = "Async meetodid võivad sisaldada sünkroonset koodi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 142,
        Statement = "C#-is kasutatakse Task.Delay viivituste loomiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 143,
        Statement = "Verib async võimaldab rohkem kui ühte awaiti.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 144,
        Statement = "Task.Run kasutatakse raskete arvutuste teisaldamiseks taustale.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 145,
        Statement = "Asünkroonset programmeerimist kasutatakse ainult veebirakendustes.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 146,
        Statement = "Task.Wait peatab põhivoo.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 147,
        Statement = "Verib ConfigureAwait määrab await käitumise.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 148,
        Statement = "C#-is saab kasutada ValueTask kui alternatiivi Task.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 149,
        Statement = "Asünkroonsus parandab alati jõudlust.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 150,
        Statement = "Async meetodid saavad kasutada ka try-catch plokke.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 151,
        Statement = "C# toetab graafiliste kasutajaliideste loomist Windows Forms abil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 152,
        Statement = "WPF kasutab XAML-i liideste kirjeldamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 153,
        Statement = "Windows Forms on osa System.Windows nimede ruumist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 154,
        Statement = "WPF võimaldab kasutada andmesidumist (data binding).",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 155,
        Statement = "Windows Forms ei toeta sündmuste käsitlemist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 156,
        Statement = "C#-is saab luua dünaamilisi nuppe Windows Forms abil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 157,
        Statement = "WPF toetab stiile ja ressursside taaskasutust.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 158,
        Statement = "DockPanel ja Grid on WPF-i paigutuskomponendid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 159,
        Statement = "Windows Forms toetab otse XAML-i.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 160,
        Statement = "Verib \"InitializeComponent\" on WPF-i liidese algatamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 161,
        Statement = "C# toetab sündmuste vallandamist kasutajaliideses.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 162,
        Statement = "WPF-i komponendid saab paigutada hierarhiliselt.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 163,
        Statement = "Windows Forms on uuem kui WPF.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 164,
        Statement = "WPF võimaldab graafilisi efekte ja animatsioone.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 165,
        Statement = "Windows Forms rakendused ei tööta Windows platvormil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 166,
        Statement = "C# toetab ADO.NET-i andmebaaside haldamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 167,
        Statement = "Entity Framework lihtsustab objekt-relatsioonilist kaardistamist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 168,
        Statement = "SQL päringuid saab ADO.NET-is käsitsi kirjutada.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 169,
        Statement = "Entity Framework migratsioonid aitavad hallata andmebaasi struktuuri.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 170,
        Statement = "DataReader on mõeldud tulemuste ridade lugemiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 171,
        Statement = "Verib \"DbContext\" on Entity Framework-i põhiklass.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 172,
        Statement = "C#-is saab kasutada SQLite-i andmebaase.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 173,
        Statement = "Verib \"ExecuteNonQuery\" tagastab tulemuste ridu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 174,
        Statement = "C#-is saab kasutada andmebaasidega ühendusi ConnectionString-i kaudu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 175,
        Statement = "Entity Framework toetab LINQ-päringuid.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 176,
        Statement = "Transaktsioonid võimaldavad teha andmebaasi muudatused atomaarselt.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 177,
        Statement = "Entity Framework Core töötab ainult SQL Serveriga.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 178,
        Statement = "DataSet on ADO.NET-i osa.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 179,
        Statement = "LINQ-to-SQL on Entity Frameworki alternatiiv.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 180,
        Statement = "C#-is saab andmebaasi tulemused laadida anonüümsetesse objektidesse.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 181,
        Statement = "ASP.NET toetab MVC arhitektuurimustrit.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 182,
        Statement = "Kontrollerid ASP.NET-is vastutavad andmetöötluse eest.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 183,
        Statement = "View on vastutav kasutajaliidese renderdamise eest.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 184,
        Statement = "C#-is saab luua RESTful API ASP.NET abil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 185,
        Statement = "Razor on ASP.NET-i mallimootor.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 186,
        Statement = "ASP.NET Web API toetab HTTP päringuid nagu GET ja POST.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 187,
        Statement = "Middleware on ASP.NET-i torustiku osa.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 188,
        Statement = "ASP.NET toetab autentimist ja autoriseerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 189,
        Statement = "C#-is saab ASP.NET-i abil kasutada Dependency Injection.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 190,
        Statement = "ASP.NET Core on platvormist sõltumatu raamistik.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 191,
        Statement = "ASP.NET toetab staatilisi faile.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 192,
        Statement = "C#-is saab JSON-andmeid töödelda ASP.NET API kaudu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 193,
        Statement = "ASP.NET toetab ainult SQL Serveri andmebaase.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 194,
        Statement = "Verib IActionResult kasutatakse ASP.NET-i meetodite tagastamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 195,
        Statement = "ASP.NET rakendused töötavad ainult IIS-i serveris.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 196,
        Statement = "NUnit on populaarne raamistik ühiktestide jaoks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 197,
        Statement = "TDD tähendab testide kirjutamist enne koodi loomist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 198,
        Statement = "Moq on tööriist mock-objektide loomiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 199,
        Statement = "C#-is saab ühikteste kirjutada NUnit või xUnit abil.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 200,
        Statement = "TestFixture atribuut on vajalik testklassi tähistamiseks NUnit-is.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 201,
        Statement = "Assert klassi kasutatakse testide tulemuste kinnitamiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 202,
        Statement = "Verib \"SetUp\" määrab meetodi, mida kutsutakse enne iga testi.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 203,
        Statement = "Ühiktestid ei tohi sõltuda välisest andmebaasist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 204,
        Statement = "Verib \"TearDown\" kasutatakse ressurside puhastamiseks pärast teste.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 205,
        Statement = "Üks test võib kontrollida mitut funktsiooni korraga.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 206,
        Statement = "TDD parandab koodi kvaliteeti.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 207,
        Statement = "Testide nimekiri on oluline osa TDD protsessist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 208,
        Statement = "C# toetab testide automatiseerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 209,
        Statement = "TDD tähendab testide kirjutamist pärast koodi loomist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 210,
        Statement = "Testide katvuse mõõtmiseks kasutatakse tööriista coverlet.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 211,
        Statement = "C# toetab mitmelõimelist programmeerimist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 212,
        Statement = "Verib \"Thread\" kasutatakse uute lõimede loomiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 213,
        Statement = "Task on eelistatud viis paralleelseks programmeerimiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 214,
        Statement = "Parallel.For võimaldab korduvat töötlemist mitmel lõimel.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 215,
        Statement = "Lock kasutatakse ressursi jagamiseks lõimede vahel.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 216,
        Statement = "C#-is saab kasutada märksõna async mitmelõimelise töö jaoks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 217,
        Statement = "ThreadPool võimaldab hallata lõimeressursse automaatselt.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 218,
        Statement = "Task.Run kasutatakse raskete arvutuste teisaldamiseks taustale.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 219,
        Statement = "C#-is kasutatakse märksõna await lõime blokeerimiseks.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 220,
        Statement = "Verib SemaphoreSlim võimaldab piirata lõimede arvu.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 221,
        Statement = "ConcurrentDictionary võimaldab mitmelõimelist andmete haldamist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 222,
        Statement = "Verib \"Thread.Join\" peatab põhivoo, kuni lõim lõpetab töö.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 223,
        Statement = "C#-is võib lõimede prioriteeti muuta.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
    new SingleChoiseModel
    {
        Id = 224,
        Statement = "Paralleelset programmeerimist kasutatakse ainult töölauarakendustes.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": false}, {\"text\": \"Ei\", \"isCorrect\": true}]"
    },
    new SingleChoiseModel
    {
        Id = 225,
        Statement = "Verib CancellationToken võimaldab ülesannete katkestamist.",
        Options = "[{\"text\": \"Jah\", \"isCorrect\": true}, {\"text\": \"Ei\", \"isCorrect\": false}]"
    },
};
    }
}
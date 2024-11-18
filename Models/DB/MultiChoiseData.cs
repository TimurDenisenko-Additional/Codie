
using System.Collections.Generic;

namespace Codie.Models.DB
{
    public class MultiChoiseData
    {
        public static List<MultiChoiseModel> multiData = new List<MultiChoiseModel>
{
    new MultiChoiseModel
    {
        Id = 1,
        Statement = "C# on staatiliselt tüübistatud keel.",
        Options = "[{\"text\": \"Jah, see on staatiliselt tüübistatud.\", \"isCorrect\": true}, {\"text\": \"Sellel on staatilise tüübistamise omadused.\", \"isCorrect\": true}, {\"text\": \"Ei, see on dünaamiliselt tüübistatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 2,
        Statement = "C# toetab erindite käsitlemise mehhanisme.",
        Options = "[{\"text\": \"Jah, läbi try-catch plokkide.\", \"isCorrect\": true}, {\"text\": \"Erindite käsitlemine on sisseehitatud.\", \"isCorrect\": true}, {\"text\": \"Ei, see ei toeta erindeid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 3,
        Statement = "Lambda avaldised on C# funktsioon.",
        Options = "[{\"text\": \"Jah, need on toetatud.\", \"isCorrect\": true}, {\"text\": \"Lambda avaldisi saab kasutada.\", \"isCorrect\": true}, {\"text\": \"Ei, need pole saadaval.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 4,
        Statement = "C# lubab meetodite ülekoormamist.",
        Options = "[{\"text\": \"Jah, meetodeid saab üle koormata.\", \"isCorrect\": true}, {\"text\": \"Ülekoormamine on toetatud.\", \"isCorrect\": true}, {\"text\": \"Ei, ülekoormamine pole võimalik.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 5,
        Statement = "Liidesed C#-s ei saa omada vaikeimplementeerimisi.",
        Options = "[{\"text\": \"Ei, neil võivad olla vaikimisi.\", \"isCorrect\": false}, {\"text\": \"Jah, nad ei saa omada implementeerimisi.\", \"isCorrect\": true}, {\"text\": \"Liidesed on puhtalt abstraktsed.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 6,
        Statement = "C# toetab asünkroonset programmeerimist.",
        Options = "[{\"text\": \"Jah, kasutades async ja await.\", \"isCorrect\": true}, {\"text\": \"Asünkroonne kood on võimalik.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult sünkroonne kood.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 7,
        Statement = "C#-is on struktuurid viitetüübid.",
        Options = "[{\"text\": \"Ei, struktuurid on väärtustüübid.\", \"isCorrect\": true}, {\"text\": \"Need on väärtustüübid C#-s.\", \"isCorrect\": true}, {\"text\": \"Jah, need on viitetüübid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 8,
        Statement = "Generics tagavad tüübiohutuse kollektsioonides.",
        Options = "[{\"text\": \"Jah, need tagavad tüübiohutuse.\", \"isCorrect\": true}, {\"text\": \"Generics pakub tüübiohutust.\", \"isCorrect\": true}, {\"text\": \"Ei, need ei mõjuta tüübiohutust.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 9,
        Statement = "Laiendusmeetodid ei saa olla staatilised.",
        Options = "[{\"text\": \"Ei, need peavad olema staatilised.\", \"isCorrect\": false}, {\"text\": \"Jah, need ei saa olla staatilised.\", \"isCorrect\": false}, {\"text\": \"Need peavad olema määratletud staatiliste meetoditena.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 10,
        Statement = "LINQ on C# funktsioonide komplekt.",
        Options = "[{\"text\": \"Jah, see pakub päringuvõimalusi.\", \"isCorrect\": true}, {\"text\": \"LINQ võimaldab andmete pärimist.\", \"isCorrect\": true}, {\"text\": \"Ei, LINQ pole osa C#-st.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 11,
        Statement = "C# ei toeta operaatorite ülekoormamist.",
        Options = "[{\"text\": \"Ei, see toetab seda.\", \"isCorrect\": false}, {\"text\": \"Operaatorite ülekoormamine on võimalik.\", \"isCorrect\": true}, {\"text\": \"Jah, operaatoreid ei saa üle koormata.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 12,
        Statement = "Abstraktseid klasse saab C#-s instantsida.",
        Options = "[{\"text\": \"Ei, neid ei saa instantsida.\", \"isCorrect\": true}, {\"text\": \"Need on mittetäielikud ja abstraktsed.\", \"isCorrect\": true}, {\"text\": \"Jah, neid saab instantsida.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 13,
        Statement = "Delegaadid on tüübikindlad funktsiooni viidad.",
        Options = "[{\"text\": \"Jah, need on tüübikindlad.\", \"isCorrect\": true}, {\"text\": \"Delegaadid toimivad funktsiooniviitadena.\", \"isCorrect\": true}, {\"text\": \"Ei, delegaadid pole tüübikindlad.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 14,
        Statement = "C# toetab klasside mitmikpärimist.",
        Options = "[{\"text\": \"Ei, mitmikpärimine pole toetatud.\", \"isCorrect\": true}, {\"text\": \"See võimaldab mitut liidest.\", \"isCorrect\": true}, {\"text\": \"Jah, mitme klassi pärimine on lubatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 15,
        Statement = "Võtmesõna var deklareerib dünaamilise tüübi.",
        Options = "[{\"text\": \"Ei, see deklareerib kaudselt tüübitud muutuja.\", \"isCorrect\": true}, {\"text\": \"var on mõeldud kaudsele tüübistamisele.\", \"isCorrect\": true}, {\"text\": \"Jah, see deklareerib dünaamilise tüübi.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 16,
        Statement = "C# massiivid on nullipõhise indeksiga.",
        Options = "[{\"text\": \"Jah, indekseerimine algab nullist.\", \"isCorrect\": true}, {\"text\": \"Massiivid on nullipõhised.\", \"isCorrect\": true}, {\"text\": \"Ei, need algavad ühest.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 17,
        Statement = "Enumid C#-s võivad olla ainult täisarvud.",
        Options = "[{\"text\": \"Jah, need põhinevad täisarvudel.\", \"isCorrect\": true}, {\"text\": \"Enumid kasutavad täisarvu väärtusi.\", \"isCorrect\": true}, {\"text\": \"Ei, need võivad kasutada mis tahes tüüpi.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 18,
        Statement = "C# toetab tingimuslikku kompileerimist.",
        Options = "[{\"text\": \"Jah, preprotsessori direktiividega.\", \"isCorrect\": true}, {\"text\": \"Tingimuslik kompileerimine on võimalik.\", \"isCorrect\": true}, {\"text\": \"Ei, see ei toeta seda.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 19,
        Statement = "using-lausung aitab hallata ressursse.",
        Options = "[{\"text\": \"Jah, see tagab vabastamise.\", \"isCorrect\": true}, {\"text\": \"using käsitleb ressursi puhastamist.\", \"isCorrect\": true}, {\"text\": \"Ei, sellel pole ressurssidele mõju.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 20,
        Statement = "Nimeruumide konfliktid lahendatakse aliaseid kasutades.",
        Options = "[{\"text\": \"Jah, aliased võivad need lahendada.\", \"isCorrect\": true}, {\"text\": \"Aliaste kasutamine aitab vältida konflikte.\", \"isCorrect\": true}, {\"text\": \"Ei, konflikte ei saa lahendada.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 21,
        Statement = "C# omadustel võivad olla erinevad ligipääsumeetodid.",
        Options = "[{\"text\": \"Jah, get ja set võivad erineda.\", \"isCorrect\": true}, {\"text\": \"Ligipääsumeetoditel võivad olla erinevad ligipääsutasemed.\", \"isCorrect\": true}, {\"text\": \"Ei, need peavad olema samad.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 22,
        Statement = "Atribuudid C#-s pakuvad metaandmeid.",
        Options = "[{\"text\": \"Jah, need lisavad metaandmeid.\", \"isCorrect\": true}, {\"text\": \"Atribuudid on mõeldud metaandmetele.\", \"isCorrect\": true}, {\"text\": \"Ei, need ei mõjuta metaandmeid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 23,
        Statement = "C# ei toeta anonüümseid tüüpe.",
        Options = "[{\"text\": \"Ei, anonüümsed tüübid on toetatud.\", \"isCorrect\": false}, {\"text\": \"Jah, anonüümsed tüübid pole saadaval.\", \"isCorrect\": false}, {\"text\": \"Anonüümseid tüüpe saab kasutada.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 24,
        Statement = "Nullitavad tüübid C#-s tähistatakse küsimärgiga.",
        Options = "[{\"text\": \"Jah, nagu int?.\", \"isCorrect\": true}, {\"text\": \"Küsimärk tähistab nullitavust.\", \"isCorrect\": true}, {\"text\": \"Ei, neid ei tähistata nii.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 25,
        Statement = "Indeksaator võimaldab objekte indekseerida nagu massiive.",
        Options = "[{\"text\": \"Jah, indeksaatorid võimaldavad seda.\", \"isCorrect\": true}, {\"text\": \"Objektid võivad kasutada indeksaatorit.\", \"isCorrect\": true}, {\"text\": \"Ei, objekte ei saa indekseerida.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 26,
        Statement = "C#-l puudub sisseehitatud tugi regulaaravaldustele.",
        Options = "[{\"text\": \"Ei, sellel on Regex klass.\", \"isCorrect\": false}, {\"text\": \"Regex tugi on saadaval.\", \"isCorrect\": true}, {\"text\": \"Jah, sellel puudub regex tugi.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 27,
        Statement = "Dünaamilised tüübid lahendatakse kompileerimisajal.",
        Options = "[{\"text\": \"Ei, käitamisajal.\", \"isCorrect\": true}, {\"text\": \"Dünaamilised tüübid on käitusajal seotud.\", \"isCorrect\": true}, {\"text\": \"Jah, kompileerimisajal.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 28,
        Statement = "Osalised klassid võimaldavad klassi jagamist mitme faili vahel.",
        Options = "[{\"text\": \"Jah, need võimaldavad seda.\", \"isCorrect\": true}, {\"text\": \"Osalised klassid võivad ulatuda üle failide.\", \"isCorrect\": true}, {\"text\": \"Ei, klasse ei saa jagada.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 29,
        Statement = "C# sündmused on viis vaatluskava rakendamiseks.",
        Options = "[{\"text\": \"Jah, sündmused hõlbustavad seda.\", \"isCorrect\": true}, {\"text\": \"Sündmused rakendavad vaatluskava.\", \"isCorrect\": true}, {\"text\": \"Ei, sündmustel pole seost.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 30,
        Statement = "Hermeetilisi klasse saab pärida.",
        Options = "[{\"text\": \"Ei, neid ei saa pärida.\", \"isCorrect\": true}, {\"text\": \"Hermeetilised klassid takistavad pärimist.\", \"isCorrect\": true}, {\"text\": \"Jah, neid saab pärida.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 31,
        Statement = "Kaudne tüübistamine nõuab selget tüübi deklareerimist.",
        Options = "[{\"text\": \"Ei, tüübid tuletatakse.\", \"isCorrect\": true}, {\"text\": \"Kaudne tüübistamine tuletab tüübid.\", \"isCorrect\": true}, {\"text\": \"Jah, tüübid tuleb deklareerida.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 32,
        Statement = "C# ei toeta tuplesid.",
        Options = "[{\"text\": \"Ei, tuples on toetatud.\", \"isCorrect\": false}, {\"text\": \"Tuplesid saab C#-s kasutada.\", \"isCorrect\": true}, {\"text\": \"Jah, tuples pole saadaval.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 33,
        Statement = "Asünkroonsed meetodid peavad tagastama void.",
        Options = "[{\"text\": \"Ei, need võivad tagastada Task.\", \"isCorrect\": true}, {\"text\": \"Asünkroonsed meetodid tagastavad Task tüüpe.\", \"isCorrect\": true}, {\"text\": \"Jah, ainult void on lubatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 34,
        Statement = "Versioonimine pole C# koosluste puhul oluline.",
        Options = "[{\"text\": \"Ei, versioonimine on oluline.\", \"isCorrect\": true}, {\"text\": \"Kooslused omavad versioonimist.\", \"isCorrect\": true}, {\"text\": \"Jah, versioonimine on ebaoluline.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 35,
        Statement = "Destruktorid on C#-s määratletud kasutades tilde (~).",
        Options = "[{\"text\": \"Jah, tilde määratleb destruktorid.\", \"isCorrect\": true}, {\"text\": \"Destruktorid kasutavad ~ sümbolit.\", \"isCorrect\": true}, {\"text\": \"Ei, tilde ei kasutata.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 36,
        Statement = "C#-l puudub tugi bititasandi operatsioonidele.",
        Options = "[{\"text\": \"Ei, bititasandi operaatorid on olemas.\", \"isCorrect\": true}, {\"text\": \"Bititasandi operatsioonid on toetatud.\", \"isCorrect\": true}, {\"text\": \"Jah, need pole toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 37,
        Statement = "Switch-laused C#-s võivad kasutada stringi väärtusi.",
        Options = "[{\"text\": \"Jah, stringid on lubatud.\", \"isCorrect\": true}, {\"text\": \"Switch saab käsitleda stringe.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult numbrilised tüübid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 38,
        Statement = "C# toetab meetodite ülekirjutamist.",
        Options = "[{\"text\": \"Jah, virtual ja override abil.\", \"isCorrect\": true}, {\"text\": \"Meetodite ülekirjutamine on toetatud.\", \"isCorrect\": true}, {\"text\": \"Ei, meetodeid ei saa ülekirjutada.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 39,
        Statement = "Omadustel ei saa olla loogikat ligipääsumeetodites.",
        Options = "[{\"text\": \"Ei, neil võib olla loogikat.\", \"isCorrect\": true}, {\"text\": \"Ligipääsumeetodid võivad sisaldada koodi.\", \"isCorrect\": true}, {\"text\": \"Jah, ligipääsumeetodid on loogikavabad.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 40,
        Statement = "C# lubab liideste eksplicitset implementeerimist.",
        Options = "[{\"text\": \"Jah, liideseid saab eksplicitset implementeerida.\", \"isCorrect\": true}, {\"text\": \"Eksplicitne implementeerimine on võimalik.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult kaudne implementeerimine.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 41,
        Statement = "Kovariantsus ja kontravariantsus pole C#-s toetatud.",
        Options = "[{\"text\": \"Ei, need on toetatud.\", \"isCorrect\": true}, {\"text\": \"Kovariantsus on saadaval.\", \"isCorrect\": true}, {\"text\": \"Jah, need pole toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 42,
        Statement = "C# sündmuste käitlejad peavad tagastama väärtuse.",
        Options = "[{\"text\": \"Ei, need tagastavad void.\", \"isCorrect\": true}, {\"text\": \"Sündmuste käitlejad ei tagasta väärtusi.\", \"isCorrect\": true}, {\"text\": \"Jah, need peavad tagastama väärtuse.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 43,
        Statement = "Deklareeri konstant kasutades võtmesõna const C#-s.",
        Options = "[{\"text\": \"Jah, const deklareerib konstandid.\", \"isCorrect\": true}, {\"text\": \"Konstandid kasutavad const võtmesõna.\", \"isCorrect\": true}, {\"text\": \"Ei, const ei kasutata.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 44,
        Statement = "C# toetab nimelisi ja valikulisi argumente.",
        Options = "[{\"text\": \"Jah, mõlemad on toetatud.\", \"isCorrect\": true}, {\"text\": \"Nimelised ja valikulised argumendid on olemas.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult positsioonilised argumendid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 45,
        Statement = "Dünaamiline võtmesõna C#-s keelab kompileerimisaja tüübikontrolli.",
        Options = "[{\"text\": \"Jah, tüübikontroll toimub käitamisajal.\", \"isCorrect\": true}, {\"text\": \"Dünaamilised tüübid kontrollitakse käitamisajal.\", \"isCorrect\": true}, {\"text\": \"Ei, tüübikontroll jääb kompileerimisajale.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 46,
        Statement = "C# ei toeta mitmemõõtmelisi massiive.",
        Options = "[{\"text\": \"Ei, see toetab neid.\", \"isCorrect\": false}, {\"text\": \"Mitmemõõtmelised massiivid on saadaval.\", \"isCorrect\": true}, {\"text\": \"Jah, ainult ühemõõtmelised.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 47,
        Statement = "lock-lauset kasutatakse lõime sünkroonimiseks.",
        Options = "[{\"text\": \"Jah, see sünkroonib lõime.\", \"isCorrect\": true}, {\"text\": \"lock tagab lõimede turvalisuse.\", \"isCorrect\": true}, {\"text\": \"Ei, seda ei kasutata sünkroonimiseks.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 48,
        Statement = "C# toetab preprotsessori direktiive.",
        Options = "[{\"text\": \"Jah, direktiivid on toetatud.\", \"isCorrect\": true}, {\"text\": \"Preprotsessori direktiivid on olemas.\", \"isCorrect\": true}, {\"text\": \"Ei, need pole toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 49,
        Statement = "Massiivid C#-s on viitetüübid.",
        Options = "[{\"text\": \"Jah, need on viitetüübid.\", \"isCorrect\": true}, {\"text\": \"Massiivid on viitetüübid.\", \"isCorrect\": true}, {\"text\": \"Ei, need on väärtustüübid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 50,
        Statement = "C#-l puudub sisseehitatud tugi XML dokumentatsioonile.",
        Options = "[{\"text\": \"Ei, XML dokumendid on toetatud.\", \"isCorrect\": false}, {\"text\": \"Jah, sellel puudub XML dokumentatsioon.\", \"isCorrect\": false}, {\"text\": \"XML dokumentatsioon on sisseehitatud.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 51,
        Statement = "Indeksaatori deklareerimisel kasutatakse võtmesõna this.",
        Options = "[{\"text\": \"Jah, this on kasutusel.\", \"isCorrect\": true}, {\"text\": \"this määratleb indeksaatorid.\", \"isCorrect\": true}, {\"text\": \"Ei, this ei kasutata.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 52,
        Statement = "C# ei saa suhelda haldamata koodiga.",
        Options = "[{\"text\": \"Ei, see saab PInvoke kaudu.\", \"isCorrect\": true}, {\"text\": \"Liidestamine on võimalik.\", \"isCorrect\": true}, {\"text\": \"Jah, haldamata kood on ligipääsmatu.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 53,
        Statement = "Objekti initsialiseerijad võimaldavad seadistada omadusi loomisel.",
        Options = "[{\"text\": \"Jah, need võimaldavad seda.\", \"isCorrect\": true}, {\"text\": \"Omadusi saab seada initsialiseerimisel.\", \"isCorrect\": true}, {\"text\": \"Ei, omadused tuleb seada hiljem.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 54,
        Statement = "C# ei toeta operaatorite ülekirjutamist.",
        Options = "[{\"text\": \"Ei, operaatoreid saab üle kirjutada.\", \"isCorrect\": false}, {\"text\": \"Jah, operaatorite ülekirjutamine pole toetatud.\", \"isCorrect\": false}, {\"text\": \"Operaatorite ülekirjutamine on võimalik.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 55,
        Statement = "Sündmused C#-s deklareeritakse kasutades võtmesõna event.",
        Options = "[{\"text\": \"Jah, event deklareerib sündmused.\", \"isCorrect\": true}, {\"text\": \"event võtmesõna on kasutusel.\", \"isCorrect\": true}, {\"text\": \"Ei, kasutatakse teist võtmesõna.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 56,
        Statement = "C# meetodeid ei saa üle koormata tagastustüübi alusel.",
        Options = "[{\"text\": \"Jah, ülekoormamine nõuab erinevaid parameetreid.\", \"isCorrect\": true}, {\"text\": \"Ainult tagastustüüp ei ole piisav.\", \"isCorrect\": true}, {\"text\": \"Ei, tagastustüübi ülekoormamine on lubatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 57,
        Statement = "Ohtlik kood pole C#-s lubatud.",
        Options = "[{\"text\": \"Ei, ohtlik kood on lubatud.\", \"isCorrect\": false}, {\"text\": \"Jah, ainult turvaline kood on lubatud.\", \"isCorrect\": false}, {\"text\": \"Ohtlikku koodi saab kasutada koos unsafe.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 58,
        Statement = "C# kasutab mäluhalduseks prügikogumist.",
        Options = "[{\"text\": \"Jah, GC haldab mälu.\", \"isCorrect\": true}, {\"text\": \"Prügikogumine on automaatne.\", \"isCorrect\": true}, {\"text\": \"Ei, käsitsi mäluhaldus on vajalik.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 59,
        Statement = "Indeksaatoreid saab C#-s üle koormata.",
        Options = "[{\"text\": \"Jah, muutes parameetreid.\", \"isCorrect\": true}, {\"text\": \"Indeksaatorite ülekoormamine on võimalik.\", \"isCorrect\": true}, {\"text\": \"Ei, indeksaatorit ei saa üle koormata.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 60,
        Statement = "C# ei luba pesastatud klasse.",
        Options = "[{\"text\": \"Ei, pesastatud klassid on lubatud.\", \"isCorrect\": false}, {\"text\": \"Jah, pesastamine pole lubatud.\", \"isCorrect\": false}, {\"text\": \"Pesastatud klasse saab luua.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 61,
        Statement = "Võtmesõna readonly teeb muutujad muutuvaks.",
        Options = "[{\"text\": \"Ei, see teeb need muutumatuks.\", \"isCorrect\": true}, {\"text\": \"readonly takistab muutmist.\", \"isCorrect\": true}, {\"text\": \"Jah, see lubab muutmist.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 62,
        Statement = "C# switch-laused nõuavad break pärast iga case-i.",
        Options = "[{\"text\": \"Jah, et vältida läbivoolu.\", \"isCorrect\": true}, {\"text\": \"break on vajalik iga casei järel.\", \"isCorrect\": true}, {\"text\": \"Ei, break on valikuline.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 63,
        Statement = "Muutujad C#-s tuleb initsialiseerida enne kasutamist.",
        Options = "[{\"text\": \"Jah, initsialiseerimata kasutamine on ebaseaduslik.\", \"isCorrect\": true}, {\"text\": \"Muutujad tuleb määrata.\", \"isCorrect\": true}, {\"text\": \"Ei, vaikimisi väärtused eeldatakse.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 64,
        Statement = "C# ei toeta operaatorite prioriteetsust.",
        Options = "[{\"text\": \"Ei, operaatorite prioriteetsus on olemas.\", \"isCorrect\": true}, {\"text\": \"Jah, kõigil operaatoritel on võrdne prioriteet.\", \"isCorrect\": false}, {\"text\": \"Operaatorite prioriteetsus on määratletud.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 65,
        Statement = "Meetodi määratlemine virtual-na lubab ülekirjutamist.",
        Options = "[{\"text\": \"Jah, see võimaldab ülekirjutamist.\", \"isCorrect\": true}, {\"text\": \"virtual meetodeid saab üle kirjutada.\", \"isCorrect\": true}, {\"text\": \"Ei, virtual-l pole mõju.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 66,
        Statement = "Nullitavaid väärtustüüpe C#-s ei saa võrrelda nulliga.",
        Options = "[{\"text\": \"Ei, neid saab võrrelda.\", \"isCorrect\": true}, {\"text\": \"Jah, võrdlus pole lubatud.\", \"isCorrect\": false}, {\"text\": \"Nullitavad tüübid saavad kontrollida nulli.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 67,
        Statement = "Struktuurid C#-s võivad pärida klassidest.",
        Options = "[{\"text\": \"Ei, struktuurid ei saa pärida klasse.\", \"isCorrect\": true}, {\"text\": \"Struktuurid ei toeta pärimist.\", \"isCorrect\": true}, {\"text\": \"Jah, nad saavad pärida klasse.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 68,
        Statement = "C# foreach tsüklid saavad iteratsiooni teha mis tahes kollektsioonis.",
        Options = "[{\"text\": \"Jah, kui see implementeerib IEnumerable.\", \"isCorrect\": true}, {\"text\": \"Kollektsioonid, mis implementeerivad IEnumerable.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult massiivid on toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 69,
        Statement = "Võtmesõna base viitab tuletatud klassile.",
        Options = "[{\"text\": \"Ei, see viitab baasklassile.\", \"isCorrect\": true}, {\"text\": \"base pääseb ligi baasklassi liikmetele.\", \"isCorrect\": true}, {\"text\": \"Jah, see viitab tuletatud klassile.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 70,
        Statement = "C# lubab mitu catch plokki try lause jaoks.",
        Options = "[{\"text\": \"Jah, mitu catchi on lubatud.\", \"isCorrect\": true}, {\"text\": \"Catch plokke võib olla mitu.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult üks catch plokk.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 71,
        Statement = "Atribuudid C#-s pole käitamisajal ligipääsetavad.",
        Options = "[{\"text\": \"Ei, need on ligipääsetavad läbi refleksiooni.\", \"isCorrect\": true}, {\"text\": \"Atribuudid on ligipääsetavad.\", \"isCorrect\": true}, {\"text\": \"Jah, need on ainult kompileerimisajal.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 72,
        Statement = "C#-s võtmesõna ref edastab argumendid väärtusena.",
        Options = "[{\"text\": \"Ei, see edastab viitena.\", \"isCorrect\": true}, {\"text\": \"ref edastab viitena.\", \"isCorrect\": true}, {\"text\": \"Jah, see edastab väärtusena.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 73,
        Statement = "C# toetab meetodite peitmist kasutades võtmesõna new.",
        Options = "[{\"text\": \"Jah, new peidab meetodid.\", \"isCorrect\": true}, {\"text\": \"Meetodite peitmine on võimalik.\", \"isCorrect\": true}, {\"text\": \"Ei, meetodeid ei saa peita.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 74,
        Statement = "Staatilised konstruktorid C#-s võivad võtta parameetreid.",
        Options = "[{\"text\": \"Ei, need ei saa võtta parameetreid.\", \"isCorrect\": true}, {\"text\": \"Staatilistel konstruktoritel pole parameetreid.\", \"isCorrect\": true}, {\"text\": \"Jah, parameetrid on lubatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 75,
        Statement = "C# liidesed võivad sisaldada välju.",
        Options = "[{\"text\": \"Ei, need ei saa sisaldada välju.\", \"isCorrect\": true}, {\"text\": \"Liidestel on ainult meetodid.\", \"isCorrect\": true}, {\"text\": \"Jah, väljad on lubatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 76,
        Statement = "Võtmesõna params võimaldab muutuvat arvu argumente.",
        Options = "[{\"text\": \"Jah, see võimaldab seda.\", \"isCorrect\": true}, {\"text\": \"params aktsepteerib mitut argumenti.\", \"isCorrect\": true}, {\"text\": \"Ei, argumentide arv peab olema fikseeritud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 77,
        Statement = "C# ei toeta anonüümseid meetodeid.",
        Options = "[{\"text\": \"Ei, anonüümsed meetodid on toetatud.\", \"isCorrect\": false}, {\"text\": \"Anonüümseid meetodeid saab kasutada.\", \"isCorrect\": true}, {\"text\": \"Jah, need pole toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 78,
        Statement = "finally plokk on valikuline try-catch lauses.",
        Options = "[{\"text\": \"Jah, see on valikuline.\", \"isCorrect\": true}, {\"text\": \"finally võib olla välja jäetud.\", \"isCorrect\": true}, {\"text\": \"Ei, see peab olema kaasatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 79,
        Statement = "C# toetab tingimuslikku operaatorit ?.",
        Options = "[{\"text\": \"Jah, ternaarne operaator.\", \"isCorrect\": true}, {\"text\": \"Tingimuslik operaator on saadaval.\", \"isCorrect\": true}, {\"text\": \"Ei, see ei toeta seda.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 80,
        Statement = "Väärtustüübid C#-s paigutatakse heap-i.",
        Options = "[{\"text\": \"Ei, need on stack-il.\", \"isCorrect\": true}, {\"text\": \"Väärtustüübid paigutatakse stack-i.\", \"isCorrect\": true}, {\"text\": \"Jah, need on heap-il.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 81,
        Statement = "C# massiivid ei saa olla sakilised (massiivide massiivid).",
        Options = "[{\"text\": \"Ei, sakilised massiivid on toetatud.\", \"isCorrect\": false}, {\"text\": \"Jah, ainult ristkülikukujulised massiivid.\", \"isCorrect\": false}, {\"text\": \"Sakilisi massiive saab kasutada.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 82,
        Statement = "Laused C#-s peavad lõppema semikooloniga.",
        Options = "[{\"text\": \"Jah, semikoolonid on nõutavad.\", \"isCorrect\": true}, {\"text\": \"Lause lõppeb ;.\", \"isCorrect\": true}, {\"text\": \"Ei, semikoolonid on valikulised.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 83,
        Statement = "C# ei toeta main meetodi ülekoormamist.",
        Options = "[{\"text\": \"Ei, maini saab üle koormata.\", \"isCorrect\": false}, {\"text\": \"Jah, ülekoormamine pole toetatud.\", \"isCorrect\": false}, {\"text\": \"Main meetodit saab üle koormata.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 84,
        Statement = "Indeksaatori omadused võivad C#-s olla staatilised.",
        Options = "[{\"text\": \"Ei, indeksaatorid ei saa olla staatilised.\", \"isCorrect\": true}, {\"text\": \"Indeksaatorid peavad olema eksemplari liikmed.\", \"isCorrect\": true}, {\"text\": \"Jah, need võivad olla staatilised.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 85,
        Statement = "C# toetab nii checked kui ka unchecked kontekste.",
        Options = "[{\"text\": \"Jah, aritmeetilise ületäitumise jaoks.\", \"isCorrect\": true}, {\"text\": \"Checked kontekstid on saadaval.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult unchecked on toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 86,
        Statement = "Võtmesõna default ei saa kasutada switch lausetes.",
        Options = "[{\"text\": \"Ei, seda kasutatakse vaikejuhu jaoks.\", \"isCorrect\": true}, {\"text\": \"default määratleb vaikejuhu.\", \"isCorrect\": true}, {\"text\": \"Jah, seda ei saa kasutada.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 87,
        Statement = "C# using direktiiv on mõeldud ressursside haldamiseks.",
        Options = "[{\"text\": \"Ei, see on using lause.\", \"isCorrect\": true}, {\"text\": \"using direktiiv lisab nimeruume.\", \"isCorrect\": true}, {\"text\": \"Jah, see haldab ressursse.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 88,
        Statement = "Liidesed C#-s võivad pärida mitmest liidesest.",
        Options = "[{\"text\": \"Jah, mitmikpärimine on lubatud.\", \"isCorrect\": true}, {\"text\": \"Liidesed võivad pärida mitmest.\", \"isCorrect\": true}, {\"text\": \"Ei, ainult üksik pärimine.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 89,
        Statement = "C# ei toeta valikulisi parameetreid meetodites.",
        Options = "[{\"text\": \"Ei, valikulised parameetrid on toetatud.\", \"isCorrect\": false}, {\"text\": \"Jah, kõik parameetrid on nõutud.\", \"isCorrect\": false}, {\"text\": \"Valikulisi parameetreid saab kasutada.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 90,
        Statement = "Struktuurid C#-s võivad omada konstruktorit.",
        Options = "[{\"text\": \"Jah, parameetriseeritud konstruktorid.\", \"isCorrect\": true}, {\"text\": \"Struktuurid võivad määratleda konstruktoreid.\", \"isCorrect\": true}, {\"text\": \"Ei, struktuuridel ei saa olla konstruktorit.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 91,
        Statement = "Võtmesõna typeof tagastab tüübi käitamisajal.",
        Options = "[{\"text\": \"Jah, see saab tüübi.\", \"isCorrect\": true}, {\"text\": \"typeof hangib tüübiteabe.\", \"isCorrect\": true}, {\"text\": \"Ei, see tagastab väärtuse kompileerimisajal.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 92,
        Statement = "C# lubab parameetrite edastamist viitena kasutades out.",
        Options = "[{\"text\": \"Jah, out edastab viitena.\", \"isCorrect\": true}, {\"text\": \"out parameetrid on viited.\", \"isCorrect\": true}, {\"text\": \"Ei, out edastab väärtusena.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 93,
        Statement = "Delegaadid C#-s ei saa olla multisaate.",
        Options = "[{\"text\": \"Ei, need võivad olla multisaate.\", \"isCorrect\": false}, {\"text\": \"Jah, ainult üksikud meetodid.\", \"isCorrect\": false}, {\"text\": \"Delegaadid võivad viidata mitmele meetodile.\", \"isCorrect\": true}]"
    },
    new MultiChoiseModel
    {
        Id = 94,
        Statement = "C#-l puuduvad pointer tüübid.",
        Options = "[{\"text\": \"Ei, pointreid saab kasutada unsafe sees.\", \"isCorrect\": true}, {\"text\": \"Pointreid on olemas unsafe koodis.\", \"isCorrect\": true}, {\"text\": \"Jah, pointreid pole saadaval.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 95,
        Statement = "Kooslused .NET-is on rakenduste ehituskivid.",
        Options = "[{\"text\": \"Jah, need on ehituskivid.\", \"isCorrect\": true}, {\"text\": \"Kooslused moodustavad rakendusi.\", \"isCorrect\": true}, {\"text\": \"Ei, need pole ehituskivid.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 96,
        Statement = "C#-s int ja System.Int32 on erinevad tüübid.",
        Options = "[{\"text\": \"Ei, need on samad.\", \"isCorrect\": true}, {\"text\": \"int on alias Int32-le.\", \"isCorrect\": true}, {\"text\": \"Jah, need on erinevad.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 97,
        Statement = "C# toetab destruktureerivaid omistamisi.",
        Options = "[{\"text\": \"Jah, läbi tuplide.\", \"isCorrect\": true}, {\"text\": \"Destruktureerimine on toetatud.\", \"isCorrect\": true}, {\"text\": \"Ei, destruktureerimine pole toetatud.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 98,
        Statement = "continue lause jätab vahele praeguse iteratsiooni.",
        Options = "[{\"text\": \"Jah, see jätkab tsüklit.\", \"isCorrect\": true}, {\"text\": \"continue hüppab järgmisele iteratsioonile.\", \"isCorrect\": true}, {\"text\": \"Ei, see väljub tsüklist.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 99,
        Statement = "C# do-while tsüklid täidetakse vähemalt korra.",
        Options = "[{\"text\": \"Jah, need täidetakse vähemalt korra.\", \"isCorrect\": true}, {\"text\": \"do-while töötab vähemalt korra.\", \"isCorrect\": true}, {\"text\": \"Ei, need ei pruugi täituda.\", \"isCorrect\": false}]"
    },
    new MultiChoiseModel
    {
        Id = 100,
        Statement = "Laiendusmeetodid peavad olema määratletud mittepesa-, mittelineaarsetes staatilistes klassides.",
        Options = "[{\"text\": \"Jah, see on nõue.\", \"isCorrect\": true}, {\"text\": \"Need peavad olema staatilistes klassides.\", \"isCorrect\": true}, {\"text\": \"Ei, need võivad olla kõikjal.\", \"isCorrect\": false}]"
    },
};
    }
}
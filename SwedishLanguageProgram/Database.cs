using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class Database
    {
        public string? GetWordList(string chapterName)
        {
            switch (chapterName)
            {
                case "1":
                    return """
                        1. anledning
                        2. anmäla
                        3. avlägsen
                        4. avstånd
                        5. bedöma
                        6. beställa
                        7. bidrag
                        8. däremot
                        9. efterfrågan
                        10. erfarenhet
                        11. framställa
                        12. förbereda
                        13. förbud
                        14. genomsnitt
                        15. hänsyn
                        16. inflytande
                        17. likgiltig
                        18. meddelande
                        19. misstänka
                        20. närvarande
                        21. ogilla
                        22. pågå
                        23. sammanträde
                        24. tillfälle
                        25. undvika	
                        """;
                case "2":
                    return """
                        1. anse
                        2. anställa
                        3. avdelning
                        4. avgift
                        5. begränsa
                        6. behålla
                        7. besviken
                        8. bortom
                        9. emellertid
                        10. envis
                        11. förbli
                        12. fördel
                        13. föredra
                        14. förgäves
                        15. förhållande
                        16. förvandla
                        17. godkänna
                        18. indela
                        19. inför
                        20. innehåll
                        21. medge
                        22. motsvara
                        23. omedelbart
                        24. oväsen
                        25. upptäcka
                        """;
                default:
                    return """
                        1. 
                        2. 
                        3. 
                        4. 
                        5. 
                        6. 
                        7. 
                        8. 
                        9. 
                        10. 
                        11. 
                        12. 
                        13. 
                        14. 
                        15. 
                        16. 
                        17. 
                        18. 
                        19. 
                        20. 
                        21. 
                        22. 
                        23. 
                        24. 
                        25. 
                        """;
            }
        }
        public string? GetProblemSet(string problemSetName)
        {
            switch(problemSetName)
            {
                case "1b":
                    return """
                        1. Han var där. Han var _.
                        2. De var helt ointresserade. De var _.
                        3. Medeltalet är 26,5. Det är 26,5 i _.
                        4. De tror att han är skyldig. De _ honom.
                        5. Vad är din åsikt om det? Hur _ du det?
                        6. De var positiva, men inte han. Han _ var negativ.
                        7. Vad är orsaken? Vad är _?
                        8. Vi såg den på flera kilometers håll. Vi såg den på långt _.
                        9. Jag ska planera det väl. Jag ska _ det väl.
                        10. Fick du upplysningen? Fick du _?
                        11. Du bör hålla dig borta från det. Du bör _ det.
                        12. De rapporterade det till polisen. De _ det till polisen.
                        13. Vi får pengar i understöd. Vi får _.
                        14. Jag visste inte att det var förbjudet. Jag kände inte till _.
                        15. Jag tycker inte om hans sätt. Jag _ hans sätt.
                        16. Många vill skaffa sig digitalkamera. Det är stor _ på digitalkameror.
                        17. Det här är en lämplig tidpunkt. Det här är ett bra _.
                        18. Hon har upplevt och lärt sig mycket. Hon har stor _.
                        19. De har makt att påverka. De har _.
                        20. Det är långt borta. Det är _.
                        21. Hur länge håller programmet på? Hur länge _ programmet?
                        22. Fabriken gör reservdelar. Fabriken _ reservdelar.
                        23. Han respekterar våra känslor. Han visar _.
                        24. Ett bord är reserverat för oss. Vi har _ bord.
                        25. Han är på ett möte. Han sitter i ett _.
                        ===
                        1. närvarande
                        2. likgiltiga
                        3. genomsnitt
                        4. misstänker
                        5. bedömer
                        6. däremot
                        7. anledningen
                        8. avstånd
                        9. förbereda
                        10. meddelandet
                        11. undvika
                        12. anmälde
                        13. bidrag
                        14. förbudet
                        15. ogillar
                        16. efterfrågan
                        17. tillfälle
                        18. erfarenhet
                        19. inflytande
                        20. avlägset
                        21. pågår
                        22. framställer
                        23. hänsyn
                        24. beställt
                        25. sammanträde
                        """;
                case "1c":
                    return """
                        1. _ till närmaste stad är 8 kilometer.
                        2. Kan vi träffas vid ett senare _? Jag är upptagen just nu.
                        3. Idag har jag _ mig till en kurs i ekonomi.
                        4. De har för lite att säga till om. De vill ha mer _ på sin arbetsplats.
                        5. Hur kan ni _ honom för att ha tagit pengarna?
                        6. _ till att han inte kom var att han hade försovit sig.
                        7. Det är mycket trafik på fredagseftermiddagarna, så jag _ att köra då.
                        8. Hon arbetar i _ 30 timmar i veckan.
                        9. Han har varit lärare i tjugo år, så han har lång _ av arbete med ungdomar.
                        10. Jag tycker inte att man visar tillräcklig _ till de gamla och sjuka i samhället.
                        11. Kriget har _ i tio år och alla längtar efter fred.
                        12. Cider är en dryck som man _ av äpplen.
                        13. Läkaren _ hans hälsotillstånd som gott.
                        14. Är du helt _? Bryr du dig inte alls om hur det går?
                        15. I morgon har vi ett viktigt _. Då ska vi diskutera budgeten.
                        16. Han bor i en _ by långt ute på landet med flera kilometer till närmaste granne.
                        17. Nu har vi _ biobiljetter. De ska hämtas senast kl. 7.
                        18. Många röker i tunnelbanan trots _.
                        19. Jag tror att om man _ resan noga får man större nöje av den.
                        20. En telefonsvarare är ett slags bandspelare där man lämnar ett _ om att an har ringt.
                        21. Han var positiv, men hon _ förslaget.
                        22. Det är stor _ på små lägenheter i stan.
                        23. Jag var inte _ vid sammanträdet, så jag vet inte vad som hände.
                        24. För att klara kostnaderna har vi sökt ett _ på 10.000 kronor från kommunen.
                        25. Jag har inte tid ikväll. _ skulle vi kunna ses på torsdag, om du vill.
                        ===
                        1. avståndet
                        2. tillfälle
                        3. anmält
                        4. inflytande
                        5. misstänka
                        6. anledningen
                        7. undviker
                        8. genomsnitt
                        9. erfarenhet
                        10. hänsyn
                        11. pågått
                        12. framställer
                        13. bedömer
                        14. likgiltig
                        15. sammanträde
                        16. avlägsen
                        17. beställt
                        18. förbudet
                        19. förbereder
                        20. meddelande
                        21. ogillade
                        22. efterfrågan
                        23. närvarande
                        24. bidrag
                        25. däremot
                        """;
                case "2b":
                    return """
                        1. Det har flera positiva sidor. Det har flera _.
                        2. Jag måste hålla med om det. Jag _ det.
                        3. De hittade flera fel. De _ flera fel.
                        4. Man kör förbi idrottsplatsen. Det ligger _ idrottsplatsen.
                        5. Vad tycker du? Vad _ du?
                        6. Snart börjar ett nytt läsår. Vi står _ ett nytt läsår.
                        7. De har förändrat det radikalt. De har _ det.
                        8. Vad är det för oljud? Vad är det för _?
                        9. Hon ger sig inte. Hon är _.
                        10. Det är bra. Vi accepterar det. Vi _ det.
                        11. 100 personer arbetar för dem. De har _ 100 personer.
                        12. Jag är ledsen och missnöjd. Jag är _.
                        13. Det är dock svårt. Det är _ svårt.
                        14. Det tjänade ingenting till. Det var _.
                        15. Det är jämförbart med vårt system. Det _ vårt system.
                        16. Hur är relationen mellan dem? Hur är _ mellan dem?
                        17. Var på varuhuset säljs resväskor? På vilken _ säljs resväskor?
                        18. Du får ha kvar boken. Du får _ boken.
                        19. De delar upp oss i grupper. De _ oss i grupper.
                        20. Han kom genast. Han kom _.
                        21. Vi betalar 500 kr i månaden. _ är 500 kr i månaden.
                        22. Vad finns inuti den? Vad har den för _?
                        23. De vil inte att det blir större. De vill _ det.
                        24. Jag åker hellre tåg än buss. Jag _ tåg framför buss.
                        25. Han gifte sig aldrig. Han _ ogift.
                        ===
                        1. fördelar
                        2. medger
                        3. upptäckte
                        4. bortom
                        5. anser
                        6. inför
                        7. förvandlat
                        8. oväsen
                        9. envis
                        10. godkänner
                        11. anställt
                        12. besviken
                        13. emellertid
                        14. förgäves
                        15. motsvarar
                        16. förhållandet
                        17. avdelning
                        18. behålla
                        19. indelar
                        20. omedelbart
                        21. Avgiften
                        22. innehåll
                        23. begränsa
                        24. föredrar
                        25. förblev
                        """;
                case "2c":
                    return """
                        1. Det var svårt att sova på grund av allt _ utanför huset.
                        2. Var det Christofer Columbus som _ Amerika?
                        3. En euro _ ungefär nio svenska kronor.
                        4. _ är 20 kronor för vuxna och 10 kronoer för barn.
                        5. Vi sålde all möblerna men _ några gamla tavlor.
                        6. Jag var _. Jag hade hoppats på ett mycket bättre resultat.
                        7. Flaskan gick sönder och _ rann ut.
                        8. Landet har _ importen avolja därför att kostnaderna var för höga.
                        9. Den nya bostaden har många _. Den är ljus och modern och har ett bra läge.
                        10. _ mellan läraren och eleverna är öppet och kamratligt.
                        11. Vi fick inga pengar för de _ inte vår räkning.
                        12. Han _ att det verkade svårt, men han tänkte i alla fall försöka.
                        13. Vi har inte tid att vänta. Det måste göras.
                        14. Jag känner oro _ framtiden.
                        15. Man brukade _ befolkningen i tre socialgrupper.
                        16. Jag tycket inte om vide. Jag _ att se vilm på bio.
                        17. I semestertider brukar de _ extra personal.
                        18. Solen går ner _ bergen och färgar kvällshimlen röd.
                        19. Han är intagen på sjukhus, men jag vet inte vilken _ han ligger på.
                        20. Vad _ du att regeringen bör göra?
                        21. Det var förgäves. a) Det var inte som väntat. b) Det motsvarade förväntningarna. c) Det var bortkastat.
                        22. Den förblev min. a) De tog den från mig. b) Jag fick den. c) Den stannade hos mig.
                        23. Man har förvandlat dem. a) De har fått arbete. b) De är nu helt annorlunda. c) De har försvunnit.
                        24. Han var emellertid sjuk. a) Men han var sjuk. b) Han var sjuk under tiden. c) Han var sjuk flera gånger.
                        25. Han är envis. a) Han vet mest av alla. b) Han är ledsen nu. c) Han ger sig inte.
                        ===
                        1. oväsen
                        2. upptäckte
                        3. motsvarar
                        4. avgiften
                        5. behöll
                        6. besviken
                        7. innehållet
                        8. begränsat
                        9. fördelar
                        10. förhållandet
                        11. godkände
                        12. medgav
                        13. omedelbart
                        14. inför
                        15. indela
                        16. föredrar
                        17. anställa
                        18. bortom
                        19. avdelning
                        20. anser
                        21. c
                        22. c
                        23. b
                        24. a
                        25. c
                        """;
                default:
                    Console.WriteLine($"Lyckades inte ladda in {problemSetName} from Database-klassen.");
                    return null;
            }
        }
    }
}

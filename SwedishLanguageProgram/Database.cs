using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwedishLanguageProgram
{
    internal class Database
    {
        public string? GetWordList(string chapterNum)
        {
            switch (chapterNum)
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
                default:
                    return null;
            }
        }
        public string? GetProblemSet(string key)
        {
            switch(key)
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
                default:
                    Console.WriteLine($"Lyckades inte ladda in {key} from Database-klassen.");
                    return null;
            }
        }
    }
}

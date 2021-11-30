C#Övning1-Personalregister

Uppgift 1 
Vilka klasser bör ingå i programmet?

Personal.cs En klass för personer som läggs till
Menu.cs En klass för menu som håller reda på vad som printas och när
Program.cs En klass för main som håller koll på vilka subklasser som körs vilket för tillfället bara är en.

Uppgift 2
Vilka attribut och metoder bör ingå i dessa klasser

Program.cs innehåller menu klassen som attribut och eventuellt flera klasser om ytterligare funktioner läggs till i framtiden.
Menu.cs innehåller attribut som tillfälligt håller reda på all input från konsolen och tillfälliga attribut som ska skickas vidare till andra klasser.
Metoder för att presentera rätt del av menu och för att lättare/tydligare kunna lägga till andra alternativ.

Personal.cs en klass som innehåller en persons namn och lön och kan retunera de vid behov.

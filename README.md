### Valgfritt oppgavesett for desember!

I dette oppgavesettet er det to assignments. <br>
Begge assignmentene har minst en class dere må fylle ut, og minst en interface deres class må oppfylle. <br>
Den første assignmentene er en DiceRoller metode, hvor dere skal lage en tilfeldig tall generator<br>
som skal oppfølge et sett med krav.<br>

Den andre er litt mer komplisert<br>
Der skal dere lese en csv fil som ligger i datasets<br>

<br>
Vi har ikke jobbet med csv filer før. men det er ganske ligt som en JSON<br>

Litt om CSV:<br>

- Det står for Comma Separated Values, hvor hver verdi er separert med et , tegn.
- Første linje i filen er alltid det som heter "header" verdier, aka navnet på de forskjellige "tabellene"
- Den bestemmer også rekkefølgen på data nedover i datasettet.
- Siden første Header er Name, er den første verdien i hver linje representativ for et Name.
- Her kan det være lurt å leke litt med de forskjellige måtene å lese tekst på fra en fil, kanskje ikke ReadAllText er rett metode.

Kos dere og eksperimenter med oppgaven. Vi skal se på csv samtidig som vi skal se på andre filer etter nyttår. Så dette blir en liten smakebit. <br>

Litt om å kjøre oppgaven.<br>
Når man forker oppgaven kan det være lurt å kjøre en <br>

```bash
dotnet restore
```

før man fortsetter, da er man sikker på at man har alle nuget pakkene installert som prosjektet trenger.<br>

Når man skal gjøre oppgaven annbefaler jeg dere å bruke watch daemonen til dotnet cli verktøyet:<br>

```bash
dotnet watch --quiet run
```

Da vil programmet restarte hver gang man har gjort endringer, og man får resultatet om oppgaven er utfylt eller ikke direkte i terminal <br>

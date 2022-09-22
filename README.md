# LA1100
 Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  1.9.2022 |  1.0.0   | Ich habe an die fast alles hinbekommen in den User Stories jedoch funktionieren viele Schleifen nicht und die Fehlermeldung habe ich auch noch nicht hinbekommen |
| 8.9.2022      | 2.0.0   |    Ich habe fast alles fertig die schleifen funktionieren da ich nicht mehr so viel If benutzt habe und mehr mit switch cases gearbeitet habe.                                                          |
| 15.09 - 22.09.2022      | 2.0.0   | Github eingerichtet und bearbeitet. |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt ist das Erstellen von einem Number guessing Spiel.
Das Spiel gibt eine Zahl von 1-100 vor und als Spieler muss man diese Zahl herausfinden.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |     Muss        |  Funktional    | Als ein Spieler möchte ich dass, der Computer eine Zufallszahl von 1-100, damit der Spieler sie daraufhin erraten kann.           |
| 2    |     Muss        |  Funktional    | Als ein Spieler möchte ich die Zahl erraten, damit ich das Spiel spielen kann.                                                   |
| 3   |     Muss        |   Funktional   | Als ein Spieler möchte ich wissen ob ich die richtige Zahl eingetragen habe, damit ich weiss ob ich die Zahl in Ziffern oder Buchstaben eingeben muss. |
| 4    |     Muss        |   Funktional   | Als ein Spieler möchte ich wissen ob die Zahl erraten worden ist, damit ich weiss ob ich sie erraten habe oder weiter raten muss. |
| 5    |     Muss        |   Funktional   | Als ein Spieler möchte ich wissen ob die Zahl kleiner/grösser ist als geraten, damit ich weiss ob ich höher oder niedriger schätzen muss. |
| 6    |     Muss        |    Funktional    | Als ein Spieler möchte ich wissen wie viele Versuche ich gebraucht habe, damit ich meine Versuche vergleichen kann. |


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Generierte Zahl 1-100 |       | *zufällige Zahl*               |
| 2.1 |  Eingabe einer Zahl            |   23      |  *zufällige Zahl* *Eingabe der Zahl*                 |
| 3.1  | Fehlermeldung bei Falscher Zahl           |   123      |  Falsche Eingabe bitte wählen sie ein Natürliche Zahl von 1-100 und geben sie Ziffern ein                 |
| 4.1 |  Richtige Zahl bestimmt            | 23        |  Richtige Zahl  |
| 5.1 |  Falsche Zahl die Zahl ist grösser          |    *zufällige Zahl* |     Die Zahl ist kleiner als 45    |
| 5.2 |  Falsche Zahl die Zahl ist kleiner         |   *zufällige Zahl*      |    Die Zahl ist grösser als 12      |
| 6.1 |  Versuche der Spieler eingerichtet            |  *Richtige Nummer erraten*       |   Du hast *Anzahl Versuche* gebraucht, um die Zahl zu erraten   |
✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![Guessing Number Spiel](https://user-images.githubusercontent.com/111046337/186598738-56f0b7f0-50d8-4fbc-8f3f-4e6cb1777ac0.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 1.9.22  |  Bischof | Code schreiben welches eine Zahl  generiert           |45 min|
| 1.B | 1.9.22   | Bischof | Code generiren aber begrenzt von 1-100                  |10 min|
| 2.A  | 1.9.22  | Bischof | Code für die Eingabe von der Zahl                      |8 min|
| 3.A  | 1.9.22  | Bischof | Begrenzung von Eingabe der Zahl                        |30 min|
| 4.A  | 1.9.22  | Bischof | Fehlermeldung bei Falscher Eingabe                     |15 min|
| 5.A  | 1.9.22  | Bischof | Ausgabe ob die Zahl erraten worden ist                 |22 min|
| 6.A  | 1.9.22  | Bischof | Ausgabe ob Zahl zu gross ist                           |10 min|
| 6.B  | 1.9.22  | Bischof | Ausgabe ob Zahl zu klein ist                           |10 min|
| 7.A  | 1.9.22  | Bischof |  Ausgabe Anzahl versuchen                              |30 min|



Total: 180

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  1.9     |   Gabriel        |    45 min           |      25 min             |
| 1.b  |  1.9     |   Gabriel        |    10 min           |       45 min             |
| 2.A  |  1.9     |   Gabriel        |    15 min           |      25 min             |
| 3.A  |   8.9    |   Gabriel        |    30 min           |       45 min             |
| 4.A  |  1.9     |   Gabriel        |    45 min           |      15 min             |
| 5.A  |  8.9     |   Gabriel        |    22 min           |       100 min            |
| 6.B  |  8.9     |   Gabriel        |    22 min           |        45 min             |
| 7.A  | 1.9      |   Gabriel        |     45min           |       45 min             |


✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |
| 2.1  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |
| 3.1  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |
| 4.1  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |
| 5.1  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |
| 5.2  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |
| 6.1  |   22.09.2022    |  Funktioniert        |    Gabriel Bischof    |

Fazit: Alle User's Stories funktionieren einwandfrei.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

# Lern-Bericht
Von Gabriel Bischof

## Einleitung

Wir haben im Modul LA 1100 ein Number guessing Spiel erstellt.

## Was habe ich gelernt?

Ich habe gelernt wie man Switch Case verwendet und wo man sie am besten einsetzten kann.

## Beschreibung

Switch Case sollen den ganzen Code ein bisschen übersichtlicher zbsp. Wenn man zu viele Alternationen im Code hat.
Das heisst also das Switch Case den Code eleganter.

Switch Case können aber auch Fehler Abfangen,dass passiert mit dem Case *default*.
```csharp 
int zahlenreihenfolge 

switch(zahlenreihenfolge)
case int n when (eingebeneZahl < 101 && eingebeneZahl > 1):
do
{

//Befehl


}while () //das zutrifft

break;

default:

Console.WriteLine("Falsche Eingabe");    //abfangen von Fehler

```
Zusammengefasst kann also Switch Case helfen den Code strukturierter und übersichtlicher zu machen vor allem wenn man viele Alternationen im Code besitzt

![image](https://user-images.githubusercontent.com/111046337/191687305-f2a5f584-863a-49c4-b843-028f7fbe92ae.png)


!![code](https://user-images.githubusercontent.com/111046337/191689889-6ff7ef82-9f76-428f-beeb-0284d4607d02.gif)




## Verifikation

Text: Beschreibt wie man Switch Case verwenden kann und wo sie einen Vorteil bieten.
Code: Zeigt ein Beispiel wie ein Switch Case aussehen kann.
Bild : Zeigt ein weiteres Beispiel wie man Switch Case verwenden kann.
GIF : Zeigt das Numberguessing Spiel mit Switch Case.


# Reflektion zum Arbeitsprozess

Während der Arbeit habe ich mehrheitlich konzentriert gearbeitet und wenn es Probleme gab, habe ich nicht direkt das Handtuch geworfen.
Ausserdem habe ich meist Zielorientiert gearbeitet, dass heisst mit Hilfe der User Stories.

Ich habe zu wenig Pause gemacht welches ein Grund für Fehler die ich während dem Realisieren gemacht habe.
Ausserdem hatte ich an einem Tag zu wenig Schlaf welches sich auch ein klein wenig Negativ ausgewirkt hat.

**VBV**: 
Versuchen nach langen Arbeitsstunden pause zu machen und nicht vergessen etwas zu trinken und etwas zu essen.
Früher ins Bett zu gehen das erleichtert mir auch das Realisieren.

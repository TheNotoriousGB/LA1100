# LA1100
 Projekt-Dokumentation



Gabriel Bischof

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
.

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



## 3 Entscheiden

Ich habe mich entschieden aus zeitlichen Gründen nur die vorhandenen User Stories zu bearbeiten

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



## 6 Auswerten
Link zum Lernbericht
https://github.com/TheNotoriousGB/LA1100/blob/main/lernbericht.md



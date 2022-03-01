## Követelmény elemzés
A játék megvalósítására a Unity játékmotort használjuk fel, amiben egy
felülnézetes, 2D-s játékot készítünk.
A játéktér fő alkotóeleme a négyzetháló, ami egy n x m-es területre osztja fel a pályát.
A játékos később ezekre tudja elhelyezni a tornyokat, és az egységek is ezen mozognak.

### Felhasználói esetek
A felhasználó a játékot elindítva, a főmenüben több lehetőség közül választhat:
 - Új játékot indíthat
 - Betölthet egy mentett játékot
 - A térképszerkesztőbe lépve maga is készíthet egy játékteret
 - Kiléphet a játékból

#### Új játék indítása
Miután az új játék indítására kattint a felhasználó, ki tud választani egy pályát, majd elindítani azt.

Ezzel kezdetét veszi a játék, amiben:
 1. A játék folyamata:
    - Az egyik játékossal kezdve el tud helyezni tornyokat a pályán, és egységeket képezni.
    - Ha a játékos végzett, a következő körben a másik játékos tud tornyokat építeni, és egységeket képezni.
    - Ha mindkét játékos végzett az építési szakasszal, az egységek elindulnak a játékosok kastélyai felé.
 1. A játék szüneteltethető, ekkor megjelenik egy **szünet menü**, ahol:
    - Menteni lehet a játékkállást
    - Be lehet tölteni játékállást
    - Ki lehet lépni az aktuális játékból
    - Be lehet zárni a menüt
 1. Amennyiben vége a játéknak, úgy azt a játék jelzi. Ekkor:
    - Ki lehet lépni a főmenübe
    - Be lehet tölteni egy mentett állást

#### Játék betöltésee
Ilyenkor a játékos ki tud választani egy elmentett játékállást és betölteni azt.

#### Térképszerkesztő
Megjelenik a térkép szerkesztésére szolgáló felület, ahol
a játékos meg tudja adni, hogy:
 - mekkora legyen a pálya mérete
 - el tud helyezni akadályokat
 - el tudja helyezni a két játékos várát
 - el tudja menteni a megszerkesztett pályát
 - be tud tölteni egy elmentett pályát

#### Kilépés
Erre kattintva a játék bezárul.

----

## Statikus terv

### Osztályok leírása

#### MainMenu
A játék belépési pontja, tartalmazza a játék idítására szolgáló
gombokat, illetve ez példányosítja a _GameHud_-ot és a _MapEditorHud_-ot

#### GameHud
A fő játék vizuális megjelenítéséért felelős osztály.
A játék állásának megfelelően jeleníti meg a játékosok információit,
megnyitható a szünet menü.
Tartalmazza a _Game_ osztályt.

#### MapEditorHud
Térképszerkesztő vizuális megjelenítéséért felelős osztály.
A játékos megadhatja a pálya méretét és objektumokat helyezhet el
erre a területre, mentheti, és betöltheti az állásokat.
Tartalmazza a _MapEditor_-t.

#### PauseMenu
Egy kisebb menü a játékon belül, innen lehet visszalépni
a főmenübe, menteni és betölteni a játékállást.

#### Game

#### PersistenceHud

#### Persistence



## Felhasználói felület terve


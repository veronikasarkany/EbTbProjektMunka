

 
<div id="header" align="left">
    <img src="https://github.com/veronikasarkany/ProjektMunka/blob/main/logo.png" width="100"/>
  
  <h1>
   
  <img src="https://media1.giphy.com/media/XFaFcWnsUux2l6VLKw/giphy.gif" width="30px"/>  
  EbTbProjektMunka
 
</h1>
  </div>
  
  <div id="header" align="right">
    <img src="https://komarev.com/ghpvc/?username=veronikasarkany&style=flat-square&color=blue" alt=""/>
  </div>
 
 EbTb 

A program olyan rendszer ahol a kis kedvenceink kezeléseit követhetjük nyomon bármelyik állatorvosi rendelőbe visszük. Kötelező védőoltásait, sürgősségi ellátásait, kezeléseket, allergiákat tartja számon. 
Továbbá a „Gazdi” adatai is letárolásra kerülnek. „Gazdik” befizethetnek, egy külön adott számlaszámra ahol a befizetett összegből a kis kedvencek ellátását tudják fedezni, így ha kedvencüknek ellátásra van szüksége, akkor a befizetett összegből tudják a kezelési költséget rendezni.
A „Gazdi” maga döntheti el, hogy milyen ütemezésben fizet be összeget a számlára, nincs összeg megkötés. Lehetséges heti vagy havi befizetés.

Kisállatok és a Gazdik is ugyanazzal az egy egyedi azonosítóval („ID”-val) rendelkezik. 
Chippel ellátott állatok esetben a chip számmal megegyező az ID szám, amennyiben nem rendelkezik chippel (nem lehetséges az állat „be”chippelése) abban az esetben is egy egyedi azonosítóval látjuk el.
Az egyedi azonosító (továbbiakban ID szám) a GazdiID és az ÁllatID megegyező szám.
 
## 💡 Program leírása

Program indításakor bejelentkezés szükséges. Jelenleg a program használatához az alábbi felhasználónév és jelszó párossal lehet a program belépni:
Felhasználónév: Diak
Jelszó: Almafa
 	  
(bejelentkezés)		(regisztráció) 
Felhasználónév és jelszó megadása kötelező, amennyibe nem rendelkezünk még bejelentkezéshez szükséges adatokkal így lehetőségünk van regisztrációra (Regisztrációs menüpont alatt ezt megtehetjük).
Bejelentkezés után a fő menüben tudjuk kiválasztani, mely műveleteket szeretnénk elvégezni.

 
## 😺 ÁllatID
 
Ebben a menüpontban a Kedvencünk és Gazdi alapadatait láthatjuk. 
ÁllatokID legördülő menübők ki tudjuk választani az ellátásra szoruló kis állatot.

## 💵 Befizetések és Kezelések
 
Befizetések menüpont alatt az ÁllatID beírása, Keresés gomb megnyomása után megtalálhatjuk a „Fontosabb egészségügyi Bejegyzéseket és kezeléseket”.

„Dátum, Diagnózis, Terápia, ÁllatID” oszlopokban listázásra kerül az eddig bejegyzett adatok. Amennyiben még nem volt ilyen, így a mezők üresek maradnak. 
„Találatok száma:” megmutatja, hogy eddig mennyi rekord került rögzítésre ahhoz az ID számhoz.
 - :	„Összes” 
A rendszerben található összes berögzített ID-hoz tartozó adatokat tudjuk kilistázni. Javasolt, hogy ha egy adott állathoz tartozó adatot szeretnénk csak látni, akkor használjuk célzott keresést , írjuk be az ÁllatID mezőbe az ID számot.
- : 	„Új bejegyzés” 
A rendszerbe új bejegyzést is tudunk rögzíteni, a ÁllatID,Diagnózis , Terápia , Dátum megadása után az új bejegyzés gombra kattintva hozzáadhatjuk az új rekordot.
- : 	„Módosítás” 
A már berögzített adatokat tudjuk módosítani.
- : 	„Törlés”
A tévesen bevitt adatot / adatokat tudjuk törölni.
 

## 🧪 Oltások
 

„Egyéb védőoltások és Parazita elleni kezeléseket” találjuk ahol ÁllatID alapján megtaláljuk a bejegyzéseket. Itt is ahogy az előzőekben leírtak alapján tudjuk listázni az „Összesen” gomb megnyomásával a rendszerbe felvitt összes adatot. 
 

## 📝 Adatmódosítás
 
A berögzített adatokat tudjuk módosítani majd menteni az adatbázisba.
 
## 🙋‍♀️ GazdiID
 
 - :	„Elérhetőségek”
Gazdi adatait tudjuk módosítani és menteni.
 - :„Befizetések”
Ebben a menüpontban látjuk a számlán szereplő befizetett összeget, itt tudjuk a kezelési költséget berögzíteni a „Számol” gomb segítségével a rendszer kiszámolja, hogy a kezelési költség levonása után mekkora összeg marad még a számlán.
 

## ® Kis Kedvenc Regisztráció
 
Regisztráció menüpont alatt tudunk új kis állatot berögzíteni.
Első regisztrációnál fontos egyedi ID számot generálni a kisállat részére. Ezt az „Új ID szám” gomb megnyomásával tudjuk megtenni. Amennyiben az ID szám már szerepel az adatbázisban, úgy figyelmeztetést kapunk erről és másik ID számot kell generálni. Ha pedig még nem szerepel az adatbázisban, akkor erről is tájékoztatja a felhasználót.
Ha az ID szám még nem szerepel az adatbázisban, erről is tájékoztatást kapunk.
 

Új ID számot mind két mezőbe a „ÁllatID” és a „GazdiID” mezőbe is be kell másolni / írni (fontos a pontos és helyes rögzítés érdekében).
A metaadatok kitöltése után a „Mentés” gomb megnyomása után az adatok rögzítésre kerülnek.
Fontos minden metaadat pontos megadása és minden mező kitöltése (amennyiben esetlegesen bármely adatot rosszul rögzítettünk volna be, úgy az „Adatmódosítás” menüpont alatt tudjuk megváltoztatni).
 

## 📧 Segítség 
 
 - :	„Email küldése”
A program meghibásodásával vagy bármely visszajelzésével kapcsolatban van lehetőségünk e-mailt küldeni. 
 - :	„Frissítés”
Programot itt tudjuk frissíteni, ha új verzió vagy javítás elérhető. 



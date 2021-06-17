# MTTPP-projekt

## Opis projekta 
U ovome projektu se testiraju dobiveni rezultati korištenjem BMI (body mass index) kalkulatora. 
</br>Napisanu je 4 testa za pravilne unose (jedan za svaku težinsku skupinu. 
Također je napisano šest testova za nepravilne unose visine ili težine (unos nule, prazan unos, unos teksta). 
Osim toga testovi se pokreću na Chrome i Firefox pretraživačima.
</br>Link testirane stranice: https://www.nhlbi.nih.gov/health/educational/lose_wt/BMI/bmi-m.htm

## Korišteni alati
Za ovaj projekt korišteni su Selenium IDE i Visual Studio. Selenium IDE je korišten za snimanje testova, a Visual Studio za dodadtno uređivanje i pokretanje snimljenih testova.
Selenium IDE je ekstenzija za web preglednik, pa ga je prvo potrebno instalirati na korišteni preglednik.
</br>
</br>
### Selenium IDE
Na slici ispod je prikazana slika Selenium IDE.
![ide](https://user-images.githubusercontent.com/74720477/122400513-14652780-cf7c-11eb-9113-3e16155f2eed.png)
</br>
Klikom na "+" ikonu (oznaka 1) možemo dodati novi test. Nakon toga klikom na "REC" gumb u gore desnom kutu pokrećemo snimanje testnog scenarija. Pokretanjem snimanja se otvara novi prozor korištenog web preglednika. Sada je samo potrebno navigirati na stranicu koju testiramo te izvesti sve akcije koje test zahtjeva (klikanje, unos podataka itd.).
</br>
Nakon što smo snimili sve željene testove možemo dodati novi testni paket (eng. test suite) u kojega možemo spremiti prijašnje snimljene testove.
</br>
Testove možemo pokrenuti klikom na "play all" ili "play" gumbove (oznaka 2).
</br>
Svaki test ili testni paket je moguće izvesti u više programskih jezika (u ovome slučaju se odabire "C# NUnit").
![image](https://user-images.githubusercontent.com/74720477/122401947-56db3400-cf7d-11eb-9893-ac2dfa273e7e.png)
</br>
Ako želimo spremiti projekt kako bi ga mogli kasnije uređivati potrebno je kliknuti na ikonu diskete (oznaka 3).
</br>
</br>
### Visual Studio
Prvo je potrebno kreirati novi C# NUnit projekt. Zatim je potrebno unijeti testne pakete koje smo izvezli iz Selenium IDE-a.</br>
![new item](https://user-images.githubusercontent.com/74720477/122402536-dd901100-cf7d-11eb-99a6-94df8c2eab00.png)
</br>
To činimo tako da desnim klikom odaberemo projekt, zatim kliknemo na "Add" te "New item". Odabiremo C# klasu te joj dajemo naziv testnog paketa. Sada je samo potrebno u nju zaljepiti izvezeni kod iz Selenium IDE-a.
</br>
</br>
#### NuGet
Prije nego što možemo pokrenuti testove, potrebno je dodati potrebna proširenja (selenium webdriver i driveri za preglednike). Desnim klikom na solution te klikom na "Manage NuGet Packages For Solution..." otvaramo prozor za dodavanje proširenja.
![managenuget](https://user-images.githubusercontent.com/74720477/122403543-bd148680-cf7e-11eb-9930-3e18a8334b26.png)
</br>
U "Browse" dijelu potrebno je upisati "selenium webdriver" te instalirati proširenja označena na slici ispod.
![nugetpackages](https://user-images.githubusercontent.com/74720477/122403743-e6351700-cf7e-11eb-80fc-04a65eb49926.png)
</br>
</br>
#### Pokretanje testova
Sada je sve spremno za pokretanje testova. Potrebno je otvoriti test explorer (slika ispod) te pokrenuti testove.
![image](https://user-images.githubusercontent.com/74720477/122403946-141a5b80-cf7f-11eb-9183-a63bbb421aae.png)
</br>
Nakon što završi izvođenje svih testova moguće je vidjeti rezultate (trajanje testa, je li test uspješan, ako nije gdje je došlo do greške itd.).![testexp](https://user-images.githubusercontent.com/74720477/122404251-58a5f700-cf7f-11eb-828b-188b61b0b650.png)
</br>
</br>
## Dobiveni rezultati
Kao što se može vidjeti na slici iznad većina testova nije uspjelo. Razlog tome je zato što za krive unose (npr. prazan unos) svejedno se računa BMI umjesto da se pojavi poruka o grešci.

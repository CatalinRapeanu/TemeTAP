In proiectul acesta am plecat de la cel facut la laborator, unde am mai adaugat anumite lucruri.

In locul unui blog, eu m-am gandit la un site de vizualizat case, unde se pot vedea detalii despre 
toate casele de acolo, si unde se si poate licita pentru casele care sunt scoase la vanzare.

Am mai adaugat inca o clasa de utilizator normal, pe langa clasele de admin si vizitator, si clasei
de Admin am incercat sa ii dau o functionalitate noua, in functie de rolul pe care i l-am dat.

Ca principii de baza ale OOP am folosit mostenirea si polimorfismul

Fiind un Console Application nu am stiut ce functionalitate sa mai adaug programului, asa ca am gandit-o
putin ca pe un Web API, si am mai adaugat 4 clase: BidEntity, BidRepository, HouseEntity, HouseRepository.

Aceste clase ne-ar ajuta intr-un api sa stocam si sa administram datele, pentru a le si adauga ulterior
in baza de date.

Cu ajutrul clasei HouseEntity putem crea obiecte in care sa stocam toate detaliile despre o casa de pe site.
In clasa HouseRepository am si mostenit interfata IHouseRepository, care are diferite metode, cum ar fi:
Get, GetAll, Add, Update, Delete etc. care trebuiesc implementate si in clasa HouseRepository.
Lucrul acesta ne ajuta pe termen lung, deoarece daca vrem sa facem o schimbare site-ului, daca vrem sa folosim
alta clasa, de exemplu, in loc de HouseRepository, noi in cod vom folosi IHouseRepository, si pentru ca HouseRepository
mosteneste interfata, putem schimba foarte usor, din Dependency Injection. Nu trebuie sa schimbam peste tot unde apare
HouseRepository, pur si simplu schimbam in containerul de DI.

Acelasi lucru si pentru BidEntity si BidRepository.

Puteam face lucrul acesta si pentru useri, cu UserEntity si UserRepository, dar deja stocam datele si le gestionam
prin intermediul clasei statice Data.
    Am plecat de la codul sursa si am inceput cu primul principiu, Single Responsability Principle:
        -Am facut o clasa Logger si o interfata pentru aceasta, pentru a o folosi in loc de Console.WriteLine uri
        -Am facut o clasa pentru citirea fisierului json, si o interfata pentru aceasta
        -Am facut o clasa pentru deserializarea obiectelor de tip Order din fisierul json
    Si am inlocuit in clasa HotelReception cele realizate mai sus.
    
    Am continuat prin a adauga in clasa Order mai multi membri, pentru fiecare tip de comanda, pentru produse si mic dejun
    
    Am modificat fisierul json, pentru a putea centraliza datele mai usor
    
    Prin utilizarea de interfete am aplicat si principiul Open/Close, pentru ca, cu ajutorul acestora, codul o sa fie
    deschid la extindere, dar inchis la modiifcari. Acest lucru se face prin intermediul injectarii. Noi vom injecta
    interfata, si cu ajutorul acesteia avem acces la clasa de care avem nevoie, si daca avem nevoie de alta clasa, o facem
    si mostenim interfata si o injectam prin intermediul Dependency Injection, si asa aplicam si ultimul principiu, 
    Dependency Inversion
    
    Am aplicat principiul Single Responsability si am creat o clasa si o interfata pentru parsarea datei
    
    Am aplicat principiul Interface Segregation pentru ca am creat mai multe interfete, mici si care leaga clasele intre 
    ele cum trebuie si expun doar metodele relevante pentru utilizare
    
    Am aplicat principiul Liskov Substitution pentru ca pot folosi obiectele interfetelor claselor pe care le-am creat, si
    voi face acest lucru prin Dependency Injection
    
    Am separat codul din HotelReception in mai multe receptii
    
    Am schimbat numele clasei HotelReception in ReceptionPriceCalculator, pentru ca voi crea o clasa HotelReception in directorul
    Receptions care imi va gestiona intrarile din hotel
    
    Pe langa acesta clasa din directorul Reception voi mai crea cate una pentru fiecare tip de comanda pe care am definit-o
    
    Am adaugat si o clasa UnknownReception pentru un tip de comanda care nu e definit
    
    Am injectat obiecte din clasele de care am nevoie prin intermediul interfetei respective clasei, cu ajutorul
    dependency injection
    
    Am adaugat apoi un Factory pentru receptii, in care am mutat switch-ul din ReceptionPriceCalculator
    
    Am injectat prin intermediul constructorului din clasa ReceptionPriceCalculator
    
    O imbunatatire pe care am adus-o codului sursa este faptul ca atunci cand am deserializat din json, am realizat codul in
    asa fel incat sa pot citi si mai multe comenzi odata din fisierul json, si le-am adaugat intr-o lista de Order, iar
    atunci cand le parcurg pot calcula pretul total al acestor comenzi
    
    Acest lucru se poate da foarte usor inapoi, si refacut ca la inceput, daca nu este o imbunatatire buna
    
    In Program.cs am adaugat o instanta pentru logger si pentru dateParser si am modificat constructorul pentru ReceptionPriceCalculator
    pentru a rula programul
    
    Programul afiseaza la final pretul final pentru toate comenzile, adica suma tuturor preturilor comenzilor
    
    Am adaugat si LunchReception si DinnerReception
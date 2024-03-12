In acest proiect am folosit ideea de la laborator, doar ca am facut unele schimbari la clase.

Am facut alte metode, cum ar fi trimiterea codului de confirmare al contului prin email sau
sms, confirmarea licitatiei prin email sau sms, sau notificarea ca s-a conectat altcineva pe
cont.

In acest proiect am folosit 3 dintre principiile de baza ale OOP:
-am folosit abstractizarea in interfata INotification 
-mostenirea am folosit-o in cele 2 clase copil, EmailNotification si SmsNotification, care
mostenesc interfata INotification
-polimorfismul l-am folosit pentru a putea implementa aceeasi metoda, cu acelasi nume, dar
care functioneaza diferit
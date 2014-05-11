Shoot the Words - Документација

Опис на играта:

Апликацијата што ја имплементиравме е spell typing игра. Идејата за играта е земена од:
http://cognitivelabs.com/word_shoot.htm
http://phoboslab.org/ztype/
http://www.onlytypinggames.com/games/b_speed_typer/

Начинот на играње на играта е прилично едноставен. Целта е што побрзо и правилно да ги испишете зборовите кои што се појавуваат и со тоа да ги уништите тенковите и да не дозволите тие да ја поминат кулата од која што се погодуваат истите. Доколку не успеете да испишете одреден збор и тој ја помине кулата ви се одзема еден живот.

Упатство за користење:
      ![moj zbor](http://i.imgur.com/Kp7qUwk.jpg?2)











На почетната форма се прикажани копчињата Easy, Medium, Hard, View highscore и Game description како и еден textBox во кој е даден краток опис на играта и начинот на играње. Со кликање на некој од копчињата Easy, Medium или Hard се отвора втората форма во која се игра играта. 
Доколку одбереме easy, зборовите кои што ќе се појавуваат ќе бидат со помалку од 5 букви и за секој погоден збор ќе добиваме толку поени колку што е долг зборот.  На ова ниво на секои 1.7 секунди се појавува нов збор и нов тенк.
Доколку одбереме medium, зборовите кои што ке се појавуваат ке бидат со помалку од 7 букви а за секој погоден збор ќе добиваме толку поени колку што е долг зборот помножено со коефициент од 1.5. Доколку играта се заврши со децимален број на поени како конечен број на добиени поени се заокружува на долната вредност. На ова ниво нов збор и нов тенк се појавува на секои 1.2 секунди.
Доколку одбереме hard, зборовите кои што се појавуваат ќе бидат со помалку од 9 букви и за секој погоден збор ќе добиваме толку поени колку што е долг зборот помножено со коефициент 2. На ова ниво зборовите се појавуваат на 0.8 секунди.

![moj zbor](http://i.imgur.com/WYdiFaz.jpg?3)      ![moj zbor](http://imgur.com/Ly1J4Nv.jpg?2)











Со отварањето на втората форма зборовите започнуваат да се појавуваат и ние веднаш можеме да почнеме со нивно испишување во текстуалното поле од левата страна на формата. Доколку испишеме некој збор кој што постои на екранот тој ке се уништи како што е прикажано на сликата од десно. 
Десно од полето за внес на зборовите е копчето за звук на кое јасно се покажува кога има а кога нема звук.
Со клик на копчето space кога текст полето е празно играта се паузира. Истата може да се продолжи со кликање било каде на формата.
     
  ![moj zbor](http://i.imgur.com/qZXA13x.jpg?1)








Доколку ги изгубиме сите 3 животи играта запира и се отвора формата прикажана на следната слика.
![moj zbor](http://i.imgur.com/hM2pUoH.jpg?1)







На оваа форма го внесуваме нашето име и со клик на копчето Save score ги зачувуваме во база прикажаните поени. Доколку сакаме да ја видиме целосната листа на играчи и нивните поени ке мора да кликнеме на копчето Try again и да кликнеме на копчето View high score по што на местото на описот на играта ке се појави listBox со имињата на играчите и нивните поени сортирани според поените како на следната слика.
      ![moj zbor](http://i.imgur.com/vBx7SNa.jpg?2)











Опис на структурата:
Играта е составена од 3 форми. Form1 е Menu формата. Form2 е Play формата и Form3 е Game Over. 
Главните класи се класата Tank.cs и класата TanksDoc.cs.
Во класата Tank се чува зборот што треба да се прикаже до тенкот,  неговата позиција, слика и состојбата (погоден/непогоден). Тука има и 3 методи. Методот Move со кој што се придвижува тенкот по Y оската. Потоа методот Draw со кој што се исцртува тенкот и зборот и методот Hit кој се повикува кога соодветниот тенк ке биде погоден.
Во класата TanksDoc се чува листа од тенкови а се чува бројот на поените од погодените тенкови. Во оваа класа имаме и 3 методи. Методот addTank со кој се додава нов тенк во листата. Методот Move со кој се придвижуваат тенковите во листата и методот Draw со кој се исцртуваат сите тенкови во листата.
Како главна класа би ја издвоил и класата од Form2. Во оваа класа меѓу другото ги вчитуваме зборовите од базата во зависност од тоа кое ниво сме одбрале easy, medium или hard.
Една од главните функции во оваа класа е функцијата timerGame_Tick која што се повторува секоја 41 милисекунда и со тоа добиваме илузија на постојано движење на тенковите. Во оваа функција се проверува и поставеноста на тенковите па доколку некој од тенковите се “судира“ со кулата тој тенк се уништува и се одзема живот. Тука е конфигурирана и фрекфенцијата на додавање на нови тенкови кое што зависи од избраното ниво.
Проверката на точноста на внесениот збор се проверува со функцијата txtWord_TextChanged. Па доколку внесениот збор постои во некој тенк кој е прикажан на формата соодветно зборот и тенкот ке се уништат со повикување на tenk.Hit() по што следи повик на Thread.Sleep(50) што означува дека формата ке замрзне за 50 милисекунди што е доволно време да се исцрта уништувањето на тенкот.

Изработиле:
Дарко Јаневиќ - 112042
Крсте Москов - 112066

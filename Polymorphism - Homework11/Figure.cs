﻿/*
Bir Figure abstrakt class-ı olur və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur.

Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

Program class-ında bir menu olacaq
1. Square
2. Rectangular
0. Quit

İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.
 
*/
namespace Polymorphism___Homework11
{
    abstract class Figure
    { 
        public abstract int CalcArea();
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
                                         // Biblioteka skrótów

        // CTRL + D - kopiuje linijke automatycznie w dół
        // CTRL + X usuwa linie kodu
        // CTRL + SHIFT + B - skrót do debugowania 
        // Skrót do Console.WriteLine() to cw + 2xTAB


        {
            Console.WriteLine("________________Zmienne________________");
            var countTwo = 8;  // Zmienna var pozwala na interpretacje zmiennej przez program 
            byte number =2;   
            int count = 10;
            float totalPrice = 20.95f; //Przy deklarowaniu zmiennej typu float na koncu liczby trzeba dodac "f"
            char character = 'A';
            string firstName = "Marcin";
            bool isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(countTwo);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;   //Definiowanie zmiennej STAŁEJ

                                             //Konwersja danych
            Console.WriteLine("________________Konwersja danych________________");
            byte b = 1;  
            int i = b;
            Console.WriteLine(i);

            //  int i = 1; //Konwersja danych nie jest możliwa bo int ma 4bajty a byte 1 = utrata danych
            //  byte b = i; //Aby konwersja była możliwa, musimy zastosować jawną konwersje, czyli dopisać (byte) przed i: byte b = (byte)i;
            // dopóki ilość bajtów nie przekroczy pamięci nie będzie utraty: int i = 1;  byte b = (byte) i; to wyjdzie poprawnie
            // ale int i = 1000; byte b = (byte) i; nastąpi utrata danych
            //int i = (int)number; // niekompatybilne typy zmiennych = ciąg znaków nie jest możliwe przekonwertowanie na liczby
            // trzeba użyć konwersji klasy
            string numberTwo = "1234";
            int o = Convert.ToInt32(numberTwo);   //Poprawna konwersja
            Console.WriteLine(o);
                                        //Wyjątki
            Console.WriteLine("________________Wyjątki________________");
            try
            {
                string numberThree = "1234";        //Konwersja do byte jest niemozliwa, gdyż wyrzuca błąd, że liczba jest za mała lub za duża
                byte c = Convert.ToByte(numberThree); //Aby nie wywalało programu, a dało przyjazną informacje dla uzytkownika mozna sobie z tym poradzic za pomocą try-catch
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("Liczba nie może być przekonwertowana do byte");
            }

            try
            {
                string str = "true";
                bool e = Convert.ToBoolean(str);
                Console.WriteLine(e);
            }
            catch (Exception)
            {
                Console.WriteLine("Liczba nie może być przekonwertowana do boolean");
            }

                                            //Operatory logiczne
            Console.WriteLine("________________Operatory logiczne________________");
            //Dodawanie = +,
            //Odejmowanie = -,
            //Mnożenie = *,
            //Dzielenie = /,
            //reszta z dzielenia = %,
            //inkrementacja = ++(a = a+1),   Gdzie inkrementacje jak i dekrementacje dzielimy na dwie możliwości 1: a++ 2: ++a
            //dekrementacja = --(a=a-1),     Przykład 1: int a = 1; int b = a++; wynik: a = 2, b = 1
            //znak równości = ==,            Przykład 2: int a = 1; int b = ++a; wynik a = 2, b = 2
            //znak nierówności = !=,
            //znak większości = >,
            //znak większe bądź równe = >=,
            //znak mniejszości = <,
            //znak mniejsze bądź równe = <=, 
            //przypisanie dodawania = +=,   
            //przypisanie odejmowania = -=,
            //przypisanie mnożenia = *=,
            //przypisanie dzielenia = /=
            //"i" = &&                     
            //"lub" = ||                    
            //"nie/not" = !

            var liczba1 = 1;
            var liczba2 = 2;
            var liczba3 = 3;
            Console.WriteLine(liczba1 + liczba2);
            Console.WriteLine((float)liczba1 / (float)liczba2);
            Console.WriteLine(liczba1 > liczba2);
            Console.WriteLine(liczba1 == liczba2);
            Console.WriteLine(liczba1 != liczba2);
            Console.WriteLine(liczba3 > liczba2 && liczba3 > liczba1);
            Console.WriteLine(liczba3 > liczba2 && liczba3 == liczba1);
            Console.WriteLine(liczba3 > liczba2 || liczba3 == liczba1);




        }

    }
}

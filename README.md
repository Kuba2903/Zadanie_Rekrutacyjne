Utworzono bazę danych z użyciem Entity Framework Core. W bazie danych zawarto cztery tabele którymi są: Ligi, Drużyny, Mecze, oraz Ulubionie (do przechowywania ulubionych drużyn). Tabele Drużyny oraz Mecze są
połączone relacją jeden-do-wielu. W warstwie Models utworzono odpowiedniki do wymienionych powyżej tabel. Utworzono klasę serwis która posiada najważniejsze metody z których korzysta później kontroler.
W kontrolerze zawarto odniesienia do widoków które wyświetlają: dostępne ligi, tabele ligi, oraz w tabeli możliwość sprawdzenia terminarza dla każdej z drużyn. Za pomocą paczki identity dodano możliwość
tworzenia kont i logowania się na nie. Zalogowani użytkownicy mają możliwość aby dodać ulubione drużyny do swojego konta.

Do aplikacji można również dodać więcej informacji statystycznych na przykład informację o najlepszych strzelcach danej ligi. Dobrym pomysłem byłoby umieszczenie pod spodem tabeli małą legendę informującą
co daje zajęcie konkretnego miejsca (spadek, awans do ligi mistrzów). Ładniej by też wyglądała aplikacja gdyby w tabelach obok nazw drużyn dodano ikonki z herbami danych klubów.

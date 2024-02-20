----- Proces realizacji projektu -----
1. Rozeznanie się w tematyce projektu, zaplanowanie aplikacji.
2. Zapoznanie się z ideą MVC, instalacja odpowiednich narzędzi.
3. Stworzenie modeli - z odpowiednimi relacjami, kontrolerów i widoków.
   a) w modelach roboczo zastosowałem zmienne typu string zamiast np. DateTime, gdyż uznałem, że zmniejszy to później ewentualne problemy związane z konwersjami.
   b) początkowo, chciałem stworzyć model drużyny i dwie drużyny miałyby być przypisywane do meczu. Umożliwiłoby to chociażby dodawanie drużyn do ulubionych. Podejście to sprawiało mi problemy i uznałem że na początek uproszczę modele.
6. Utworzenie migracji do bazy danych (SQL server).
7. Utworzenie danych w pliku Seed.
8. Wgranie danych do bazy.
9. Aktualizacja widoków, wyświetlanie danych w odpowiednich widokach.
10. Próba stworzenia modelu łączącego modele meczy i kolejek, aby informacje o obu tych obiektach dało się wyświetlić na jednym widoku (zakończona niepowodzeniem - koniec czasu oraz problemy z relacjami podczas wgrywania danych do bazy).


----- Do poprawy -----
1. Zmiana typów w obiektach (np. na DateTime itd. Umozliwiłoby to choćby łatwiejsze sortowanie względem danych wartości).
2. Strona wyświetlająca się jako widok 'Match' powinna umożliwić nawigowanie po kolejkach i wyświetlanie meczy tylko z aktualnie wybranej kolejki.

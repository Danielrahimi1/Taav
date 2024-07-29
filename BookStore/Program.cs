using static System.Console;

var bookStore = new BookStore("Genesis", "Antartica");
WriteLine($"Bookstore {bookStore.Name} opened!");
WriteLine(bookStore.Consult("Mohammad"));

var greenBookStore = new OnlineBookStore("Green", "Shiraz", "greenbook.ir");
WriteLine(greenBookStore.LendBook("Introduction to Algorithms", "Danial"));
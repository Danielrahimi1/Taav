public class BookStore
{
    public BookStore(string name,
    string address,
    bool hasCaffee = false,
    bool hasStationary = false,
    bool hasCozyReadingNook = false)
    {
        Name = name;
        Address = address;
        HasCaffee = hasCaffee;
        HasCozyReadingNook = hasCozyReadingNook;
        HasStationary = hasStationary;
    }
    public string Name { get; set; }
    public string Address { get; set; }
    public bool HasCaffee { get; set; }
    public bool HasCozyReadingNook { get; set; }
    public bool HasStationary { get; set; }

    public string Consult(string customerName) => $"Welcome to {Name} book store {customerName}.";

}
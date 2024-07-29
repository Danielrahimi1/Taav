public class OnlineBookStore : BookStore
{
    public OnlineBookStore(
        string name,
        string address,
        string webAddress,
        bool hasStationary = false)
         : base(name, address, hasStationary: hasStationary)
    {
        WebAddress = webAddress;
    }

    public string WebAddress { get; set; }

    public string LendBook(string book, string customer) => $"Weclome, dear {customer} now the {book} book is yours until 2 weeks, enjoy.";
}
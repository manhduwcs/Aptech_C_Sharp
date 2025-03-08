namespace NSBook {
    public interface IBook {
        string ID {get; set;}
        string Name {get; set;}
        string AuthorName {get; set;}
        string Subject {get;set;}
        double BuyingPrice {get;set;}
        double SellingPrice{get;set;}
        void ShowDetail();
        void SetDetail(string name, string authorName, string subject, double buyingPrice);
        void setSellingPrice(double sellingPrice);
    }
}
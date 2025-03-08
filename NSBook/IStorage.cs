namespace NSBook{
    internal interface IStorage{
        int Count{get;set;}
        Book[] BookStore {get;set;}

        Book this[int index]{get;set;}

        void AddANewBook();
        void RemoveABook(string id);
        bool IsABook(string id);
    }
}
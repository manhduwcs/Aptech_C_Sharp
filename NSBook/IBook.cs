namespace NSBook {
    public interface IBook {
        int ID{get;set;}
        string Name{get;set;}
        DateTime PublishDate{get;set;}
        string Author{get;set;}
        string Language{get;set;}
        float AveragePrice{get;}

        public int this[int index]{get;set;}
        void Display();
    }
}
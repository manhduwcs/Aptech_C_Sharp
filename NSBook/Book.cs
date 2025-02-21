namespace NSBook
{
    class Book : IBook
    {
        private static int globalID { get; set; }
        public int[] PriceList = new int[5];
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        private float _averagePrice { get; set; }
        public float AveragePrice
        {
            get => _averagePrice;
        }

        public Book()
        {
            globalID++;
            ID = globalID;
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < PriceList.Length) return PriceList[index];
                else throw new IndexOutOfRangeException("Invalid index");
            }
            // get => PriceList[index];
            set => PriceList[index] = value;
        }
        public void Display()
        {
            Console.WriteLine($"Name : {Name}, PublishDate : {PublishDate}, Author : {Author}, Language : {Language}, AveragePrice = {AveragePrice}\n");
        }
        public void Calculate()
        {
            float Sum = 0;
            int count = 0;
            for (int i = 0; i < PriceList.Length; i++)
            {
                if (PriceList[i] == 0) continue;
                Sum += PriceList[i];
                count++;
            }
            if (Sum == 0) throw new Exception("Price List don't have any element !");
            _averagePrice = Sum / count;
        }
    }
}


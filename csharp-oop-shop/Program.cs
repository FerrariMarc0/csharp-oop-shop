namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creazione nuovo prodotto
            Product pc = new Product("Dell vostro", " Computer portatile Fattore di forma: Clamshell. Famiglia processore: IntelCore i5 Modello del processore: i5-1135G7. Dimensioni schermo: 396 cm (15.6\") Tipologia HD: Full HD Risoluzione del display: 1920 x 1080 Pixel", 343.00, 21);

            int productId = pc.GetProductId();
            string name = pc.Name;
            string extendedName = pc.ExtendedProductName();
            string description = pc.Description;
            double basicPrice = pc.Price;
            double vat = pc.Vat;
            double vatIncluded = pc.PricePlusVatCalculator();

            Console.WriteLine($"ID prodotto: {productId}\nModello: {name}\nNome completo del modello: {extendedName}\nDescrizione: {description}\nIva: {vat}\nPrezzo base: {basicPrice}\nPrezzo iva compresa: {vatIncluded}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        private int productId;
        private string name;
        private string description;
        private double price;
        private double vat;

        //COSTRUTTORI
        public Product(string name, string description, double price, double vat)
        {
            this.productId = RandomCodeGenerator();
            this.name = name;
            this.description = description;
            this.price = price;
            this.vat = vat;
        }

        //GETTERS & SETTERS
        public int GetProductId()
        { return productId; }
        public string Name
        { get { return name; } set {  name = value; } }
        public string Description
        { get { return description; } set {  description = value; } }
        public double Price
        { get { return price; } set { price = value; } }
        public double Vat { get {  return vat; } set {  vat = value; } }


        //METODI
        public int RandomCodeGenerator()
        {
            Random random = new Random();
            int randomCode = random.Next(10000000, 99999999);
            return randomCode;
        }

        public double PricePlusVatCalculator()
        {
            double result = price * (vat / 100.0);
            return result;
        }

        public string ExtendedProductName()
        {
            string extendedName = productId.ToString() + " - " + name;
            return extendedName;
        }
    }
}

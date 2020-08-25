using CreditCardManagement.CardReader;
using CreditCardManagement.ChainOfResponsibility;
using System;

namespace CreditCardManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Read credit card detail from reader
            ICardReader reader = new CardReaderUtil();
            CardDetails cardDetails= reader.ReadCardDetail();

            // Pass this obj to Creator
            CreditCardCreator creator = new CreditCardCreator();
            CreditCard creditCard = creator.GetCard(cardDetails);

            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Holder Name: {0}\ncard Number: {1}\nExpiry Date: {2}",
                creditCard.CardHolderName, creditCard.CardNumber, creditCard.ExpiryDate);

            Console.ReadKey();
        }
    }
}

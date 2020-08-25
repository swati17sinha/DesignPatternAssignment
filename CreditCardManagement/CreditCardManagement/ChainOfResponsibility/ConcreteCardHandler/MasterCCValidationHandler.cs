using CreditCardManagement.Enums;
using System;

namespace CreditCardManagement.ChainOfResponsibility.ConcreteCardHandler
{
    public class MasterCCValidationHandler: CardValidationHandler
    {
        public MasterCCValidationHandler(CardValidationHandler handler): base(handler)
        {

        }
        public override CardType Handle(string cardNumber)
        {
            if (cardNumber.Substring(0,1) == "5" && 
                (int.Parse(cardNumber[1].ToString()) >=1
                 && int.Parse(cardNumber[1].ToString()) <= 5)
                 && cardNumber.Length.Equals(16))
            {
                Console.WriteLine("Master Card Handler");
                return CardType.MasterCC;
            }
            else
            {
                return base.Handle(cardNumber);
            }
        }
    }
}

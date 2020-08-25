using CreditCardManagement.ChainOfResponsibility.ConcreteCardHandler;
using CreditCardManagement.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardManagement.ChainOfResponsibility
{
    class CreditCardCreator
    {
        CardValidationHandler chain;
        public CreditCardCreator()
        {
            BuildChain();
        }

        private void BuildChain()
        {
            chain = new MasterCCValidationHandler(new VisaCCValidationHandler(new AmExCCValidationHandler(new DiscoverValidationHandler(null))));
        }

        public CreditCard GetCard(CardDetails cardDetails)
        {
            cardDetails.CardType = chain.Handle(cardDetails.CardNumber);
            Console.WriteLine("Card Type is " + cardDetails.CardType.ToString());
            
            CardFactory factory = new CardGenerator();
            return factory.GetCreditCard(cardDetails);
        }
    }
}

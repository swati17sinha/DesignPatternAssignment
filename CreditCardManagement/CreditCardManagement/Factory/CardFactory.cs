using CreditCardManagement.Enums;

namespace CreditCardManagement.Factory
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard(CardDetails cardDetails);
    }

    class CardGenerator : CardFactory
    {       
        public override CreditCard GetCreditCard(CardDetails cardDetails)
        {
            CreditCard cardObj = null;
            switch (cardDetails.CardType)
            {
                case CardType.MasterCC:
                    cardObj = new MasterCC(cardDetails);
                    break;
                case CardType.VisaCC:
                    cardObj = new VisaCC(cardDetails);
                    break;
                case CardType.AmExCC:
                    cardObj = new AmExCC(cardDetails);
                    break;
                default:
                    break;
            }
            return cardObj;
        }
    }
}

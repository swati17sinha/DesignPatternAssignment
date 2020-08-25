using CreditCardManagement.Enums;

namespace CreditCardManagement.ChainOfResponsibility
{
    public class CardValidationHandler
    {
        
        private CardValidationHandler _nextHandler;

        public CardValidationHandler(CardValidationHandler handler)
        {
            this._nextHandler = handler;
        }

        public virtual CardType Handle(string cardNumber)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(cardNumber);
            }
            else
            {
                return CardType.InvalidCard;
            }
        }
    }
}

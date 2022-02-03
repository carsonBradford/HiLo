
    /// <summary>
    /// A Deck contains a given amount of cards.
    /// 
    /// The responsibility of Deck is to keep track of the order of the cards in 
    /// the deck, shuffle the deck and draw the next card in the deck
    /// </summary>
public class Deck
{
    public List<Card> _cards = new List<Card>  {};
    public List<Card> _shuffledCards = new List<Card> {};
    public int _cardCount = 0;

    public Random rand = new Random();
    
    /// <summary>
        /// Constructs a new instance of Deck
        /// </summary>
    public Deck()
    {
       for (int i = 1; i < 14; i++)
       {
           _cards.Add(new Card(i));
       }
    }   

    public Card drawNext()
    {
        return _cards[_cardCount];
        _cardCount += 1;
    }

    public void shuffleDeck()
    {
        for (int i = 0; i < _cards.Capacity; i++)
        {
            int num = rand.Next(0,_cards.Capacity);
            _shuffledCards.Add(_cards[num]);
            _cards.RemoveAt(num);
        }
    }
}
       

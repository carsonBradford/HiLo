
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
        int tempCount = _cardCount;
        _cardCount += 1;
        return _shuffledCards[tempCount];
        
    }

    public void shuffleDeck()
    {
        for (int i = 0; i < _cards.Capacity; i++)
        {
            // int num = rand.Next(_cards.Capacity);
            // _shuffledCards.Add(_cards[num]);
            // _cards.RemoveAt(num);

            _shuffledCards = _cards.OrderBy(a => rand.Next()).ToList();
        }
    }

    public void DisplayDeck()
    {
        foreach (Card card in _shuffledCards)
        {
            card.DisplayCard();
        }
    }
}
       

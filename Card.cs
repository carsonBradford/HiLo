
/// <summary>
     /// A card with both a face and a value.
    /// 
    /// The responsibility of Card is to keep track of it's face and it's value
    /// </summary>
public class Card
{
    public int _value; // numeric value of card
    public string _face; // face of card (allows program to display jack,queen,king, and ace in program.)

    /// <summary>
        /// Constructs a new instance of Card and allows the user to select it's values.
        /// </summary>
    public Card(int value = 1)
    {
        _value = value;
        if (value == 11)
        {
            _face = "Jack";
        }
        else if (value == 12)
        {
            _face = "Queen";
        }
        else if (value == 13)
        {
            _face = "King";
        }
        else if (value == 1)
        {
            _face = "Ace";
        }
        else
        {
            _face = _value.ToString();
        }
    }

        /// <summary>
        /// Prints the face of the card to the console
        /// </summary>
    public void DisplayCard()
    {
        Console.WriteLine(_face);
    }

    /// <summary>
        /// returns the face of the card
        /// </summary>
    public string GetFace()
    {
       return _face;
    }

    /// <summary>
        /// returns the value of the card
        /// </summary>
    public int GetValue()
    {
        return _value;
    }
}
       

using System;
namespace ProjectDrunk


{
	public class PlayingCard : IComparable<PlayingCard>
	{
		private int value;
		private int suit;
		private String cardImage;

		public int Value => value;
		public string ValueName => ValueToName(value);

		public int Suit => suit;
		public string SuitName => SuitToName(suit);

		public String CardImage => cardImage;

        public PlayingCard(int value, int suit, String cardImage)
		{
			this.value = value;
			this.suit = suit;
			this.cardImage = cardImage;
		}

		private string ValueToName(int n)
		{
			switch (n)
			{
				case 0:
					return "Ace";
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
					return (n + 1).ToString();
				case 10:
					return "Jack";
				case 11:
					return "Queen";
				case 12:
					return "King";
				default:
					throw new ArgumentException("Unrecognized card value.");

			}
		}

		private string SuitToName(int s)
		{
			switch (s)
			{
				case 0:
					return "Clubs";
				case 1:
					return "Diamonds";
				case 2:
					return "Spades";
				case 3:
					return "Hearts";
				default:
					throw new ArgumentException("Unrecognized card suit");
			}
		}

		public int CompareTo(PlayingCard other)
		{
			int result = this.Suit.CompareTo(other.Suit);

			if (result != 0) return result;

			return this.Value.CompareTo(other.Value);
		}

		public override string ToString()
		{
			return String.Format("{0} of {1}", ValueName, SuitName);
		}
	}
}

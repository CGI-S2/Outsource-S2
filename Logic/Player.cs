namespace Logic
{
	public class Player
	{
		private string playerName = string.Empty;

		public string PlayerName
		{
			get { return playerName; }
			set { playerName = value; }
		}

		private int playerScore;

		public int PlayerScore
		{
			get { return playerScore; }
			set { playerScore = value; }
		}
	}
}

namespace Logic
{
	public class CalculateBP
	{
		public void AppendBattlePoints(List<Player> players)
		{
			foreach (var player in players)
			{
				CalculateAmountOfPoints(player);
			}
		}

		public static int CalculateAmountOfPoints(Player player)
		{
			//Algorithm to compare players and 
			bool battleWon = true;
			int playerScore;
			try
			{
				int amountOfPoints;
				if (battleWon)
				{
					Random random = new();
					//Battle is won so points will be added to the player that won.

					if (player.PlayerScore > 100)
					{
						amountOfPoints = random.Next(20, 31);
					}
					else
					{
						amountOfPoints = random.Next(20, 41);
					}

					playerScore = player.PlayerScore + amountOfPoints;
					return playerScore;
				}

				else
				{
					//Battle is lost so points will be deducted from the player that lost.
					Random random = new();

					if (player.PlayerScore < 100)
					{
						amountOfPoints = random.Next(1, 11);
					}
					else
					{
						amountOfPoints = random.Next(10, 21);
					}

					playerScore = player.PlayerScore - amountOfPoints;
					return playerScore;
				}
			}

			catch (Exception ex)
			{
				throw new Exception("Couldn't calculate the amount of points", ex);
			}
		}
	}
}
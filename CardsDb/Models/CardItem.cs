namespace CardsDb.Models
{
	public class CardItem
	{
/*        private static readonly string[] Colors = new[]
		{
			"Red", "Blue", "Yellow", "Green", "Purple"
		};
*/
        public long Id { get; set; }
		public string? Name { get; set; }
		public int Cost { get; set; }
		public string? Color { get; set; }
	}
}


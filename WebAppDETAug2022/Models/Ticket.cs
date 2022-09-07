namespace WebAppDETAug2022.Models
{
	public class Tickets
	{
		public string Category { get; set; }
		public int Price { get; set; }
		public int MaxLimit { get; set; }
		public int Id { get; internal set; }

		internal static void Add(Tickets ticket)
		{
			throw new NotImplementedException();
		}

		internal static object FindIndex(Func<object, bool> value)
		{
			throw new NotImplementedException();
		}
	}
}

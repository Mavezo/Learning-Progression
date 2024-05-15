namespace ASP.NET_MVC_QuestRoom.Models
{
	public class PageViewModel
	{
		public int CurrentPageNumber { get; private set; }
		public int TotalPages { get; private set; }
		public PageViewModel(int count, int pageNumber, int pageSize)
		{
			CurrentPageNumber = pageNumber;
			TotalPages = (int)Math.Ceiling(count / (double)pageSize);
		}
		public bool HasPreviousPage
		{
			get
			{
				return CurrentPageNumber > 1;
			}
		}

		public bool HasNextPage
		{
			get
			{
				return CurrentPageNumber < TotalPages;
			}
		}

	}
}

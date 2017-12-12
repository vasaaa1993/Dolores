namespace Dolores.Bll.Helpers
{
	public enum SearchField: byte
	{
		SF_Contract,
		SF_Phone,
		SF_Name
	}

	public class SearchParams
	{
		public SearchField field;
		public string query;
	}
}

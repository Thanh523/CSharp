namespace bai12
{
	public class XuLyChuoi
	{
		public static string ChuThuong(string chuoi)
		{
			return chuoi.ToLower();
		}

		public static string ChuHoa(string chuoi)
		{
			return chuoi.ToUpper();
		}

		public static int DemSoTu(string chuoi)
		{
			return chuoi.Split(
				new[] { ' ', '\t', '\r', '\n' },
				StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}
}

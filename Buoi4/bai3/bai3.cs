using System.Globalization;

Console.Write("Nhập ngày tháng năm (dd/MM/yyyy): ");
string? input = Console.ReadLine();

if (DateTime.TryParseExact(
		input,
		"dd/MM/yyyy",
		CultureInfo.InvariantCulture,
		DateTimeStyles.None,
		out DateTime date))
{
	Console.WriteLine($"Ngày hôm sau: {date.AddDays(1):dd/MM/yyyy}");
}
else
{
	Console.WriteLine("Ngày không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
}

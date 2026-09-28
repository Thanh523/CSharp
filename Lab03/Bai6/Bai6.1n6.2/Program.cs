using System;
using System.Collections;
using System.Linq;

RunProgram();

static void RunProgram()
{
    var dsMon = DuLieu.DS_Mon();
    var dsHe = DuLieu.DS_He();

    var cauA = from mon in dsMon
               join he in dsHe on mon.He equals he.MaHe
               select new
               {
                   he.TenHe,
                   mon.MaMon,
                   mon.TenMon
               };

    cauA.Dump("a. Môn học và tên hệ");

    var cauB = dsHe
        .GroupJoin(
            dsMon,
            he => he.MaHe,
            mon => mon.He,
            (he, cacMon) => new { he, cacMon })
        .SelectMany(
            x => x.cacMon.DefaultIfEmpty(),
            (x, mon) => new { x.he, mon })
        .Where(x => x.mon == null)
        .Select(x => new { x.he.MaHe, x.he.TenHe });

    cauB.Dump("b. Hệ chưa có môn học");

    var heVaMon = from he in dsHe
                  join mon in dsMon on he.MaHe equals mon.He into nhomMon
                  from mon in nhomMon.DefaultIfEmpty()
                  select new
                  {
                      MaHe = he.MaHe,
                      TenHe = he.TenHe,
                      MaMon = mon?.MaMon ?? "",
                      TenMon = mon?.TenMon ?? ""
                  };

    var monKhongCoHe = dsMon
        .Where(mon => !dsHe.Any(he => he.MaHe == mon.He))
        .Select(mon => new
        {
            MaHe = mon.He,
            TenHe = "",
            MaMon = mon.MaMon,
            TenMon = mon.TenMon
        });

    var cauC = heVaMon.Concat(monKhongCoHe);
    cauC.Dump("c. Toàn bộ hệ và môn, kể cả không khớp");

    var heChuaCoMon = dsHe
        .Where(he => !dsMon.Any(mon => mon.He == he.MaHe))
        .Select(he => new
        {
            MaHe = he.MaHe,
            TenHe = he.TenHe,
            MaMon = "",
            TenMon = ""
        });

    var cauD = heChuaCoMon.Concat(monKhongCoHe);
    cauD.Dump("d. Hệ chưa có môn và môn chưa có hệ");

    var cauE = (from mon in dsMon
                join he in dsHe on mon.He equals he.MaHe into nhomHe
                from he in nhomHe.DefaultIfEmpty()
                orderby mon.SoTiet descending, mon.MaMon
                select new
                {
                    TenHe = he?.TenHe ?? "Chưa khai báo hệ",
                    mon.MaMon,
                    mon.TenMon,
                    mon.SoTiet
                })
                .Take(5);

    cauE.Dump("e. 5 môn có số tiết cao nhất");

    var cauF = from he in dsHe
               join mon in dsMon on he.MaHe equals mon.He into nhomMon
               select new
               {
                   he.MaHe,
                   he.TenHe,
                   TongSoMon = nhomMon.Count()
               };

    cauF.Dump("f. Tổng số môn của mỗi hệ");

    var cauG = dsMon
        .Select(mon => mon.SoTiet)
        .Distinct()
        .Count();

    cauG.Dump("g. Số loại số tiết khác nhau");

    var cauH = dsMon
        .FirstOrDefault(mon => mon.TenMon.StartsWith("Lập trình"));

    cauH.Dump("h. Môn đầu tiên bắt đầu bằng Lập trình");

    var cauI = dsHe
        .GroupJoin(
            dsMon,
            he => he.MaHe,
            mon => mon.He,
            (he, cacMon) => new
            {
                he.MaHe,
                he.TenHe,
                CacMon = cacMon
                    .OrderBy(mon => mon.MaMon)
                    .Select((mon, index) => new
                    {
                        STT = index + 1,
                        mon.MaMon,
                        mon.TenMon,
                        mon.SoTiet
                    })
                    .ToList()
            });

    cauI.Dump("i. Môn theo hệ và số thứ tự trong mỗi nhóm");
}

public static class DumpExtensions
{
    public static void Dump<T>(this T value, string? label = null)
    {
        if (!string.IsNullOrWhiteSpace(label))
        {
            Console.WriteLine($"\n{label}:");
        }

        if (value is null)
        {
            Console.WriteLine("<null>");
            return;
        }

        if (value is string s)
        {
            Console.WriteLine(s);
            return;
        }

        if (value is IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                WriteObject(item, 0);
            }
            return;
        }

        WriteObject(value, 0);
    }

    private static void WriteObject(object value, int indent)
    {
        string indentText = new string(' ', indent);

        if (value is string s)
        {
            Console.WriteLine($"{indentText}{s}");
            return;
        }

        var type = value.GetType();
        var props = type.GetProperties();

        if (props.Length == 0)
        {
            Console.WriteLine($"{indentText}{value}");
            return;
        }

        foreach (var prop in props)
        {
            var propValue = prop.GetValue(value);
            Console.WriteLine($"{indentText}{prop.Name}: {FormatValue(propValue)}");
        }
    }

    private static string FormatValue(object? value)
    {
        if (value is null)
            return "<null>";

        if (value is string s)
            return s;

        if (value is IEnumerable enumerable && value is not string)
        {
            return string.Join(", ", enumerable.Cast<object?>().Select(item => item is null ? "<null>" : item.ToString()));
        }

        return value.ToString() ?? "<null>";
    }
}

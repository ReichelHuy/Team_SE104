using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class PhanQuyen
{
    public int MaPq { get; set; }

    public string? MaPb { get; set; }

    public int? MaTrang { get; set; }

    public ulong Them { get; set; }

    public ulong Sua { get; set; }

    public ulong Xoa { get; set; }

    public ulong Xem { get; set; }
}

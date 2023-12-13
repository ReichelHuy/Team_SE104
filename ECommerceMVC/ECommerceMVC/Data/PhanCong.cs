using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class PhanCong
{
    public int MaPc { get; set; }

    public string MaNv { get; set; } = null!;

    public string MaPb { get; set; } = null!;

    public DateTime? NgayPc { get; set; }

    public ulong? HieuLuc { get; set; }
}

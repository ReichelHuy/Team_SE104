using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class Vchitiethoadon
{
    public int MaCt { get; set; }

    public int MaHd { get; set; }

    public int MaHh { get; set; }

    public float DonGia { get; set; }

    public int SoLuong { get; set; }

    public float GiamGia { get; set; }

    public string TenHh { get; set; } = null!;
}

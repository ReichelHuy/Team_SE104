﻿using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? MatKhau { get; set; }
}
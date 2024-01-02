using AutoMapper;
using ShopMVC8.Data;
using ShopMVC8.ViewModels;

public class AutomapperCategory : Profile
{
    public AutomapperCategory()
    {
        CreateMap<QuanliHangHoaVM, HangHoa>();
        // Thêm các quy tắc ánh xạ khác nếu cần
    }
}

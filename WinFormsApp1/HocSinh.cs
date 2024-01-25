class HocSinh : ConNguoi
{
    public HocSinh() { }
    public HocSinh(string id, string ten, DateTime ngaysinh, string diachi, string email, string phone, string gioitinh) : base(id, ten, ngaysinh, diachi, email, phone, gioitinh )
    {

    }
    
    ~HocSinh() { }
}
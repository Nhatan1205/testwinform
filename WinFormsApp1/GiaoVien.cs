class GiaoVien : ConNguoi
{
    public GiaoVien() { }
    public GiaoVien(string id, string ten, DateTime ngaysinh, string diachi, string email, string phone, string gioitinh) : base(id, ten, ngaysinh, diachi, email, phone, gioitinh)
    {

    }
   
    ~GiaoVien() { }
}
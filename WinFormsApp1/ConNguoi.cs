using System.Runtime.Serialization;

class ConNguoi
{
    protected string id;
    protected string ten;
    protected DateTime ngaysinh;
    protected string diachi;
    protected string email;
    protected string phone;
    protected string gioitinh;

    public ConNguoi() { }
    public ConNguoi(string id, string ten, DateTime ngaysinh, string diachi, string email, string phone, string gioitinh)
    {
        this.id = id;
        this.ten = ten;
        this.ngaysinh = ngaysinh;
        this.diachi = diachi;
        this.email = email;
        this.phone = phone;
        this.gioitinh = gioitinh;
    }
    public string Id
    {
        get { return id; }
    }
    public string Ten
    {
        get { return ten; }
    }
    public string Diachi
    {
        get { return diachi; }
    }
    public DateTime Ngaysinh
    {
        get { return ngaysinh; }
    }
    public string Email
    {
        get { return email; }
    }
    public string Phone
    {
        get { return phone; }
    }
    public string Gioitinh
    {
        get { return gioitinh; }
    }
    ~ConNguoi() { }
}

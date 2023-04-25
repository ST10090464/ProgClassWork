namespace ProductsWebApp.Models
{
    public class Supplier
    {
        public string?SupplierID { get; set; }
        public string?Name { get; set; }
        public string?Phone { get; set; }
        public string?Username { get; set; }
        public string?Password { get; set; }


        public Supplier(string? supplierID, string? name, string? phone)
        {
            SupplierID = supplierID;
            Name = name;
            Phone = phone;
        }

        public Supplier(string? Username, string? Password) 
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}

namespace API.Entities
{
    public class AppUser
    {
        // for test
        
        public int id {get;set;}
        public string UserName {get;set;}

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        
        
        
        

    }
}
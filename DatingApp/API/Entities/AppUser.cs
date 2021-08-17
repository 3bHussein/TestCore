namespace API.Entities
{
    public class AppUser
    {
        // for test
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public int id {get;set;}


        public string UserName {get;set;}

    }
}
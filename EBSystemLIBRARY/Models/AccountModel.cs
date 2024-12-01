
namespace EBSystemLIBRARY.Models
{
    public class AccountModel
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private string text7;

        public AccountModel(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.text7 = text7;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string StudentID { get; set; }

        public void SaveAccount(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }
    }
}

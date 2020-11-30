using System;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Data
{
    public class LoginService
    {
        private int loginstat;

        public void setlogin(int login){
            this.loginstat=login;
        }
        public int getlogin(){
            return this.loginstat;
        }

        public Task<int> GetLoginAsync() //return login status
        {
            return Task.FromResult(getlogin());
        }

        public Task<MemberData> GetMemberInfo()
        {
            
            return Task.FromResult(new MemberData
            {
                Name = "Kim",
            });
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace libraryhw
{
    public class normalUser:basicUser
    {
        private int borrowMax = 3;
        // constructor, set userStatus at 1 (for normal user clearance)
        public normalUser(string username, string password):base(username, password, 1)
        {

        }
        public void convertToHighLevel(normalUser user)
        {
            string u = user.username;
            string p = user.password;
            new highLevelUser(u, p);

        }
        // borrowing an additonal x books
        public override bool bookLimit(int x) 
        {
            if (this.booksBorrowed + x <= borrowMax) return false; 
            else return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace libraryhw
{
    public class highLevelUser:basicUser
    {
        private int borrowMax = 5;

        public highLevelUser(string username, string password) : base(username, password, 2)
        {

        }
        public void convertToNormal(normalUser user)
        {
            string u = user.username;
            string p = user.password;
            new normalUser(u, p);
        }

        public override bool bookLimit(int x)
        {
            if (this.booksBorrowed + x <= borrowMax) return false; // have yet to reach book limit after borrowing these books
            else return true;
        }
    }
}
using System;

namespace TrashGrounds.DataBase.DBClasses
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string Nickname { get; set; }
        
        public int Avatar_asset_id { get; set; }
        
        public DateTime Reg_date { get; set; }
    }
}
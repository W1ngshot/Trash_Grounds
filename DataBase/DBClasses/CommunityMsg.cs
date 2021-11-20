using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashGrounds.DataBase.DBClasses
{
    [Table("CommunityMsgs")]
    public class CommunityMsg
    {
        public int Id { get; set; }
        
        public string Text { get; set; }
        
        public DateTime Date { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        
        public int image_asset_id { get; set; }
    }
}
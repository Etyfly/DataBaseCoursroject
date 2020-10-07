using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_KP.Models
{
  
    public class HandModel
    {
        [Key]
        public int hand_id { set; get; }
        public int user_id { set; get; }
        public int hand_type_id { set; get; }
    }
}
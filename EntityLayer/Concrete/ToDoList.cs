using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ToDoList
    {
        [Key]
        public int ToDoId { get; set; }
        public string ToDoTitle { get; set; }
        public bool ToDoStatus { get; set; }
    }
}

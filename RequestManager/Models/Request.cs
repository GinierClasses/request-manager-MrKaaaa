using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestManager.Models
{
    public class Request
    {
        public Request(int id, string title, string description, DateTime createDon, DateTime updateDon, Status status, Priority priority)
        {
            Id = id;
            Title = title;
            Description = description;
            CreateDon = createDon;
            UpdateDon = updateDon;
            Status = status;
            Priority = priority;
        }

        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDon { get; set; }
        public DateTime UpdateDon { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }

    }
}

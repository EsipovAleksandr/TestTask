using System;
using System.Collections.Generic;

namespace TestTaskAionys.Model
{
    public class ClientTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string ClientAddress { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? ClientsId { get; set; }

        public virtual Clients Clients { get; set; }
    }
}
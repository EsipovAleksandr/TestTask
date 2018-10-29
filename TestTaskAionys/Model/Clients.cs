using System.Collections.Generic;

namespace TestTaskAionys.Model
{
    public class Clients
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<ClientTask> ClientTasks { get; set; }
        public Clients()
        {
            ClientTasks = new List<ClientTask>();
        }
    }
}
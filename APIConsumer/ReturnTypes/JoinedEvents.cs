using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class JoinedEvents
{
    public int Id { get; set; }
    public int UserID { get; set; }
    public int EventID { get; set; }
    public User? User { get; set; }
    public EventModel? Event { get; set; }

    public JoinedEvents()
    {

    }

    public JoinedEvents(int user, int model)
    {
        UserID = user;
        EventID = model;
    }
}


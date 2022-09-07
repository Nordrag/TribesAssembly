using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RequestedPeople
{
    public int Id { get; set; }
    public int MinAge { get; set; }
    public int MaxAge { get; set; }
    public int Gender { get; set; }
    public EventModel? HostEvent { get; set; }

    public RequestedPeople()
    {

    }

    public RequestedPeople(int minAge, int maxAge, int gender)
    {
        MinAge = minAge;
        MaxAge = maxAge;
        Gender = gender;
    }
}


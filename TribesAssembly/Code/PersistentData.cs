
public class PersistentData
{
    public User User;
  
    public EventModel Event;

    public PersistentData()
    {
        User = new User();      
        Event = new EventModel();
    }

    public PersistentData(User user, EventModel model)
    {
        User = user;     
        Event = model;
    } 
}


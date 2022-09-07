using Refit;

public interface IDatabaseQuery
{
    [Get("/User")]
    Task<List<User>> GetUsers();

    [Get("/User/email")]
    Task<User> GetUser(string email);

    [Post("/User")]
    Task CreateUser([Body] User user);

    [Get("/Events/category")]
    Task<List<EventModel>> GetEventsByType(EventMetaType type);

    [Get("/Events")]
    Task<EventModel> GetEventById(int Id);

    [Post("/Events")]
    Task<EventModel> CreateNewEvent([Body]EventModel newEvent);

    [Get("/Events")]
    Task<List<TagsUsed>> GetEventsByTag(string tag);

    [Post("/JoinedEvents")]
    Task JoinEvent(JoinedEvents join);
}


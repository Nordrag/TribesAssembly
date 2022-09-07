User model = new User();
model.FirstName = "Iván";
model.LastName = "Boros";
model.Email = "mail@porg.com";
model.Password = "123456";

ServerConnection connection = new ServerConnection();

connection.PostRequest<User>("api/User", model);

Console.ReadLine();
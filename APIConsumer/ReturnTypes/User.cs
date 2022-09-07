using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }   
    public string? Email { get; set; }   
    public string? Password { get; set; }   
    public string? FirstName { get; set; }   
    public string? LastName { get; set; }  
    public int Gender { get; set; }
    public DateTime BirthDate { get; set; }


    public int GetAge()
    {
        int res = 10;
        var today = DateTime.Today;
        var age = today.Year - BirthDate.Year;

        if (BirthDate.Date > today.AddYears(-age)) age--;

        res = age;

        return res;
    }

    public User(int id, string? email, string? password, string? firstName, string? lastName, int gender)
    {
        Id = id;
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;     
        Gender = gender;    
    }

    public User()
    {

    }
}


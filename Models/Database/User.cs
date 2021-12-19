using System;

namespace TrashGrounds.Models.Database;

public class User
{
    public int Id { get; set; }

    public string Email { get; set; }
    
    public string? Status { get; set; }

    public List<byte> PasswordBytes
    {
        get => Password.Split(',').Select(byte.Parse).ToList();
        set => Password = string.Join(",", value);
    }

    public string Password { get; set; }

    public string Nickname { get; set; }
    
    public DateTime Reg_date { get; set; }
}

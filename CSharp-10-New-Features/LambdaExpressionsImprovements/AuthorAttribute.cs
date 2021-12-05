using System;

[AttributeUsage(AttributeTargets.Method)]
public class AuthorAttribute : Attribute
{
    public AuthorAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}

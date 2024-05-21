﻿namespace Typewrite.Infrastructure.Entities;

public class Blog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public List<Post> Posts { get; set; }
}
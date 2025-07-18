using System;

namespace Revision;

public class Student: IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string CourseName { get; set; }
}

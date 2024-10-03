using System;
using System.Collections.Generic;

namespace ASPCoreWebAPI_CRUD_.Models;

public partial class Student
{
    public int Id { get; set; }

    public string StdName { get; set; } = null!;

    public string StdGender { get; set; } = null!;

    public int Age { get; set; }

    public int Standard { get; set; }
}

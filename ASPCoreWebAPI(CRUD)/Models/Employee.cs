using System;
using System.Collections.Generic;

namespace ASPCoreWebAPI_CRUD_.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Department { get; set; } = null!;
}

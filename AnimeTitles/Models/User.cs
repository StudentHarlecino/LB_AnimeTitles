using System;
using System.Collections.Generic;

namespace AnimeTitles.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastNamr { get; set; } = null!;

    public DateOnly DateOfRegistration { get; set; }

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}

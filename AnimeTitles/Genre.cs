using System;
using System.Collections.Generic;

namespace AnimeTitles;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}

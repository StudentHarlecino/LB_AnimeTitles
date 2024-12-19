using System;
using System.Collections.Generic;

namespace AnimeTitles;

public partial class AnimeType
{
    public short Id { get; set; }

    public string TypeOfAnime { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}

using System;
using System.Collections.Generic;

namespace AnimeTitles.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }

    public short IdOfType { get; set; }

    public short IdOfGenre { get; set; }

    public int? IdModerator { get; set; }

    public string OriginalName { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public short YearOfRelease { get; set; }

    public string? Description { get; set; }

    public string? Poster { get; set; }

    public short? CountofSeries { get; set; }

    public string? Duration { get; set; }

    public bool IsComplete { get; set; }

    public string Studio { get; set; } = null!;

    public virtual User? IdModeratorNavigation { get; set; }

    public virtual Genre IdOfGenreNavigation { get; set; } = null!;

    public virtual AnimeType IdOfTypeNavigation { get; set; } = null!;
}

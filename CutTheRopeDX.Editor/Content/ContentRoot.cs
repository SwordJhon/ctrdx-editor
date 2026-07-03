namespace CutTheRopeDX.Editor.Content
{
    /// <summary>Locates the repository's content/ directory by walking up from the app base dir.</summary>
    public static class ContentRoot
    {
        public static string Resolve()
        {
            DirectoryInfo? dir = new(AppContext.BaseDirectory);
            while (dir is not null)
            {
                string candidate = Path.Combine(dir.FullName, "content");
                if (Directory.Exists(Path.Combine(candidate, "maps")))
                {
                    return candidate;
                }
                dir = dir.Parent;
            }
            throw new DirectoryNotFoundException(
                "Could not locate a 'content/maps' directory in any parent of " + AppContext.BaseDirectory +
                ". Expected a 'content' folder containing a 'maps' subfolder.");
        }
    }
}

namespace Naninovel.UI
{
    /// <inheritdoc cref="IPauseUI"/>
    public class FilmScreenPanel : CustomUI, IFilmScreenI
    {
        public virtual int Memories { get; set; }
        protected override void Awake()
        {
            base.Awake();
            setMemories(); 
        }

        protected void setMemories()
        {
            Memories = 12; 
        }

    }
}

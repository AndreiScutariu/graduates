namespace Inheritance
{
    internal abstract class RevolutionaryPlayer : BasePlayer
    {
        public override void Play()
        {
            this.SoundDriver.Play();
            this.VideoDriver.Play();
        }

        public override string Skip(int seconds)
        {
            this.SoundDriver.Skip();
            this.VideoDriver.Skip();
            return "";
        }
    }
}
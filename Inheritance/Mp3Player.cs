namespace Inheritance
{
    abstract class Mp3Player:BasePlayer
    {
        
        public override void Play()
        {
            this.SoundDriver.Play();
        }

        public override string Skip(int seconds)
        {
            this.SoundDriver.Skip();
            return "";
        }
    }
}
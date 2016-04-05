namespace Inheritance
{
    abstract class AviPlayer : BasePlayer
    {

        public override void Play()
        {
            this.VideoDriver.Play();
        }

        public override string Skip(int seconds)
        {
            this.VideoDriver.Skip();
            return "";
        }
    }
}
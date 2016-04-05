namespace Inheritance
{
    internal abstract class BasePlayer
    {
        public Driver SoundDriver { get; }

        public Driver VideoDriver { get; }

        public abstract string Manufacturer { get; }

        public string FileName { get; }

        public abstract void Play();

        public abstract string Skip(int seconds);
    }
}
using System;

namespace Inheritance
{
    internal abstract class BasePlayer
    {
        public abstract string Manufacturer { get; }

        public string FileName { get; }

        public abstract void Play();

        public abstract string Skip(int seconds);
    }

    abstract class Mp3Player:BasePlayer
    {
        
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override string Skip(int seconds)
        {
            throw new NotImplementedException();
        }
    }

    abstract class VideoPlayer : BasePlayer
    {

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override string Skip(int seconds)
        {
            throw new NotImplementedException();
        }
    }

    class SonyMp3Player : Mp3Player
    {
        public override string Manufacturer {
            get
            {
                return "Sony";
            }
        }
    }

    internal class PlayVideoComponent
    {
        public void Play()
        {
        }
    }

    internal class SkipVideoComponent
    {
        public void Skip()
        {
        }
    }



}

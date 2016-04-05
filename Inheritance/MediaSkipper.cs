namespace Inheritance
{
    using System;

    abstract class MediaSkipper : BasePlayer
    {
        public override string Skip(int seconds)
        {
            throw new NotImplementedException();
        }
    }
}
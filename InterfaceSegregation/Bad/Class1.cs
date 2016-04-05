namespace InterfaceSegregation.Bad
{
    internal interface IWorker
    {
        void Work();

        void Eat();
    }

    internal class Worker : IWorker
    {

        public void Work()
        {
            // ....working
        }

        public void Eat()
        {
            // ...... eating in launch break
        }
    }

    internal class SuperWorker : IWorker
    {

        public void Work()
        {
            //.... working much more
        }

        public void Eat()
        {
            //.... eating in launch break
        }
    }

    //internal class Robot : IWorker
    //{

    //    public void Work()
    //    {
    //        //.... working much more
    //    }
    //}

    class Manager
    {
        IWorker worker;

        public void SetWorker(IWorker w)
        {
            worker = w;
        }

        public void Manage()
        {
            worker.Work();
        }
    }
}

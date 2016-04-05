using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    // interface segregation principle - good example
    internal interface IWorker : IFeedable, IWorkable
    {
    }

    interface IWorkable
{
     void Work();
}

interface IFeedable
{
    void Eat();
}

    internal class Worker : IWorkable, IFeedable
    {
        public void Work()
        {
            // ....working
        }

        public void Eat()
        {
            //.... eating in launch break
        }
    }

    internal class SuperWorker : IWorkable, IFeedable
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

    internal class Robot : IWorkable
    {

        public void Work()
        {
            // ....working
        }
    }

    internal class WorkersManager
    {
        private IWorkable worker;

        public void SetWorker(IWorkable w)
        {
            worker = w;
        }

        public void Manage()
        {
            worker.Work();
        }
    }
}

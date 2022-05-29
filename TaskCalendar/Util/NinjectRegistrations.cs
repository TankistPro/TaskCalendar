using Ninject.Modules;
using TaskCalendar.Domain.Interfaces;
using TaskCalendar.Infrastructure.Data.Repository;

namespace TaskCalendar.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ITaskRepository>().To<TaskRepository>();
        }
    }
}
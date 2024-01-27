using MyAcademy_DesignPattern_ChainofResponsibilty.Models;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee nextApprover;
        public void SetNextApprover(Employee supervisor)
        {
            this.nextApprover = supervisor;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}

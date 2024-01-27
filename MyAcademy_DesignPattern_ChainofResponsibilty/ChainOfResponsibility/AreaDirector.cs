using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Context;
using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Entities;
using MyAcademy_DesignPattern_ChainofResponsibilty.Models;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context c = new Context();
            if (req.amount <= 30000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.amount = req.amount;
                customerProcess.name = req.name;
                customerProcess.emplooyeName = "Bölge Müdürü Özlem Çelik";
                customerProcess.descreption = "Müşterinin Talep ettiği kredi tutarı tarafımca Ödenmiştir";
                c.customerProcesses.Add(customerProcess);
                c.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.amount = req.amount;
                customerProcess.name = req.name;
                customerProcess.emplooyeName = "Bölge Müdürü Özlem Çelik";
                customerProcess.descreption = "Müşterinin Talep ettiği kredi tutarı bankanın günlük işlem tutarını aştığı için işlem gerçekleştirilemedi";
                c.customerProcesses.Add(customerProcess);
                c.SaveChanges();

            }
        }
    }
}

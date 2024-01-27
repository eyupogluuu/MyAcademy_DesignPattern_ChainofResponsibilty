using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Context;
using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Entities;
using MyAcademy_DesignPattern_ChainofResponsibilty.Models;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.ChainOfResponsibility
{
    public class ManagerAsisstant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
           Context c = new Context();
            if (req.amount<=20000)
            {
                CustomerProcess customerProcess= new CustomerProcess();
                customerProcess.amount=req.amount;
                customerProcess.name=req.name;
                customerProcess.emplooyeName = "Şube Müdür Yardımcısı Oğuzhan Karal";
                customerProcess.descreption = "Müşterinin Talep ettiği kredi tutarı tarafımca Ödenmiştir";
                c.customerProcesses.Add(customerProcess);
                c.SaveChanges();
            }
            else if (nextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.amount = req.amount;
                customerProcess.name = req.name;
                customerProcess.emplooyeName = "Şube Müdür Yardımcısı Oğuzhan Karal";
                customerProcess.descreption = "Müşterinin Talep ettiği kredi tutarı tarafımca ödenemedi.. Şube Müdürüne Aktarıldı";
                c.customerProcesses.Add(customerProcess);
                c.SaveChanges();

            }

        }
    }
}

using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Context;
using MyAcademy_DesignPattern_ChainofResponsibilty.DAL.Entities;
using MyAcademy_DesignPattern_ChainofResponsibilty.Models;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context c = new Context();
            if (req.amount<=10000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.amount = req.amount;
                customerProcess.name = req.name;
                customerProcess.emplooyeName = "Veznedar - Berkan Baytar";
                customerProcess.descreption = "Müşterinin Talep Ettiği Kredi Tutarı Tarafımca Ödenmiştir";
                c.SaveChanges();
            }
            else if(nextApprover !=null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.amount = req.amount;
               customerProcess.name = req.name;
                customerProcess.emplooyeName = "Veznedar - Berkan Baytar";
                customerProcess.descreption = "İşlem Tamamlanamadı Şube Müdür Yardımcısına Aktarıldı";
                c.customerProcesses.Add(customerProcess);
                c.SaveChanges();
                nextApprover.ProcessRequest(req);
            }
        }
    }
}

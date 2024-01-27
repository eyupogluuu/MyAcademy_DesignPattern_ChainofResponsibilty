using System;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

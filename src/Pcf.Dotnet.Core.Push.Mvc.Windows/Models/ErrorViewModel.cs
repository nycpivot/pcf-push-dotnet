using System;

namespace Pcf.Dotnet.Core.Push.Mvc.Windows.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
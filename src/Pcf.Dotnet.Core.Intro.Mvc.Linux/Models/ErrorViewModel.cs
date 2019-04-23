using System;

namespace Pcf.Dotnet.Core.Intro.Mvc.Linux.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
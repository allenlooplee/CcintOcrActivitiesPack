using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Ccint.Ocr.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;
using UiPath.Shared.Activities.Utilities;
using Ccint.Ocr.Models;
using Ccint.Ocr.Contracts;

namespace Ccint.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.VatInvoiceActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.VatInvoiceActivity_Description))]
    public class VatInvoiceActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.VatInvoice;
        }
    }
}


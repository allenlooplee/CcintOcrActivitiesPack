using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Ccint.Ocr.Activities.Properties;
using Ccint.Ocr.Models;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Ccint.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.AutoReceiptActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.AutoReceiptActivity_Description))]
    public class AutoReceiptActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.AutoReceipt;
        }
    }
}


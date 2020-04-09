using Ccint.Ocr.Activities.Properties;
using Ccint.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;

namespace Ccint.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.AutoReceiptActivity_DisplayName), typeof(Resources))]
    [LocalizedDescription(nameof(Resources.AutoReceiptActivity_Description), typeof(Resources))]
    public class AutoReceiptActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.AutoReceipt;
        }
    }
}


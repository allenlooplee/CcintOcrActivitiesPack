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
    [LocalizedDisplayName(nameof(Resources.BankCardActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.BankCardActivity_Description))]
    public class BankCardActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.BankCard;
        }
    }
}


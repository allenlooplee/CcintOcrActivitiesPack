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
    [LocalizedDisplayName(nameof(Resources.IdCardActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.IdCardActivity_Description))]
    public class IdCardActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.IdCard;
        }
    }
}


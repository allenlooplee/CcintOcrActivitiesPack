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
    [LocalizedDisplayName(nameof(Resources.BusinessLicenseActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.BusinessLicenseActivity_Description))]
    public class BusinessLicenseActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.BusinessLicense;
        }
    }
}


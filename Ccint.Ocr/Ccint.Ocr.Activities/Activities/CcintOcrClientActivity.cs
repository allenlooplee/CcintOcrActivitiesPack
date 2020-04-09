using System;
using System.Activities;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Ccint.Ocr.Activities.Properties;
using Ccint.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Ccint.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.CcintOcrClientActivity_DisplayName), typeof(Resources))]
    [LocalizedDescription(nameof(Resources.CcintOcrClientActivity_Description), typeof(Resources))]
    public class CcintOcrClientActivity : BaseOcrClientActivity
    {
        #region Properties

        [LocalizedDisplayName(nameof(Resources.CcintOcrClientActivity_RecognizerConfig_DisplayName), typeof(Resources))]
        [LocalizedDescription(nameof(Resources.CcintOcrClientActivity_RecognizerConfig_Description), typeof(Resources))]
        [LocalizedCategory(nameof(Resources.Input_Category), typeof(Resources))]
        public InArgument<DataTable> RecognizerConfig { get; set; }

        #endregion

        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (RecognizerConfig == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(RecognizerConfig)));

            base.CacheMetadata(metadata);
        }

        protected override IOcrClient GetOcrClient(AsyncCodeActivityContext context)
        {
            var recognizerConfig = RecognizerConfig.Get(context);

            return new CcintOcrClient(recognizerConfig);
        }

        #endregion
    }
}


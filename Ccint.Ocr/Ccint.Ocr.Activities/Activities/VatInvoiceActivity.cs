using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Ccint.Ocr.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Ccint.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.VatInvoiceActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.VatInvoiceActivity_Description))]
    public class VatInvoiceActivity : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.VatInvoiceActivity_ImagePath_DisplayName))]
        [LocalizedDescription(nameof(Resources.VatInvoiceActivity_ImagePath_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> ImagePath { get; set; }

        [LocalizedDisplayName(nameof(Resources.VatInvoiceActivity_Result_DisplayName))]
        [LocalizedDescription(nameof(Resources.VatInvoiceActivity_Result_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<JObject> Result { get; set; }

        #endregion


        #region Constructors

        public VatInvoiceActivity()
        {
            Constraints.Add(ActivityConstraints.HasParentType<VatInvoiceActivity, CcintOcrScope>(Resources.ValidationScope_Error));
        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (ImagePath == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ImagePath)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            var imagepath = ImagePath.Get(context);
    
            ///////////////////////////
            // Add execution logic HERE
            ///////////////////////////

            // Outputs
            return (ctx) => {
                Result.Set(ctx, null);
            };
        }

        #endregion
    }
}


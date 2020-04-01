﻿using Ccint.Ocr.Activities.Properties;
using Ccint.Ocr.Contracts;
using Ccint.Ocr.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;
using UiPath.Shared.Activities.Utilities;

namespace Ccint.Ocr.Activities
{
    public abstract class BaseOcrActivity : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.BaseOcrActivity_ImagePath_DisplayName))]
        [LocalizedDescription(nameof(Resources.BaseOcrActivity_ImagePath_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> ImagePath { get; set; }

        [LocalizedDisplayName(nameof(Resources.BaseOcrActivity_Result_DisplayName))]
        [LocalizedDescription(nameof(Resources.BaseOcrActivity_Result_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<JObject> Result { get; set; }

        #endregion

        #region Constructors

        public BaseOcrActivity()
        {
            Constraints.Add(ActivityConstraints.HasParentType<BaseOcrActivity, CcintOcrScope>(Resources.ValidationScope_Error));
        }

        #endregion

        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (ImagePath == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ImagePath)));

            base.CacheMetadata(metadata);
        }

        protected abstract string GetRecognizerName();

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            var imagepath = ImagePath.Get(context);
            var objectContainer = context.GetFromContext<IObjectContainer>(CcintOcrScope.ParentContainerPropertyTag);
            var ocrClient = objectContainer.Get<IOcrClient>();

            ///////////////////////////
            // Add execution logic HERE
            ///////////////////////////
            var recognizerName = GetRecognizerName();
            var result = await ocrClient.RecognizeAsync(recognizerName, imagepath);

            // Outputs
            return (ctx) => {
                Result.Set(ctx, result);
            };
        }

        #endregion
    }
}

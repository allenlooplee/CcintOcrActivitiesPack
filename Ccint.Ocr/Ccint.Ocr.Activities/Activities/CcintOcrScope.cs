using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using System.Activities.Statements;
using System.ComponentModel;
using Ccint.Ocr.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;
using Ccint.Ocr.Models;
using Ccint.Ocr.Contracts;

namespace Ccint.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.CcintOcrScope_DisplayName))]
    [LocalizedDescription(nameof(Resources.CcintOcrScope_Description))]
    public class CcintOcrScope : ContinuableAsyncNativeActivity
    {
        #region Properties

        [Browsable(false)]
        public ActivityAction<IObjectContainer​> Body { get; set; }

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.CcintOcrScope_AppKey_DisplayName))]
        [LocalizedDescription(nameof(Resources.CcintOcrScope_AppKey_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> AppKey { get; set; }

        [LocalizedDisplayName(nameof(Resources.CcintOcrScope_AppSecret_DisplayName))]
        [LocalizedDescription(nameof(Resources.CcintOcrScope_AppSecret_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> AppSecret { get; set; }

        // A tag used to identify the scope in the activity context
        internal static string ParentContainerPropertyTag => "CcintScope";

        // Object Container: Add strongly-typed objects here and they will be available in the scope's child activities.
        private readonly IObjectContainer _objectContainer;

        #endregion


        #region Constructors

        public CcintOcrScope(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

            Body = new ActivityAction<IObjectContainer>
            {
                Argument = new DelegateInArgument<IObjectContainer> (ParentContainerPropertyTag),
                Handler = new Sequence { DisplayName = Resources.Do }
            };
        }

        public CcintOcrScope() : this(new ObjectContainer())
        {

        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            if (AppKey == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(AppKey)));
            if (AppSecret == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(AppSecret)));

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<NativeActivityContext>> ExecuteAsync(NativeActivityContext  context, CancellationToken cancellationToken)
        {
            // Inputs
            var appkey = AppKey.Get(context);
            var appSecret = AppSecret.Get(context);

            IOcrService ocrService = new CcintOcrService(appkey, appSecret);
            _objectContainer.Add(ocrService);

            return (ctx) => {
                // Schedule child activities
                if (Body != null)
				    ctx.ScheduleAction<IObjectContainer>(Body, _objectContainer, OnCompleted, OnFaulted);

                // Outputs
            };
        }

        #endregion


        #region Events

        private void OnFaulted(NativeActivityFaultContext faultContext, Exception propagatedException, ActivityInstance propagatedFrom)
        {
            faultContext.CancelChildren();
            Cleanup();
        }

        private void OnCompleted(NativeActivityContext context, ActivityInstance completedInstance)
        {
            Cleanup();
        }

        #endregion


        #region Helpers
        
        private void Cleanup()
        {
            var disposableObjects = _objectContainer.Where(o => o is IDisposable);
            foreach (var obj in disposableObjects)
            {
                if (obj is IDisposable dispObject)
                    dispObject.Dispose();
            }
            _objectContainer.Clear();
        }

        #endregion
    }
}

using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using Ccint.Ocr.Activities.Design.Designers;
using Ccint.Ocr.Activities.Design.Properties;

namespace Ccint.Ocr.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            #region Setup

            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute =  new CategoryAttribute($"{Resources.Category}");

            #endregion Setup

            builder.AddCustomAttributes(typeof(AutoReceiptActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(AutoReceiptActivity), new DesignerAttribute(typeof(AutoReceiptActivityDesigner)));
            builder.AddCustomAttributes(typeof(AutoReceiptActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(CcintOcrClientActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(CcintOcrClientActivity), new DesignerAttribute(typeof(CcintOcrClientActivityDesigner)));
            builder.AddCustomAttributes(typeof(CcintOcrClientActivity), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}

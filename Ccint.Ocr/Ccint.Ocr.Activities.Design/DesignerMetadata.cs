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


            builder.AddCustomAttributes(typeof(CcintOcrScope), categoryAttribute);
            builder.AddCustomAttributes(typeof(CcintOcrScope), new DesignerAttribute(typeof(CcintOcrScopeDesigner)));
            builder.AddCustomAttributes(typeof(CcintOcrScope), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(VatInvoiceActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new DesignerAttribute(typeof(VatInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BankCardActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BankCardActivity), new DesignerAttribute(typeof(BankCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(BankCardActivity), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}

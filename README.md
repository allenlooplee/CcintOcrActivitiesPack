# 合合OCR活动包

![海报](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/docs/images/poster.png)

[合合AI开放平台](https://ai.ccint.com/)提供多种OCR，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程。本代码库参照[百度文字识别活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)的设计，打通UiPath和合合OCR，让开发者能在UiPath Studio中通过简单的拖放和设置把合合OCR用到相关流程中，从而加速开发过程。

## 快速开始

在UiPath Studio中使用合合OCR活动包可以遵循以下步骤：
1. **创建项目**：使用[templates/CcintOcrBasicProcess](https://github.com/allenlooplee/CcintOcrActivitiesPack/tree/master/templates/CcintOcrBasicProcess)模版创建OCR流程，你可以查阅[它的文档](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/docs/ccint-ocr-basic-process.md)。
2. **安装活动包**：在GitHub Releases中下载[v0.1.0 pre-release](https://github.com/allenlooplee/CcintOcrActivitiesPack/releases/tag/v0.1.0)，并在UiPath Studio的Manage Packages中安装。
3. **配置密钥**：在[config/recognizer_config.xlsx](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/templates/CcintOcrBasicProcess/config/recognizer_config.xlsx)中填入相应的app key和app secret.
4. **使用活动**：把你想使用的OCR活动从Activities面板拖到Ccint OCR Scope活动中。

## OCR活动清单

本活动第一期将会包含有以下OCR活动，其他OCR活动将会陆续发布：

#|名称|类型|活动
---|---|---|---
1|[增值税发票识别](https://ai.ccint.com/api/vision/vat_invoice)|票据类|[VatInvoiceActivity](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/Ccint.Ocr/Ccint.Ocr.Activities/Activities/VatInvoiceActivity.cs)
2|[银行卡识别](https://ai.ccint.com/api/vision/bank_card)|证照类|[BankCardActivity](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/Ccint.Ocr/Ccint.Ocr.Activities/Activities/BankCardActivity.cs)
3|[营业执照识别](https://ai.ccint.com/api/vision/business_license)|公司商铺类|[BusinessLicenseActivity](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/Ccint.Ocr/Ccint.Ocr.Activities/Activities/BusinessLicenseActivity.cs)
4|[身份证识别](https://ai.ccint.com/api/vision/id_card)|证照类|[IdCardActivity](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/Ccint.Ocr/Ccint.Ocr.Activities/Activities/IdCardActivity.cs)
5|[票据机器人](https://ai.ccint.com/api/vision/general_receipt_recog)|智能技术|[AutoReceiptActivity](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/Ccint.Ocr/Ccint.Ocr.Activities/Activities/AutoReceiptActivity.cs)

## 其他代码库和参考资料
* [合合文字识别API文档](https://ai.ccint.com/doc/api/general_license_recog/v1.0)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [How to Create Activities](https://docs.uipath.com/integrations/docs/how-to-create-activities)
* [Testing Framework for UiPath](https://connect.uipath.com/marketplace/components/uipath-testing-framework)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往合合AI开放平台进行识别。
* 本活动包并不收取任何费用，但合合AI开放平台将会根据你的使用情况收取相关费用。

# 合合OCR活动包

![海报](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/docs/images/poster.png)

[合合AI开放平台](https://ai.ccint.com/)提供多种OCR，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程。本代码库参照[百度文字识别活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)的设计，打通UiPath和合合OCR，让开发者能在UiPath Studio中通过简单的拖放和设置把合合OCR用到相关流程中，从而加速开发过程。

## 快速开始

在UiPath Studio中使用合合OCR活动包可以遵循以下步骤：
1. **创建项目**：使用[templates/CloudOcrBasicProcess](https://github.com/allenlooplee/CloudOcrActivitiesPack/tree/master/templates/CloudOcrBasicProcess)模版创建OCR流程，你可以查阅[它的文档](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/docs/cloud-ocr-basic-process.md)。
2. **安装活动包**：打开UiPath Studio的Manage Packages，在[nuget.org](https://api.nuget.org/v3/index.json)中搜索并安装Ccint.Ocr.Activities。
3. **配置密钥**：在[config/ccint_ocr_config.xlsx](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/templates/CloudOcrBasicProcess/config/ccint_ocr_config.xlsx)中填入相应的app key和app secret。
4. **加载密钥**: 使用[snippets/LoadCcintOcrConfig.xaml](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/snippets/LoadCcintOcrConfig.xaml)代码片段从上述配置文件加载密钥。
5. **使用活动**：把你想使用的OCR活动从Activities面板拖到OCR Scope活动中。

## OCR活动清单

本活动包支持以下[云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)的OCR活动：

#|名称|类型|活动
---|---|---|---
1|[票据机器人](https://ai.ccint.com/api/vision/general_receipt_recog)|智能技术|[AutoReceiptActivity](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/Ccint.Ocr/Ccint.Ocr.Activities/Activities/AutoReceiptActivity.cs)
2|[增值税发票识别](https://ai.ccint.com/api/vision/vat_invoice)|票据类|[VatInvoiceActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VatInvoiceActivity.cs)
3|[银行卡识别](https://ai.ccint.com/api/vision/bank_card)|证照类|[BankCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BankCardActivity.cs)
4|[营业执照识别](https://ai.ccint.com/api/vision/business_license)|公司商铺类|[BusinessLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/BusinessLicenseActivity.cs)
5|[身份证识别](https://ai.ccint.com/api/vision/id_card)|证照类|[IdCardActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/IdCardActivity.cs)
6|[出租车票识别](https://ai.ccint.com/api/vision/taxi_ticket)|票据类|[TaxiReceiptActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TaxiReceiptActivity.cs)
7|[火车票识别](https://ai.ccint.com/api/vision/train_ticket)|票据类|[TrainTicketActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/TrainTicketActivity.cs)
8|[户口本识别](https://ai.ccint.com/api/vision/family_register)|证照类|[HouseholdRegisterActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/HouseholdRegisterActivity.cs)
9|[护照识别](https://ai.ccint.com/api/vision/passport)|证照类|[PassportActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/PassportActivity.cs)
10|[驾驶证识别](https://ai.ccint.com/api/vision/drive_license)|车辆相关|[DriverLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/DriverLicenseActivity.cs)
11|[行驶证识别](https://ai.ccint.com/api/vision/vehicle_license)|车辆相关|[VehicleLicenseActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleLicenseActivity.cs)
12|[车辆合格证识别](https://ai.ccint.com/api/vision/vehicle_certificate)|车辆相关|[VehicleCertificateActivity](https://github.com/allenlooplee/CloudOcrActivitiesPack/blob/master/Cloud.Ocr/Cloud.Ocr.Activities/Activities/VehicleCertificateActivity.cs)

## 其他代码库和参考资料
* [云可扩展OCR活动包](https://github.com/allenlooplee/CloudOcrActivitiesPack)
* [合合文字识别API文档](https://ai.ccint.com/doc/api/general_license_recog/v1.0)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [How to Create Activities](https://docs.uipath.com/integrations/docs/how-to-create-activities)
* [Testing Framework for UiPath](https://connect.uipath.com/marketplace/components/uipath-testing-framework)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)
* [RPA开发与应用](https://github.com/allenlooplee/RPABook)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往合合AI开放平台进行识别。
* 本活动包并不收取任何费用，但合合AI开放平台将会根据你的使用情况收取相关费用。

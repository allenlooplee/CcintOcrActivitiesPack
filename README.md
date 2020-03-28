# 合合文字识别活动包

[合合AI开放平台](https://ai.ccint.com/)提供多种文字识别，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程。本代码库参照[百度文字识别活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack)的设计，打通UiPath和合合文字识别，让开发者能在UiPath Studio中通过简单的拖放和设置把合合文字识别用到相关流程中，从而加速开发过程。

## 文字识别活动

本活动第一期将会包含有以下文字识别活动，其他文字识别活动将会陆续发布：

#|名称|类型|活动
---|---|---|---
1|[增值税发票识别](https://ai.ccint.com/api/vision/vat_invoice)|票据|VatInvoiceActivity
2|[银行卡识别](https://ai.ccint.com/api/vision/bank_card)|卡证|BankCardActivity
3|[营业执照识别](https://ai.ccint.com/api/vision/business_license)|卡证|BusinessLicenseActivity
4|[身份证识别](https://ai.ccint.com/api/vision/id_card)|卡证|IdCardActivity

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往合合AI开放平台进行文字识别。
* 本活动包并不收取任何费用，但合合AI开放平台将会根据你的使用情况收取相关费用。

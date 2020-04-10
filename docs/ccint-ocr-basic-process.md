# 合合OCR基本流程

![合合OCR基本流程](https://github.com/allenlooplee/CcintOcrActivitiesPack/blob/master/docs/images/ccint-ocr-basic-process.PNG)

“合合OCR基本流程”是一个基于“流程图”的项目模版，针对使用“合合OCR活动包”的流程进行了优化。你可以从[templates/CcintOcrBasicProcess](https://github.com/allenlooplee/CcintOcrActivitiesPack/tree/master/templates/CcintOcrBasicProcess)下载项目模版。

> 注意：因为合合OCR活动包还没发布到UiPath Go，所以在使用这个项目模版时需要手动更新合合OCR活动包，你可以到[GitHub Releases](https://github.com/allenlooplee/CcintOcrActivitiesPack/releases)下载最新的版本。

这个项目模板包含以下五个步骤：

## 初始化序列（Initialize）

这个步骤负责加载配置信息。默认情况下，它会从config/recognizer_config.xlsx中加载所有OCR的URL、app key和app secret。

## 加载图片序列（Load Image）

这个步骤负责检查并获取下一个需要处理的图片的路径，并把hasNext变量设为True。

## 流程决策（Flow Decision）

如果hasNext变量的值为True，则执行“处理图片序列”步骤；否则，执行“结束序列”步骤。

## 处理图片序列（Process Image）

这个步骤负责执行指定的OCR活动，从识别结果中提取所需信息，并对已处理的图片进行归档。这个步骤已经包含Cloud OCR Activities Pack的OCR Scope活动，并设置了“初始化序列”加载的recognizer config。你只需把用于示例的Bank Card活动换成你想使用的OCR活动，并设置图片路径就行了。

## 结束序列（Finalize）

这个步骤负责整个流程的收尾工作，如发送一份处理报告。

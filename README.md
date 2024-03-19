# TesseractDotnetWrapper

A .NET wrapper for [tesseract-ocr] 5.3.4.

이 프로젝트는 [charlesw/tesseract](https://github.com/charlesw/tesseract) 라이브러리의 변형 버전입니다. 원본 라이브러리의 기능과 구조를 바탕으로, 크로스플랫폼 지원을 개선하여 .NET에서 더 나은 OCR 기능을 제공하기 위해 개발되었습니다.
본 프로젝트는 Tesseract OCR 엔진을 .NET 환경에서 더욱 효과적으로 사용할 수 있도록 설계되었습니다.

This project is a modified version of the [charlesw/tesseract](https://github.com/charlesw/tesseract) library, designed to enhance OCR functionalities within the .NET ecosystem by improving cross-platform support.
It aims to make the Tesseract OCR engine more effective in .NET environments.

## 개선 사항
  런타임시간에 동적라이브러리를 환경별로 선택해 로드하는 대신 플랫폼들의 바이너리파일을 모두 포함하고 플랫폼별 코드를 구현했습니다.
  이로 인해 .NET런타임의 최적화 및 AOT 빌드가 가능합니다.

## Enhancements
  Instead of selecting and loading dynamic libraries based on the environment at runtime, we have included binaries for all platforms and implemented platform-specific code.
  This enables optimizations for the .NET runtime and Ahead-of-Time (AOT) builds.


## Supported platforms

|.NET Version|Platform|-|
|-|-|-|
|**.NET Standard 2.1**|windows (x64)|✅|
| |linux (x64)|✅|
| |macOS (arm64)|✅|

### Tesseract 언어 훈련모델
tesseract 4.0.0이상 버전에서 사용되는 훈련모델이 필요합니다. [tesseract-tessdata] 여기서 다운로드 받을수있습니다.

### Tesseract language data
You will also need to download the language data files for tesseract 4.0.0 or above from [tesseract-tessdata].

[tesseract-ocr]: https://github.com/tesseract-ocr/tesseract
[tesseract-tessdata]: https://github.com/tesseract-ocr/tessdata/

## 감사의 글
본 프로젝트는 [charlesw/tesseract](https://github.com/charlesw/tesseract) 라이브러리에 기반을 두고 있습니다. 원본 프로젝트의 기여자분들에게 감사드립니다.

## Acknowledgments
This project is based on the [charlesw/tesseract](https://github.com/charlesw/tesseract) library. I would like to express my gratitude to the contributors of the original project.

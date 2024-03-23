# TesseractCSharp

A .NET wrapper for [tesseract-ocr] 5.3.4.

이 프로젝트는 [charlesw/tesseract](https://github.com/charlesw/tesseract) 라이브러리의 변형 버전입니다. 원본 라이브러리의 기능과 구조를 바탕으로, 크로스플랫폼 지원을 개선하여 .NET에서 더 나은 OCR 기능을 제공하기 위해 개발되었습니다.
본 프로젝트는 Tesseract OCR 엔진을 .NET 환경에서 더욱 효과적으로 사용할 수 있도록 설계되었습니다.

This project is a modified version of the [charlesw/tesseract](https://github.com/charlesw/tesseract) library, designed to enhance OCR functionalities within the .NET ecosystem by improving cross-platform support.
It aims to make the Tesseract OCR engine more effective in .NET environments.

## 개선 사항
  .Net Core3.0 부터 제공되는 NativeLibrary를 사용하여 동적 시간에 플랫폼별 라이브러리를 로드하였습니다.
  이로 인해 IL을 직접 구성하지 않아. NET런타임의 최적화 및 호환성을 더욱 확보했습니다.

## Enhancements
  I used NativeLibrary, available from .Net Core 3.0, to load platform-specific libraries at runtime. 
  This has enabled us to secure further optimization and compatibility with the .NET runtime without directly constructing IL.


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

## License Information

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this software except in compliance with the License. You may obtain a copy of the License at:
http://www.apache.org/licenses/LICENSE-2.0

This project makes use of external libraries, each governed by its own license. It's important for users and contributors to be aware of these licenses and adhere to their terms. Below is a summary of the licensing for each major component along with a note on where to find detailed license details and conditions:

### Leptonica 
Incorporated in this project in binary form is the Leptonica library. Leptonica is licensed under the BSD 2-clause license. This license permits the use, modification, and distribution of the software, provided that the copyright notice and the license's conditions are included in all copies or substantial portions of the software. Detailed license details and conditions can be found on the [official Leptonica website](http://www.leptonica.org/) or [source repository](https://github.com/danbloomberg/leptonica).

### Tesseract
We utilize the Tesseract Optical Character Recognition (OCR) library in binary form, which is licensed under the Apache-2.0 license. The Apache-2.0 license is a permissive open-source license that allows for free use, modification, and distribution of the software, under the condition that copyright notice and the license itself are made available in any redistribution of the software or substantial parts of it. Detailed license details and conditions can be found on the [Tesseract GitHub page](https://github.com/tesseract-ocr/tesseract).

### charlesw/tesseract
The basis of our Tesseract implementation relies on the charlesw/tesseract library, which is also under the Apache-2.0 license. This consistency in licensing facilitates our use and modification of the Tesseract OCR technology within the guidelines of open-source software development. Detailed license details and conditions can be found on the [charlesw/tesseract GitHub page](https://github.com/charlesw/tesseract).

Please ensure that you review and comply with the specific terms and conditions of these licenses when using, modifying, or distributing this project or its components.

## 감사의 글
본 프로젝트는 [charlesw/tesseract](https://github.com/charlesw/tesseract) 라이브러리에 기반을 두고 있습니다. 원본 프로젝트의 기여자분들에게 감사드립니다.

## Acknowledgments
This project is based on the [charlesw/tesseract](https://github.com/charlesw/tesseract) library. I would like to express my gratitude to the contributors of the original project.

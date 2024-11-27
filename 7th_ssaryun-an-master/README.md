# 싸륜안

> AR을 활용한 멀티캠퍼스 소개 어플리케이션

서울 교육 건물인 멀티캠퍼스를 배경으로 하여 AR 기술을 활용해 <br>
멀티캠퍼스 내의 오브젝트에 담긴 안내나 퀴즈를 통해 멀티캠퍼스를 소개하는 모바일 앱
![메인](/uploads/d30e4b7c2fc946712da891ae40d8f74d/image.png)

## 주요기능

- AR 기술을 활용한 증강현실 제공
- 오브젝트에 담긴 안내와 퀴즈를 통한 SSAFY 서울캠퍼스 소개

## 세부기능

| 구분 | 기능                       | 설명                                                         | 비고 |
| :--- | :------------------------- | :----------------------------------------------------------- | :--- |
| 1    | 체험존 | 체험하고 싶은 구역을 인식하면 요정이 해당 구역을 설명해준다. |      |
| 2    | 퀴즈존 | 악마가 제출하는 문제를 풀고 보상을 얻을 수 있다. |      |
| 3    | 포토존 | 이전 기수와 SSAFY를 만든 프로님과 같이 사진을 찍을 수 있다. |      |

## 기술스택
![기술스택](/uploads/163e5f8af1d5464e120c5c7ad12b8f84/image.png)

## 아키텍처

![아키텍쳐](https://lab.ssafy.com/ssafy_opensource/7th_ssaryun-an/-/wikis/uploads/908291c106e6c4f24ab8ced2bb75ba0e/image.png)

## 설치

[싸륜안 다운로드](https://ssafy-space.notion.site/b069f4b2372845f48d99eead85267871) 해당 링크에서 apk 파일을 다운 받아 안드로이드 환경에서 설치할 수 있습니다.
> 현재 AR 서비스 라이선스 만료로 인해 앱에서 카메라가 작동하지 않을 수 있습니다.

_Unity 빌드는 [포팅메뉴얼](포팅메뉴얼.pdf)을 참고해주세요._ <br>
*(프로젝트 관련 에셋과 영상은 저작권 문제로 다운로드 할 수 없습니다.)*
> 프로젝트의 에셋은 [파일구조](https://lab.ssafy.com/ssafy_opensource/7th_ssaryun-an/-/wikis/home#two-%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8-%ED%8C%8C%EC%9D%BC-%EA%B5%AC%EC%A1%B0)의 assetstore, Devil, MG_Asset, StreamingAssets 폴더에 위치합니다.

## 사용 예시

_자세한 예와 용도는 다음을 참조하십시오. [Wiki](https://lab.ssafy.com/ssafy_opensource/7th_ssaryun-an/-/wikis/home)._

## 개발 설정

[포팅메뉴얼](포팅메뉴얼.pdf)을 참고해주세요.

## 릴리즈 히스토리

* 0.0.1
  * project transfer (프로젝트 이관)

## 기여

1. 해당 프로젝트를 Fork 하세요. (https://lab.ssafy.com/ssafy_opensource/7th_ssaryun-an/-/forks/new)
    * **Project URL**은 개인 Gitlab ID로 설정해주세요!
    * **Project slug**는 변경하지 않습니다.
2.  새로운 브랜치를 생성하세요.
    *   이때 브랜치는 `dev`브랜치에서 분기해주세요.
    *   브랜치 네이밍은 `기수_팀코드_학번`으로 설정합니다.    
    *   ```
        git checkout -b dev  
        git pull origin dev  
        git checkout -b 9th_A101_0911111
3.  변경사항을 commit 하세요 (`git commit -am 'Add some fooBar'`)
4.  브랜치에 Push 하세요 (`git push origin 9th_A101_0911111`)
5.  새로운 Merge Request를 요청하세요
    *   Source branch: `개인ID/프로젝트`에서 새로 생성한 브랜치(`9th_A101_0911111`)
    *   Target branch: `ssafy_opensource/프로젝트` 의 `dev` 브랜치
    *   Description에 수정된 파일의 위치와 변경 사항, 의견 등을 작성해 등록합니다.

## 라이선스

Distributed under the SGPL license. See [License](LICENSE) for more information.

<!-- Markdown link & img dfn's -->

[npm-image]: https://img.shields.io/npm/v/datadog-metrics.svg?style=flat-square
[npm-url]: https://npmjs.org/package/datadog-metrics
[npm-downloads]: https://img.shields.io/npm/dm/datadog-metrics.svg?style=flat-square
[travis-image]: https://img.shields.io/travis/dbader/node-datadog-metrics/master.svg?style=flat-square
[travis-url]: https://travis-ci.org/dbader/node-datadog-metrics
[wiki]: https://lab.ssafy.com/ssafy_coach_5th/open-source-template/wikis/home

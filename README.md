# 「unity-ci」 CircleCI Orb for Unity

[![CircleCI](https://circleci.com/gh/MizoTake/unity-ci.svg?style=svg)](https://circleci.com/gh/MizoTake/unity-ci)
![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)
[![Actions Status](https://github.com/MizoTake/unity-ci/workflows/unity-ci-example/badge.svg)](https://github.com/MizoTake/unity-ci/actions)

unity-ci orb の公式ページ

[mizotake/unity-ci](https://circleci.com/orbs/registry/orb/mizotake/unity-ci)

## Example config.yml

```yaml:config.yml
version: 2.1

orbs:
  unity-ci: mizotake/unity-ci@0.0.9

executors:
  unity_executor:
    docker:
      - image: gableroux/unity3d:2019.1.0f2

workflows:
  version: 2
  unity-ci-test:
    jobs:
      - unity-ci/build:
          name: Build Execute Win
          exec: unity_executor
          platform: Win
          method: Build.Method
          zip: true
      - unity-ci/build:
          name: Build Execute OSXUniversal
          exec: unity_executor
          platform: OSXUniversal
          method: Build.Method
          zip: true
      - unity-ci/test:
          name: Edit Mode Test
          exec: unity_executor
          mode: editmode
      - unity-ci/test:
          name: Play Mode Test
          exec: unity_executor
          mode: playmode
      - unity-ci/execute_method:
          name: Exeucte Method
          exec: unity_executor
          method: Execute.Method
```

# 「unity-ci」 CircleCI Orb for Unity

[![CircleCI](https://circleci.com/gh/MizoTake/unity-ci.svg?style=svg)](https://circleci.com/gh/MizoTake/unity-ci)
![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)
[![Actions Status](https://github.com/MizoTake/unity-ci/workflows/unity-ci-example/badge.svg)](https://github.com/MizoTake/unity-ci/actions)

unity-ci orbの公式ページ

[mizotake/unity-ci](https://circleci.com/orbs/registry/orb/mizotake/unity-ci)

## commands

### unity_activate

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|license|Unity License|-|UNITY_LICENSE_BASE64|env_var_name|

### build

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|platform|Build Target Platform|:white_check_mark:|-|string|
|method|Build Execute Method|:white_check_mark:|-|string|
|no_output_timeout|No Output Timeout|-|10m|string|

### test

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|mode|Test Target Platform|:white_check_mark:|-|string|

### execute_method

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|method|Target Method|:white_check_mark:|-|string|

### zip

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|directory|Target Directory|:white_check_mark:|-|string

## jobs

### build

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|exec|-|:white_check_mark:|-|executor|
|license|Unity License|-|UNITY_LICENSE_BASE64|env_var_name
method|Build Execute Method|:white_check_mark:|-|string
platform|Test Target Platform|:white_check_mark:|-|string
zip|Archive Build Contents|-|false|boolean
no_output_timeout|No Output Timeout|-|10m|string
directory|Target Directory|-|.|string|

### test

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|exec|-|:white_check_mark:|-|executor|
|license|Unity License|-|UNITY_LICENSE_BASE64|env_var_name
|mode|Test Target Mode|:white_check_mark:|-|string|

### execute_method

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|exec|-|:white_check_mark:|-|executor|
|license|Unity License|-|UNITY_LICENSE_BASE64|env_var_name
|method|Build Execute Method|:white_check_mark:|-|string|
# 「unity-ci」 CircleCI Orb for Unity

[![CircleCI](https://circleci.com/gh/MizoTake/unity-ci.svg?style=svg)](https://circleci.com/gh/MizoTake/unity-ci)

unity-ci orbの公式ページ

[mizotake/unity-ci](https://circleci.com/orbs/registry/orb/mizotake/unity-ci)

## commands
|command name|link|
|---|---|
|unity_activate|[unity_activate](#unity_activate)|
|build|[build](#build)|
|test|[test](#test)|
|execute_method|[execute_method](execute_method)|
|zip|[zip](zip)|

### unity_activate

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|---|
|license|Unity License|-|UNITY_LICENSE_BASE64|env_var_name

### build

### test

### execute_method

### zip

## jobs

|job name|link|
|---|---|
|unity_activate|[unity_activate](#unity_activate)|
|build|[build](#build)|
|test|[test](#test)|
|execute_method|[execute_method](execute_method)|
|zip|[zip](zip)|

### unity_activate

|PARAMETER|DESCRIPTION|REQUIRED|DEFAULT|TYPE|
|---|---|---|---|---|
|exec|-|:white_check_mark:|-|executor|
|license|Unity License|-|UNITY_LICENSE_BASE64|env_var_name
method|Build Execute Method|:white_check_mark:|-|string
platform|Test Target Platform|:white_check_mark:|-|string
zip|Archive Build Contents|-|false|boolean
no_output_timeout|No Output Timeout|-|10m|string
directory|Target Directory|-|.|string|

### build

### test

### execute_method

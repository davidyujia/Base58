# Configuration

## Set Environment

```cs
Config.GetEnvironmentFunc = () => "Debug";
//or
Config.Environment = "Debug";
```

## Get Configuration

```cs
// default load from appsettings.json
var configValue = Config.Load();
//or
var customConfigValueCustom = Config.Load("custom.json");
```

## Get Value

```cs
var configValue1 = configValue["Key"];
//or
var configValue2 = configValue["ConnectionStrings"]["DefaultConnection"];
```

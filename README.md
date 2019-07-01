# Base58

without Base58Check

## Base58 Encode

```cs

var str = Encoding.UTF8.GetBytes("Hello");

var base58String = Base58.Encode(str);

Console.Write(base58String);
//result: "9Ajdvzr"

```

## Base58 Decode

```cs

var bytes = Base58.Encode("9Ajdvzr");

var str = Encoding.UTF8.GetString(bytes);

Console.Write(str);
//result: "Hello"

```

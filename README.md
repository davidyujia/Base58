# davidyujia.Base58

without Base58Check

## Base58 Encode

```cs

var str = Encoding.UTF8.GetBytes("Hello");

var base58String = davidyujia.Base58.Encode(str);

Console.Write(base58String);
//result: "9Ajdvzr"

```

## Base58 Decode

```cs

var bytes = davidyujia.Base58.Encode("9Ajdvzr");

var str = Encoding.UTF8.GetString(bytes);

Console.Write(str);
//result: "Hello"

```

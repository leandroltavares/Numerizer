# Numerizer
Extension for parsing numerals from human-readable strings to numerical values in .NET 

Inspired by the amazing Humanizr (https://github.com/Humanizr/Humanizer), this library aims to parse human-readable strings into numeric values.

### Table of contents
 - [Install](#install)
   [Features](#features)
   - [Dehumanize Numbers](#dehumanize-numbers)
   [License](#license)
   
## <a id="install">Install</a>
You can install Numerizer as [a nuget package]([ADD LINK]): 

## <a id="features">Features</a>

### <a id="dehumanize-numbers">Dehumanize Numbers</a>
`Dehumanize` string extensions allow you turn an human-readable number into a numeric value.

```C#
"Forty two".Dehumanize() => 42
"forty two".Dehumanize() => 42
"Forty-two".Dehumanize() => 42
```
## <a id="license">License</a>
Numerizer is released under the MIT License. See the [bundled LICENSE](https://github.com/leandroltavares/Numerizer/blob/master/LICENSE) file for details.

Extensão para interpretar números escritos por humanos (por extenso) para valores númericos em .NET

# DalleDotNet
Minimalist API for Dall-e 2 generations via .NET Core

## Usage

```csharp
// defines your authorization key
const string authorization = "YOUR-SESSION-KEY";

// starts a Dalle session with your authorization key
Dalle dalle = new Dalle(authorization);
// creates request and waits until the images are successfully generated
var data = await dalle.GenerateAsync("A computer showing Hello World");

// data returns a list of image urls, just use them however you like.
foreach (var image in data)
    Console.WriteLine(image);
```

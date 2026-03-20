# Cryptography

* Encrypt and decrypt text files
* Unity minimum version: **6000.3**
* Current version: **3.0.0**

## How To Use

You can only encrypt or decrypt strings using AES algorithm.

```csharp
using UnityEngine;
using OneM.Cryptography;

public class Test : MonoBehaviour
{
    public TextAsset json;

    [ContextMenu("Run Test")]
    async void RunTest()
    {
        // You can generate a security key at https://randomkeygen.com/
        var key = "IspwttyeNSQ9qWLouOoG6y1GnozZ9uEn";
        var cryptographer = CryptographerFactory.Create(CryptographerType.AES, key);
        var encrypted = await cryptographer.EncryptAsync(json.text);
        var decrypted = await cryptographer.DecryptAsync(encrypted);

        print(encrypted);
        print(decrypted);
    }
}
```

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **1M Bits Horde-Cryptography** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/1mbitshorde/Cryptography.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.1mbitshorde.cryptography":"https://github.com/1mbitshorde/Cryptography.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>
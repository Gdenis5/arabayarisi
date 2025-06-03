# 🚗 Unity Car Game

Unity ve C# kullanılarak geliştirilmiş basit ama işlevsel bir 3D araba oyunudur. Bu proje, oyun programlamaya yeni başlayanlar için temel sürüş mekaniği, fizik ve kullanıcı arayüzü konularında pratik yapma fırsatı sunar.

## 🎮 Özellikler

- Gerçek zamanlı araba kontrolü (WASD veya yön tuşları ile)
- Temel fizik motoru ile sürüş deneyimi
- Kamera geçişleri (isteğe bağlı)
- Hız göstergesi, sayaç gibi UI öğeleri
- Başlangıç ve bitiş noktaları içeren yarış sahnesi

## 📦 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edin:

1. Bu repoyu klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/unity-car-game.git
````

2. Unity Hub'ı açın ve bu klasörü "Add" ile projelerinize ekleyin.
3. `Assets/Scenes/MainScene.unity` sahnesini açarak oyunu başlatabilirsiniz.

## 🧭 Kontroller

| Eylem                       | Tuşlar       |
| --------------------------- | ------------ |
| İleri Git                   | `W` veya `↑` |
| Geri Git                    | `S` veya `↓` |
| Sola Dön                    | `A` veya `←` |
| Sağa Dön                    | `D` veya `→` |
| Kamera Değiştir (opsiyonel) | `C`          |

## 📁 Proje Yapısı

```plaintext
UnityCarGame/
├── Assets/
│   ├── Scenes/            # Oyun sahneleri (MainScene.unity)
│   ├── Scripts/           # C# betikleri (CarController.cs vb.)
│   ├── Prefabs/           # Araba ve diğer nesne prefabları
│   ├── Materials/         # Kullanılan materyaller
│   ├── UI/                # UI öğeleri (Canvas, Text vb.)
├── ProjectSettings/       # Unity proje ayarları
└── README.md              # Bu dosya
```

## 🚀 Geliştirici Notları

* Araba kontrolü `Rigidbody` komponenti ile sağlanmaktadır.
* Tekerlek dönüşleri ve yönlendirme kodları `CarController.cs` içinde yer almaktadır.
* UI sistemi Unity'nin `Canvas` yapısı kullanılarak oluşturulmuştur.

## 🧑‍💻 Katkıda Bulunmak

Katkılarınızı memnuniyetle karşılıyorum. Lütfen:

1. Bir `issue` açarak önerinizi ya da hatayı belirtin.
2. Gerekli değişiklikleri yaparak bir `pull request` gönderin.

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) kapsamında lisanslanmıştır. Dilediğiniz gibi kullanabilir, değiştirebilir ve dağıtabilirsiniz.

---

Teşekkürler! Bu projeyi beğendiysen yıldız bırakmayı unutma ⭐

```

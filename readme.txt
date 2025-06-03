# 🚗 Unity Araba Yarışı Oyunu

Bu proje, Unity oyun motoru ve C# programlama dili kullanılarak geliştirilmiş bir 3D araba yarışı oyunudur. Oyuncu, klavye tuşları ile aracı kontrol eder ve bitiş çizgisine en kısa sürede ulaşmaya çalışır. Bu oyun, temel fizik, kontrol sistemleri ve kullanıcı arayüzü (UI) bileşenlerini barındıran bir örnek çalışmadır.

## 🎮 Özellikler

* Klavye ile araba kontrolü (W, A, S, D veya yön tuşları)
* Unity Rigidbody fiziği ile gerçekçi sürüş
* Başlangıç ve bitiş noktaları
* Süre veya skor takibi (varsa)
* Kamera geçişi (isteğe bağlı)
* UI: hız göstergesi, zamanlayıcı, bitiş ekranı vb.

## 📁 Proje Yapısı

```
arabayarisi/
├── Assets/
│   ├── Scenes/            → Oyun sahneleri (MainScene.unity)
│   ├── Scripts/           → C# script dosyaları (CarController.cs vb.)
│   ├── Prefabs/           → Araba prefab'ı ve diğer nesneler
│   ├── Materials/         → Materyal dosyaları
│   ├── UI/                → Kullanıcı arayüz öğeleri
├── ProjectSettings/       → Unity proje ayarları
└── README.md              → Bu dosya
```

## 🛠️ Kurulum

1. Bu projeyi GitHub üzerinden klonlayın:

   `git clone https://github.com/Gdenis5/arabayarisi.git`

2. Unity Hub üzerinden projeyi açın.

3. `Assets/Scenes/MainScene.unity` sahnesini açarak oyunu başlatın.

## 🎮 Kontroller

| Eylem                          | Tuşlar   |
| ------------------------------ | -------- |
| İleri Git                      | W veya ↑ |
| Geri Git                       | S veya ↓ |
| Sola Dön                       | A veya ← |
| Sağa Dön                       | D veya → |
| Kamera Değiştir (isteğe bağlı) | C        |

## 💡 Geliştirici Notları

* `CarController.cs` script'i, aracın hareketini ve yönünü kontrol eder.
* Araç hareketleri `Rigidbody` bileşeni üzerinden gerçekleştirilir.
* UI için Unity'nin `Canvas`, `Text` ve `Image` bileşenleri kullanılmıştır.

## 🤝 Katkıda Bulunma

Katkılarınızı memnuniyetle karşılıyoruz. Lütfen önce bir `issue` açın ve ardından bir `pull request` gönderin.

## 📄 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Dilediğiniz gibi kullanabilir, değiştirebilir ve dağıtabilirsiniz.

---

**Made with 💻 + ☕ by Gdenis5**

---

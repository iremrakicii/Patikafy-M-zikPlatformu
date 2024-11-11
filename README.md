# Şarkıcı Listesi Programı

Bu C# programı, bir dizi şarkıcıyı içeren bir liste oluşturur ve bu liste üzerinde çeşitli sorgular yapar. Program, şarkıcıların adını, müzik türünü, çıkış yılını ve albüm satış miktarını içeren bir `Singer` sınıfını temel alır. Program, LINQ sorguları kullanarak belirli kriterlere göre filtreleme ve sıralama yapar.

## İçindekiler
- [Özellikler](#özellikler)
- [Kullanım](#kullanım)
- [Örnek Çıktı](#örnek-çıktı)

## Özellikler

Bu program aşağıdaki sorguları gerçekleştirir:

1. **Adı 'S' ile Başlayan Şarkıcılar**: Adı "S" harfi ile başlayan tüm şarkıcıları listeler.
2. **Albüm Satışları 10 Milyonun Üzerinde Olan Şarkıcılar**: Albüm satışları 10 milyonun üzerinde olan tüm şarkıcıları listeler.
3. **2000 Yılı Öncesi Çıkış Yapmış ve Pop Müzik Yapan Şarkıcılar**: 2000 yılından önce çıkış yapmış ve pop müzik türünde olan şarkıcıları çıkış yıllarına göre ve alfabetik sırayla listeler.
4. **En Çok Albüm Satan Şarkıcı**: En çok albüm satışına sahip olan şarkıcıyı bulur.
5. **En Yeni ve En Eski Çıkış Yapan Şarkıcılar**: Çıkış yılı en yeni ve en eski olan şarkıcıları bulur.

## Kullanım

Bu programı çalıştırmak için, Visual Studio veya .NET Core SDK gibi bir C# geliştirme ortamına ihtiyacınız var. Aşağıdaki adımları izleyerek programı çalıştırabilirsiniz:

1. Bu kodu bir `.cs` uzantılı dosyaya kopyalayın (örneğin `Program.cs`).
2. Terminal veya komut satırında aşağıdaki komutla derleyin:

### Örnek Çıktı
Program çalıştırıldığında aşağıdaki gibi bir çıktı verir:

```rust
Adı 'S' ile başlayan şarkıcılar:
Sezen Aksu
Sertab Erener
Sıla
Serdar Ortaç

Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:
Ajda Pekkan
Tarkan

2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:
Ajda Pekkan (1968)
Sezen Aksu (1971)
Tarkan (1992)
Sertab Erener (1994)
Serdar Ortaç (1994)
Gülben Ergen (1997)
Hande Yener (1999)

En çok albüm satan şarkıcı: Tarkan (40000000 satış)

En yeni çıkış yapan şarkıcı: Sıla (2009)
En eski çıkış yapan şarkıcı: Neşet Ertaş (1960)
```

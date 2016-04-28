Start projektu: 
Ściągnąć i zainstalować:
- http://unity3d.com/get-unity  (w 1 okienku koniecznie zaznaczyć checkbox Android Build Support!)
- http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html
- http://developer.android.com/sdk/index.html#Other
(standardowa instalacja wszystkiego)


Uruchomić android SDK, zainstalować automatycznie zaznaczone paczki
git pull kodu
pobrac i uruchomić (open project): https://github.com/googlesamples/cardboard-unity/blob/master/CardboardSDKForUnity.unitypackage?raw=true


Tips: 
- za każdym razem trzeba zamknąć unity przed pracą z gitem (lock files)


Uruchamianie na telefonie:
podłącz telefon przed USB (trzeba miec włączone na telefonie debugowanie usb, upewnijcie sie tez, że macie drivery do telefonu)
In Unity, go to File > Build Settings -> Android -> Player Settings -> under Resolution and Presentation, change “Default Orientation” to “Landscape Left” -> Other settings -> apps name: com.agh.PerkusjaVR -> Build and run 
po instalacji aplikacji cardboard powinno działac


Vuforia wymaga pobrania i zaimportowania pobranej paczki w Unity. Pobrać ją należy stąd: https://developer.vuforia.com/downloads/sdk . Niestety wymagane jest zalogowanie się.

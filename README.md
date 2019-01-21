# WHYlands Dokumentation (3D-Game)



<h1>Die Grundlagen</h1>

Zunächst müssen erstmal, um später ein solides Gameplay zu implementieren, die Grundlagen in Unity einrichten. Dazu gehören unter anderem das Charaktermodel, ein Controller um Bewegungen zu steuern, Animationen für den Charakter, ein Terrain mit Border, sowie Menüs und weiteres. 

<h2 id="charakter">Der Charakter</h2>

In diesem Fall wird, um das Modell später zu animieren, ein Character-Model benötigt, welches ein Exoskelett enthält. Zudem muss das Charakter-Model menschliche Proportionen aufweisen. Dies kann alles in Adobe Fuse (Beta) gestaltet werden. Nach dem start erhält man dort die Möglichkeit, einen Charakter zu gestalten und sowohl den Körper, als auch das Gesicht sowie die Kleidung selber zu gestalten:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374742-923a5900-05f3-11e9-930f-a08619cca564.png" width="600px"></p>

Sobald der Charakter dann beendet ist, lässt sich oben rechts mit "Save to Maximo" in Maximo exportieren. In Mixamo lassen sich dann Animationen auf einen Charakter anwenden bzw. eigene Animationen mithilfe des von Fuse angewandten Exoskelett erstellen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51466760-3e926b00-1d6b-11e9-921a-4b39743ccb33.png" width="600px"></p>

Sobald dann auch die Animationen angewandt sind, lässt sich das Modell, sowie die Animationen als .fbx datei exportieren. Diese lässt sich dann per Drag&Drop in Unity importieren.

HIER NE ANLEITUNG HIN, WIE MAN DEN ANIMATOR CONTROLLER ERREICHT, ERSTELLT UND WIE MAN DIE ANIMATIONEN HINZUFÜGT

Sobald dann sämtliche Animationen zum Animator-Controller hinzugefügt wurden, sind schon einige Pfeile zwischen den verschiedenen "Kästen" zu erkennen. Diese Stellen Übergänge zwischen den Animationen da und lassen sich mit Rechtsklick hinzufügen. Anschließend kann mit einem Klick auf den Pfeil rechts im Inspektor die Bedingung eingefügt werden. 

<h2 id="animationcontroller">Der Animatior-Controller</h2>

Als nächstes müssen in Unity die zuvor erstellten Animationen auf das Charakter-Modell angewandt werden. Dafür gibt es in Unity ein einfaches Tool: den Animator-Controller!



<h2 id="capsulecollider">Der Capsule-Collider</h2>

Nun ist der Charakter erstellt und importiert. Allerdings fällt dieser noch durch das vorhandene Terrain durch. Damit dies nicht passiert brauchen alle Objekte, die bei einer Berührung eine Bewegung ausführen sollen (wie z.B. dass der Charakter nicht durch den Boden fällt) einen von Unity bereitgestellten Collider. Dieser wird hinzugefügt, indem man den Charakter auswählt und dann auf Component > Physics > SphereCollider geht:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374528-cd3a8d80-05ef-11e9-9d0b-a028d61841c1.png" width="500px"></p>

Damit wird dann ein Collider auf den Charakter hinzugefügt und der Charakter fällt nicht mehr durch den Boden. Als Problem besteht dennoch weiterhin, dass der Charakter, wenn er auf einem Berghang steht, den Berg rückwärts herunterrollt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374574-64074a00-05f0-11e9-973e-3f3b572bebf8.png" width="500px"></p>

Dies geschieht, da der Collider ein Capsule-Collider, also teilweise rund, ist. Eine Lösung wäre es, einen BoxCollider auf den Charakter zu setzen. Das würde allerdings nur dafür sorgen, dass der Charakter nicht wie eine Kugel, sondern wie ein Quader nach hinten kippt. Also ist das Problem damit nicht gelöst. Gelöst wird es, indem das Charakter-Model editiert wird. Dafür wird der Charakter ausgewählt und auf dem Rigidbody unter "Constraints" bei "Freeze Rotation" die Box für X, Y und Z ausgewählt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374612-01627e00-05f1-11e9-8dc4-9331b4d3df2b.png" width="500px"></p>
Damit sich der Charakter nun bewegt, muss als nächstes ein Player-Controller geschrieben werden:

<h3 id="charactercontroller">Der Player-Controller</h3>
Als nächstes wird in den Assets ein Character Controller über Rechtsklick > Create > C#-Script erstellt. In diesem werden dann sämtliche Zeilen geschrieben, mit denen sich dann der Charakter im Game bewegt. 

``` 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;                    

public class PlayerController : MonoBehaviour {
    void Start() {       
    }
    void Update() {
    }
}
```

Der Controller hat die Haupt-Klasse: PlayerController. Diese ist vom Typ MonoBehaviour, die Klassenart, die Funktionen wie Start() und Update() bereitsstellt. Zudem die Funktion LateUpdate(), die allerdings erst später wichtig sein wird. In der Klasse sind die Funktionen Start() und Update(). Beide sind void, haben also keinen Rückgabewert. Die Start() Funktion wird zu Beginn des Programmablaufs nur ein einziges Mal aufgerufen. Die Update Funktion wird dann dauerhaft Frame by Frame aufgerufen. Daher werden in dieser die Abfragen wie Tastatureingaben oder Maus-Bewegungen abgerufen und auf das zu bewegende Objekt übertragen. 



## Das Pause-Menü

Als nächstes soll ein Pause Menü zum Spiel hinzugefügt werden. Dafür kann in Unity ein Element namens Canvas genutzt werden. Dies lässt sich mittels <b>Rechtsklick in die Assets > UI > Canvas</b> zu den Standart Elementen hinzufügen.

Das Canvas ist ein von Unity bereitgestelltes User Interface Element, welches einen Screen über den gesamten Bildschirm spannt.

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51204982-34084980-1905-11e9-9889-b57a4e006873.png" width="300px"></p>

Anschließend wird unter diesem mittels <b>Rechtsklick > UI > Panel</b> ein Panel erstellt. Dies füllt den Canvas farbig aus und stellt dadruch quasi die Oberfläche des Menüs dar. Rechts im Inspektor lässt sich nun einiges daran verstellen, in diesem Falle wurde nur die Hintergrundfarbe von weiß auf schwarz verändert.

Im Anschluss wird unter diesem Panel mit <b>Rechtsklick > UI > Button</b> ein Button erstellt.

<p align="center"><img width="300px" src="https://user-images.githubusercontent.com/42578917/51205414-24d5cb80-1906-11e9-9a3a-44e1af32befe.png"></p>

(HIER MUSS NOCH DIE ERKLÄRUNG HIN, WIE DIE BUTTONS ERSTELLT UND GESTYLED WURDEN)

Nun ist das Menü allerdings dauerhaft geöffnet und die Buttons haben keine Funktion. Um dies zu ändern, wird auf dem Canvas ein neues Script namens "EscapeMenu" erstellt. In diesem werden dann alle Bedingungen geschrieben, nach denen das Menü geöffnet wird und alle Aktionen definiert, die die erstellten Buttons ausführen sollen.

Wie alle C# Scripte in Unity hat auch dieses zu Beginneine Start() und eine Update() Funktion. Die Start()-Funktion kann gelöst werden, da sie in diesem Fall nicht benötigt wird.

Zu Beginn des Scripts werden wieder außerhalb der Funktion aber innerhalb der Klasse, alle Variablen und Objekte definiert, die benötigt werden. In diesem Fall sind das nur zwei:

```
public class EscapeMenu:MonoBehaviour {
    public static bool GamePaused = false;
    public GameObject pauseMenuUI
}
```
Die erste Variable ist vom Typ bool (also Wahrheitsaussagen) und soll als Überprüfung dienen, ob sich das Spiel aktuell im Pause-Modus befindet oder nicht (da ja abhängig davon das Menü entweder geschlossen, oder eben geöffnet wird). Zudem wird sie zu Beginn auf false gesetzt, da das Spiel zu Anfang nicht im Pause Modus ist. Die zweite Initialisierung ist ein GameObject. Auch dies ist public, weil später nocheinmal aus dem Unity-Inspector drauf zugegriffen werden muss. Dieses GameObject heißt pauseMenuUI, stellt also das Canvas dar. Die Logik dahinter ist, dass diesem GameObject das vorher initialisierte Canvas, also das Menü, zugewiesen wird und dieses dann abhängig vom Tastendruck (in diesem Falle die Escape-Taste) angezeigt oder eben nicht angezeigt wird.

Als nächstes wird die Update Funktion geschrieben:

```
public class EscapeMenu:MonoBehaviour {
    public static bool GamePaused = false;
    public GameObject pauseMenuUI
    
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(GamePaused == true) {
                Resume();
            }
            else {
                Pause();
            }
        }
    }
}
```

Wie bereits im CharacterController wird hier abhängig vom Tastendruck eine Aktion ausgelöst. In diesem Fall ist es die EscapeTaste, die durch die Bedingung Input.GetKeyDown(KeyCode.Escape) (also: Input eines Tastendruckes holen(von der Taste mit dem Code:Escape) abgefragt wird. Wird nun also die Escape-Taste gedrückt, wird der Inhalt der If-Schleife ausgeführt. In dieser If-Schleife ist eine weitere If-Schleife, die dann noch einmal überprüft, in welchem Zustand sich das Spiel gerade befindet, also ob das Pause-Menü offen oder geschlossen ist, in dem es den Inhalt der zuvor initialisierten Variable <b>GamePaused</b> abfragt. Falls das Spiel pausiert ist, führt es nun also die Funktion Resume() aus, die im nächsten Schritt erläutert wird. Ist das Spiel nicht pausiert, wird die Funktion Pause() ausgeführt.

Als nächstes müssen dann die Pause() und die Resume() Funktion geschrieben werden. Diese werden unter der Update Funktion geschrieben und enthalten folgendes: 

```
public class EscapeMenu:MonoBehaviour {
    public static bool GamePaused = false;
    public GameObject pauseMenuUI
    
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(GamePaused == true) {
                Resume();
            }
            else {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
```
Zunächst zur Pause() Funktion:
Diese hat den ausgangspunkt, dass das Menü geschlossen ist. Um es daher zu öffnen (da ja beim pausieren das Pausemenü geöffnet werden muss) wird das zu Beginn gesetzte GameObject pauseMenuUI mit dem Befehl pauseMenuUI.SetActive(true) auf aktiv gesetzt, wodurch es dem Spieler sichtbar wird. Als nächsten Schritt muss dafür gesorgt werden, dass das Spiel währenddessen nicht weiterläuft. Dies geschieht, indem die im Spiel vorhandene Zeit auf null gesetzt wird. Das geschieht mithilfe des Befehls Time.timeScale = 0f; - die Time.timeScale (also die "Spielzeit") wird auf null gesetzt, sie wird angehalten. Als letzten Schritt muss noch die Variable GamePaused auf true gesetzt werden, um beim nächsten Escape-drücken signalisiert wird, dass das Spiel sich aktuell im Pause-Modus befindet. 


Nun zur Resume() Funktion
Sobald diese ausgeführt wird, muss natürlich das Menü nach dem Tastendruck wieder verschwinden. Um dies zu erreichen, wird pauseMenuUI, also das zuvor initialisierte GameObject, mittels pauseMenuUI.SetActive(false) als nicht aktiv (false) gesetzt. Es wird also deaktiviert! Als nächsten Schritt muss natürlich die Spielzeit wieder auf "normal" gesetzt werden. Daher wird hier einfach Time.timeScale = 1f; gesetzt. Als letztes wird die GamePaused Variable auf false gesetzt, das Spiel geht nämlich von hier an weiter.

Als letztes muss natürlich noch dem "Beenden"-Button eine Funktion zugewiesen werden. Dafür wird eine weitere Funktion mit dem Namen QuitGame() initialisert:

```
public class EscapeMenu : MonoBehaviour
{   
    public void QuitGame()  {        
    }    
}
```
Im Anschluss wird in diese ein einziger einfacher Befehl geschrieben:
```
public class EscapeMenu : MonoBehaviour
{    
    public void QuitGame()  { 
        Application.Quit();
    }    
}
```
Dieser lässt die Funktion schon vermuten: Er schließt ganz einfach die Anwendung!

Damit wäre auch dieses Script fertig und sieht im ganzen wie folgt aus:

```
public class EscapeMenu : MonoBehaviour {
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()  {
        if(Input.GetKeyDown(KeyCode.Escape))  {
            if(GamePaused == true)   {
                Resume();
            }
            else   {
                Pause();
            }
        }
    }
    public void Resume()  {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    void Pause()  {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
    public void QuitGame()  {
        Application.Quit();
    }    
}
```

Damit diese Bedingungen und Funktionen nun auch Anwendung finden gibt es in Unity für Buttons ein Feature: Im Inspektor lässt sich unter OnClick() eine Reaktion auf das Drücken des Buttons einführen. Dafür geht man nun auf das + , zieht in das Object das zuvor erstellte Canvas rein (da auf diesem ja das Script mit den jeweiligen Funktionen liegt) und wählt oben rechts im Dropdown-Menü die jeweilige Funktion aus dem EscapeMenu-Script aus (Beim Resume Button die Resume-Funktion oder Beim Beenden Button eben die Quit-Funktion). Damit wird automatisch eine Abhängigkeit erstellt und der Button hat eine Funktion!

<p align="center"><img width="400px" src="https://user-images.githubusercontent.com/42578917/51206209-d45f6d80-1907-11e9-964e-1f93cec748b7.png"></p><br>
<p align="center"><img width="400px" src="https://user-images.githubusercontent.com/42578917/51206147-b8f46280-1907-11e9-8b6f-918cb9c937eb.png"></p>


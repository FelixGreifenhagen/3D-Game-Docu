
<img src="https://user-images.githubusercontent.com/42578917/51550957-c19bea00-1e6d-11e9-9baf-56e92610e7fe.png">
<b>Beschreibung: Ein Abendteurer strandet auf einer einsamen Insel, die schon seit Jahren verlassen ist. Nun muss er viele Probleme lösen und Sachen sammeln um der Insel zu entkommen und sich selbst zu retten...</b>
<br>
<br>
In diesem Mini-Game strandet ein Junge alleine auf einer kleinen Inselgruppe, die schon seit Jahren verlassen ist. Nun muss er sich den Gefahren und Aufgaben dort stellen, um seinen Weg zurück nach Hause zu finden. Von Feinden umgeben und mit rudimentären Informationen muss der Spieler hier alle Teile finden und sammeln, um ein Boot zu bauen um zurück zur Zivilisation zu kommen.

# Das Making-Off

## Inhaltsverzeichnis

* <a href="#">Die Idee</a>
* <a href="#">Die benötigten Programme</a>
* <a href="#">Zum Charakter
    + <a href="#">Die Charaktererstellung</a>
    + <a href="#">Der Animator-Controller</a>   
    + <a href="#">Der Capsule-Collider</a>
    + <a href="#">Der Character-Controller</a>
 


<h1>Die Grundlagen</h1>

Zunächst müssen erstmal, um später ein solides Gameplay zu implementieren, die Grundlagen in Unity einrichten. Dazu gehören unter anderem das Charaktermodel, ein Controller um Bewegungen zu steuern, Animationen für den Charakter, ein Terrain mit Border, sowie Menüs und weiteres. 

<h2 id="charakter">Der Charakter</h2>

In diesem Fall wird, um das Modell später zu animieren, ein Character-Model benötigt, welches ein Exoskelett enthält. Zudem muss das Charakter-Model menschliche Proportionen aufweisen. Dies kann alles in Adobe Fuse (Beta) gestaltet werden. Nach dem start erhält man dort die Möglichkeit, einen Charakter zu gestalten und sowohl den Körper, als auch das Gesicht sowie die Kleidung selber zu gestalten:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374742-923a5900-05f3-11e9-930f-a08619cca564.png" width="600px"></p>

Sobald der Charakter dann beendet ist, lässt sich oben rechts mit "Save to Maximo" in Maximo exportieren. In Mixamo lassen sich dann Animationen auf einen Charakter anwenden bzw. eigene Animationen mithilfe des von Fuse angewandten Exoskelett erstellen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51466760-3e926b00-1d6b-11e9-921a-4b39743ccb33.png" width="600px"></p>

Sobald dann auch die Animationen angewandt sind, lässt sich das Modell, sowie die Animationen als .fbx datei exportieren. Diese lässt sich dann per Drag&Drop in Unity importieren.

<h2 id="animationcontroller">Der Animatior-Controller</h2>

Als nächstes müssen in Unity die zuvor erstellten Animationen auf das Charakter-Modell angewandt werden. Dafür gibt es in Unity ein einfaches Tool: den Animator-Controller!

In diesem werden sämtliche Animationen hinzugefügt und verwaltet. Man erreicht ihn mittels des Reiters oben neben Scene und Game bzw. über <b>Window > Animation > Animator</b>

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51618452-a7761080-1f2e-11e9-843d-71d63eb24277.png" width="300px"></p>

Als nächstes werden dann Charakter und Animationen unten in die Projektdatein gezogen. Sobald der Charakter dann in der Szene paltziert ist, kann in den Dateien eine Animation ausgewählt und auf den Charakter gezogen werden. Damit erstellt Unity einen sogenannten <b>Animator </b>:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51619541-d8efdb80-1f30-11e9-8319-9dd0df862037.png" width="400px">
    
In diesen ist bereits der Controller (wird automatisch hinzugefügt und kann dabei belassen werden) und der Avatar (der in diesem Fall den Charakter mitsamt Animation darstellt. In Unity werden diese zusammen konvertiert, das Endergebnis zeigt aber nur einen Charakter, den aber mit mehreren Animationen an). Zudem ist zu beobachten, dass im Animatior-Controller mit dem Hinzufügen von neuen Animation auch kleine neue Kästchen entstehen:

FOTO VOM ANIMATOR CONTROLLER

Das ist die Besonderheit vom Animator in einer Engine wie Unity: die Verwaltung von Animationen erfolgt grafisch! 

Noch ist zu erkennen, dass es ein orangenes Kästchen und mehrere graue gibt. Das Orangene ist dabei der IDLE, also die Standart Animation, und die grauen sind die anderen Animationen. Per <b>Rechtsklick auf ein Kästchen > Set as Layer Default State </b> lässt sich auch ein anderes Kästchen als IDLE/Default bestimmen. 

Sobald dann sämtliche Animationen zum Animator-Controller hinzugefügt wurden, sind schon einige Pfeile zwischen den verschiedenen Kästen zu erkennen. Diese stellen "Übergänge" zwischen den Animationen da und lassen sich mit <b> Rechtsklick > Make Transition </b> hinzufügen. Anschließend kann mit einem Klick auf den Pfeil rechts im Inspektor die Bedingung (unter "Conditions" eingefügt werden. 

<p align="center"><img width="400" src="https://user-images.githubusercontent.com/42578917/51620344-713a9000-1f32-11e9-8c1e-4dc91c343fa0.png"></p>

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

## Der Mouse Cursor

Nachdem nun ein Pause-Menü eingerichtet wurde, lässt sich dies auch normal bedienen. Allerdings fällt noch auf, dass die Maus sowohl im Menü, als auch inGame zu sehen ist. Dies soll natürlich nicht sein, die Maus soll inGame nicht zu sehen sein. Das Problem daran, sie einfach auszublenden, ist, dass sie im Menü ja weiterhin sichtbare sein soll. Also muss in einem Script, abhängig davon ob das Menü geöffnet ist, die Maus aus- oder eben eingeblendet werden. Dafür wird zunächst ein neues C#-Script erstellt und folgendes hinzugefügt:

```
public class CursorScript:MonoBehaviour {
    bool CursorIsLocked;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        CursorIsLocked = true;
    }
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape) && !CursorIsLocked) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
            CursorIsLocked = true;
           }
        else if(Input.GetKeyDown(KeyCode.Escape) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            CursorIsLocked = false;
        }
    }
}
```
Dieses Script führt diese Aktionen aus und funktioniert wie folgt:

Zunächst wird erstmal eine Variable vom Typ Boolean mit dem Namen CursorIsLocked erzeugt. Mit dieser soll später der aktuelle Zustand überprüft werden, ob der Mauszeiger aktuell an oder aus ist. Als nächstes wird in der void Start ein Grundzustand erzeugt, also wie die Maus zu Beginn des Spiels aussehen soll:
```
void Start() {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    CursorIsLocked = true;
}
```
Grundsätzlich soll der Cursor unsichtbar sein, und die Varibale CursorIsLocked soll true sagen. Der Befehlt Cursor.lockState=CursorLockMode.Locked, setzt den Cursor zunächst einmal auf locked, also unbeweglich auf dem Bildschirm. Dann wird mit Cursor.visible=false der Cursor unsichtbar gesetzt. Als nächstes muss dem Programm natürlich noch gesagt dass der Cursor jetzt gerade gelockt/unsichtbar ist. Die Variable wird also auf true gesetzt.

Damit es nun möglich ist, auch im aktiven Spiel den Zustand der Maus zu verändern (z.B. wenn man das Menü öffnet), wird der Rest in die Update() Funktion geschrieben, also mit jedem Frame überprüft:

```
void Update() {
    if(Input.GetKeyDown(KeyCode.Escape) && !CursorIsLocked) {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        CursorIsLocked = true;
    }
    else if(Input.GetKeyDown(KeyCode.Escape) && CursorIsLocked) {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        CursorIsLocked = false;
    }
}
```
Der Zustand der Maus (ob sie unsichtbar oder sichtbar ist) soll natürlich nur mit dem Öffnen des Menüs beeinflusst werden. Da das Menü mit der Escape Taste geöffnet wird, kann auch der Mauszeiger vom Drücken der Escape-Taste abhängig gemacht. Also wird mit der If-Schleife überprüft, ob die Escape-Taste gedrückt wird. Wie genau das funktioniert, lässt sich <a href="#">hier</a> nachlesen. Gleichzeitig muss allerdings auch geguckt werden, ob der Mauszeiger aktuell gelockt ist. Zuvor wurde ja eine Variable namens CursorIsLocked erstellt, in der der aktuelle Zustand der Maus gespeichert ist, welche daher dafür ausgelesen werden kann. Also wird in die If-Schleife noch eine zweite Bedingung hinzugefügt, nämlich ob der Cursor NICHT gelockt ist (Nicht-true wird durch ein Ausrufezeichen (!) vor der Bedingung symbolisiert).

Wenn nun also Escape gedrückt wird UND der cursor nicht gelockt ist, wird die If-Schleife ausgeführt. Die If-Schleife enthält nun alle zuvor in der Start() Funktion verwendeten Befehle, die den Cursor festsetzen, unsichtbar machen und die Variable auf true setzen. Die Schleife würde also ausgeführt werden, wenn man sich im Menü befindet (Die Maus also sichtbar und NICHT gelocked ist = CursorIsLocked auf false ist) und dann mit Escape zurück ins Spiel wechselt.

Andersrum muss natürlich auch der Fall abgedeckt werden, dass man aus dem Spiel ins Menü wechselt, der Cursor also von der Locked-Position in die nicht-LockedPosition wechselt. Dies wird mit einem else if, also einem an eine if-Schleife gebundenen else ausgeführt. In dieser wird überprüft, ob der Escape-Button gedrückt wird, sowie ob der Cursor aktuell gelockt ist. Ist dies der Fall wird die if-schleife ausgeführt. In dieser wird eigentlich nur genau das Gegenteil von den Befehlen in der ersten if-Schleife ausgeführt. Statt CursorLockMode.Locked, wird CursorLockMode.None gesetzt, sodass der Cursor NICHT mehr gelockt ist. Genauso wird Cursor.visible auf true, also auf sichtbar gesetzt. Und die CursorIsLocked wird auf false gesetzt, da der Cursor ja von nun an nicht mehr locked ist.

Als nächstes muss das Script auf die MainCamera gezogen werden. Wenn man nun das Game ausprobiert, sieht man, dass die Maus genau das macht, was erwünscht war.

Nun kommt allerdings noch ein weiteres Problem auf. Wenn man im zuvor erstellten Menü auf Fortsetzen klickt, verschwindet die Maus nicht.

# Das Game-Design

Natürlich ist für ein gutes Computerspiel nicht nur eine funktionierende GameEngine mit Animationen und einem Charakter notwendig, sondern es wird auch eine ansprechende Spielwelt benötigt. Dafür wird zunächst einmal ein Untergrund zum Laufen benötigt. Diesen stellt Unity unter <b>GameObject > 3d Object > Terrain</b> bereit. 

<p align="center"><img width="300px" src="https://user-images.githubusercontent.com/42578917/51617903-7812d400-1f2d-11e9-8c47-add51e198616.png"></p>

# Das Gameplay

Nachdem nun eine ansprechende Spielwelt erstellt wurde, muss der zuvor implementierte Charakter auch mit dieser Interagieren können. Oft erfolgt dies in Form von Quests/Aufgaben, für die der Spieler etwas finden, sammeln oder auf sonstige Weise mit der Welt interagieren. In diesem Fall beschränken sich die Aktionen vor allem auf das finden und sammeln von Objekten. 

### Das Inventory-System

Als nächstes soll ein Inventory System implementiert werden, in dem Objekte gespeichert werden, die zuvor aufgesammelt wurden

### Das Health-System

Ein weiterer wichtiger Aspekt für das Gameplay ist ein Health-System.



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
 

<h1>Die Idee</h1>

Die Idee des Projektes bestand darin, ein 3D-Game zu erschaffen, das einer Art Escape-Game gleicht. Dabei sollten sowohl Spielmechanik, als auch Gameplay und Setting des Spiels dem eines anderen Indie-Games in nichts nachstehen. Der Anspruch war dabei, auf so wenig vorgefertigte Assets und Texturen wie möglich zurückzugreifen, um den vollständigen Umfang und Anspruch eines solchen Spiels zu visualiseren. 

<h1>Die benötigten Programme</h1>

Entsprechend dem Anspruch werden für die Erstellung eine Reihe von Programmen benötigt. Diese sind hier in Anwendungsgebiete unterteilt:

* Unity
* Blender
* Adobe Photoshop
* Abobe Fuse (Mixamo)
* Fl Studio
* Visual-Studio (kommt mit Unity)
* Audacity

<b>Unity:</b> Unity ist die Grundlage dieses Spiels. Es ist eine GameEngine, die sowohl Grafiken, als auch Scripte verarbeiten und in einem Overlay mit Preview-Modus darstellen. Unity wird in diesem Fall sowohl zur Erstellung des Charakters mit Bewegung, Animationen etc. als auch zur Erstellung von Setting und Programmeinstellungen wie Menüs genutzt.

<b>Blender:</b> Blender ist der zweite große Baustein dieses Projektes. Sämtliche Modelle, die nicht in Unity erstellt werden können, bzw. über die Modellierungs-Optionen von Unity (die ziemlich beschränkt sind...belastend) hinausgehen, werden in Blender erstellt und dann in Unity importiert</b>

<b>Adobe Photoshop:</b> Adobe Photoshop haben wir benutzt, um Texturen zu malen (z.B. für grünen Boden, Weg, Berge) und den Banner auf der Projektseite anzufertigen. Da wir beiden Photoshop besitzen und Photoshop allgemein sehr gekannt ist, haben wir dieses Bildbearbeitungprogramm für diese Aufgaben benutzt.

<b>Adobe Fuse:</b> Adobe Fuse ist ein neues Programm aus der Creative Cloud, welches sich aktuell in der Beta befindet. Es ist darauf spezialisiert auf einfachem Wege menschliche 3D Modelle zu kreieren. Adobe Fuse haben wir dementsprechend für den vom Spieler gesteuerten Charakter verwendet.
<b>FL Studio:</b> Da wir jeden Aspekt eines Indie-Games selbst umsetzten wollten, haben wir uns auch vorgenommen selbst einen Soundtrack zu machen. FL Studio kennen wir bereits und ist als Digital Work Station für Musik gut geeignet.


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

Um dort eine Condition auswählen zu können, muss zuerst eine erstellt werden! Eine Condition wird von Unity als ein Script mit einer gleichnamigen Boolean Variable verstanden, welche in abhängigkeit die Werte true oder false annimmt. Um also eine Condition zu erstellen, muss zunächst ein neues C#-Script erstellt werden. Dies wird "Moving" genannt und geöffnet. 

Da das Script selber von Unity als eine Boolean Variable verstanden wird, muss diese nicht mehr definiert werden. Allerdings muss zuvor noch definiert werden, dass dies ein Script ist, welches im Animator verwendet wird. Dafür muss zunächst ein neuer public Animator namens move definiert werden. Dies holt sich quasi den Animator ins Script und kann in diesem den Zustand von Conditions ändern. Damit dieser auch erreicht wird, muss er zudem in der void Start() initialisiert werden:

```
public class Moving:MonoBehaviour {
    public Animator move;
    
    void Start() {
        move = GetComponent<Animator>();
    }
}

```
Das stellt quasi dar: "Ich brauche einen neuen Animator, das ist dieser und in ihm sollen später die Veränderungen Wirkung finden".

als nächstes soll natürlich auch irgendein Ereignis im Script stattfinden. Dafür wird in die void Update() folgendes geschrieben:

```
void Update() {
    if(Input.GetKey(KeyCode.W)) {
        move.SetBool("Moving", true);
    }
    if(!Input.GetKey(KeyCode.W)) {
        move.SetBool("Moving", false);
    }
}
```
Es werden wird wie im Character Controller wieder der Zustand der Taste W abgefragt. Diesmal wird allerding etwas anderes dabei ausgelöst: Undzwar wird auf mittels move.SetBool() im Animator move (der vorher definiert wurde) auf eine Variable zugegriffen und sie "gesetted" (daher das "SetBool"). In den Klammern danach wird zunächst dargestellt, um welche Variable es geht (nämlich "Moving") und auf was sie gesetzt wird (false bzw. true). Der volle Command move.SetBool("Moving", false) nimmt sich (das verhältnis von conditions und variablen in diesem Script wurde zuvor bereits angeschnitten) die Condition "Moving" im move-Animator, und setzt sie als bool false. Andersrum wird das ganze mit true natürlich auch gemacht.

Nachdem das Script gespeichert wurde, kann die Condition im Animator gesetzt werden. Dafür muss zunächst ein neuer Parameter definiert werden: Dafür geht man links unter Parameters auf das + und wählt Bool aus (da ja am Ende auch eine Boolean Condition verwendet werden soll). 


Anschließend wird der Parameter genauso genannt wie das zuvor erstellte Script, in diesem Fall "Moving". Zuletzt kann noch mit klicken auf einen der Pfeile, mit dem Plus bei Condition eine Condition ausgewählt werden, und daneben gewählt, in welchem Zustand diese ausgeführt wird. In diesem Fall soll bei Moving = true der Pfeil von der Idle Animation zur Lauf-Animation getriggered werden. Also wird dies in der Condition definiert: 

<p align="center"><img width="600px" src="https://user-images.githubusercontent.com/42578917/51623012-0e4bf780-1f38-11e9-98ae-08a092c2a803.png"></p>

Das ganze kann natürlich auch mit Moving = false in die andere Richtung gemacht werden, sodass, wenn der Charakter aufhört zu laufen, zurück in die Idle Animation gewechselt werden. 

Nun ist die Condition erstellt und der Animator Controller eingerichtet. Als letztes muss noch ein kleiner Haken im Inspektor entfernt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51623180-6551cc80-1f38-11e9-920e-5c2bc512e829.png" width="400px"></p>

Der Haken sorgt dafür, das die Animation, sobald sie beendet ist, aufhört, und der Animator Controller wieder in die Idle Animation wechselt. Da dies nicht erwünscht ist (die Animation soll sich beim Laufen ja schließlich die ganze Zeit wiederholen), muss der Haken entfernt werden.

Sobald dies erledigt ist, ist die Animation für das Laufen eingerichtet und kann verwendet werden. Das gleiche kann natürlich auch mit anderen Tasten und anderen Animationen ausgeführt werden. Dafür müssen lediglich neue Scripte mit anderem Namen erstellt werden und weitere Conditions erstellt werden. Zudem muss in den Scripten in der If-Schleiffe die Taste geändert werden, mit der die Animation gestartet werden soll. Nachdem all die Animationen hinzugefügt wurden, kann der Charakter sauber und schön in alle Richtungen laufen.

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

Nun kann man rechts auf <b>Paint Texture > Raise or Lower Terrain</b> mit einem Pinsel das Terrain quasi nach oben und unten "malen". Damit lassen sich verschiedene Landschaften erzeugen, auf denen das Spiel dann stattfindet. 

## Die Texturen

Damit das Terrain auch einigermaßen aussieht, muss es auch mit Texturen ausgestattet werden. Dafür geht man unter <b>Terrain > Paint Terrain > Paint Texture </b> unten auf einen der Brushes und darpber unter <b>Edit Terrain Layers</b> weitere Texturen hinzufügen. Die Texturen werden in diesem Fall in Microsoft Photoshop erstellt.

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51914562-70de4100-23d9-11e9-8a49-0fe9f11eaaaf.png" width="600px"></p>

Dafür wird in Photoshop eine neue Datei erstellt, diese Fläche dann in der jeweiligen Farbe eingefärbt, und anschließend mit einem beliebigen Pinsel die Unregelmäßigkeiten hinzugefügt.

Sobald dann mehrere Texturen erstellt sind, können diese per Drag&Drop in die Unity Dateien hinzugefügt werden und unter <b> Edit Terrain Layers > Add Layer</b> zu den Terrain Layers hinzugefügt werden. Sobald dann ein Brush ausgewählt und unten die Brush Größe (Brush Size) sowie die Deckkraft (Opacity) eigestellt ist, kann auch der Karte wie auf einem Blatt Papier gemalt werden und die Karte so gefärbt werden, wie man will.

Zuden lassen sich auf dem Terrain unter <b> Paint Trees bzw. Paint Details</b> auch Map-Objekte wie Bäume oder Gras hinzufügen. Diese lassen sich entweder aus dem Unity Store als Standart Asset herunterladen oder als eigene Modelle hinzufügen, wie zum Beispiel so:
<br>
<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51916309-560dcb80-23dd-11e9-9570-ca86b3bcdd7c.png" width="600px"></p>

## Die Map-Objekte

Nun kann man natürlich, wie schon bei den Texturen gesagt, nicht nur mit Unity-Internen Modellen und Texturen arbeiten, sondern kann auch unter anderem Objekte wie Bäume oder Steine extern modellieren und dann anschließend in Unity für den Map-Bau verwenden. In diesem Projekt wurden folgende Objekte in Blender modelliert:

* Bäume/Baumstümpfe
* Steine
* Krabbe + Animation
* Haus + Innenraum
* Büsche
* Kakteen
* Treppen
* Gras

Daher dass die Objekt modellierung von Unity ziemlich begrenzt ist und sich vor allem auf simple geometrische Formen bezieht, muss für die Modellierung dieser Objekte ein spezielles Modellierungs-Programm, in diesem Fall Blender, zur rate gezogen werden. 

Um diese Objekte dort gut zu modellieren startet man zunächst mit einem simplen geometrischen Körper wie z.B. einem Würfel, einem Zylinder oder einer Icosphäre. Mithilfe verschiedener Shortcuts, kann nun jeder möglicher Körper erschaffen werden.
Im Fall einer Palme wird mit einem Zylinder begonnen aus dem ein Palmenstamm entstehen soll. Um ein Objekt zu erstellen muss der Shortcut "Shift + A" gedrückt werden und danach der Zylinder ausgewählt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53328827-1d351980-38eb-11e9-8d07-3266a260eecc.png" width="500px"></p>

Wie viele Seiten der Zylinder hat, also wie rund dieser im Prinzip ist, kann über "Subdivides" gesteuert werden. In diesem Spiel wird ein gröberer und reduzierter Stil verfolgt, der Stamm der Palme soll also nicht exakt rund sein, aber auch nicht nur 4 Seiten haben:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53328969-5ec5c480-38eb-11e9-9d33-d91af5bbffa2.png" width="500px"></p>

Um den Zylinder nun wie gewünscht zu bearbeiten muss das richtige Selektionswerkzeug ausgewählt sein. Im nächsten Schritt soll der Zylinder in die Länge gezogen werden um mehr den Maßstäben eines Palmenstamms zu entsprechen, daher muss die Flächenauswahl eingeschaltet werden. Nun ist es möglich die obere Fläche des Zylinders auszuwählen und diese nach oben zu ziehen. Nun ist der Zylinder in die Länge gezogen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329436-5de16280-38ec-11e9-8685-36825acd2408.png" width="1000px"></p>

Damit der Stamm ein wenig natürlicher aussieht, soll er nicht überall den gleichen Durchmesser haben. Um diesen Effekt zu erreichen, kann die obere Fläche weiterhin ausgewählt bleiben. Mit dem Shortcut "s" wird das Skalierungswerkzeug aktiviert und durch verschieben der Maus kann der Durchmesser der oberen Fläche vergrößert und verkleinert werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329653-d516f680-38ec-11e9-9fee-889c19910acd.png" width="500px"></p>

Um die typische Stufen im Stamm zu Formen muss der Zylinder weiter unterteils werden. Mit einem Shortcut "strg + r" kann dies durchgeführt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329822-4656a980-38ed-11e9-8fe9-627d33d8d2a3.png" width="400px"></p>

Nun muss von der Flächenauswahl in die Kantenauswahl umgestellt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329890-7bfb9280-38ed-11e9-805d-1a4621728772.png" width="500px"></p>

Nun kann die gesamte Kante, welche eben hinzugefügt wurden mit "Shift + Rechtsklick" ausgewählt werden. Mit dem Shortcut "s" kann nun diese Schnittfläche im Durchmesser vergrößert werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329947-9fbed880-38ed-11e9-97f8-423a8520d9ab.png" width="500px"></p>

Das muss so lange wiederholt werden bis der gesamte Stamm diese Form hat:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53330043-d268d100-38ed-11e9-8998-648f37d2f6a7.png" width="500px"></p>

Was den Stamm ebenfalls dynamischer aussehen lässt ist eine leichte Krümmung. Um diese zu erzielen wird der Teil des Stammes ausgewählt, welcher verformt werden soll und die Taste "g" betätigt. Nun kann man mit dem Mausrad den Kreis vergrößern/verkleinern der an Stelle der Maus angezeigt wird. Wenn man nun die Maus bzw. den Kreis bewegt verformt sich der Stamm der Palme in Richtung der Maus im Bereich des Kreises:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53330106-f88e7100-38ed-11e9-923c-0e84120b896c.png" width="500px"></p>

Das letzte Detail am Stamm wird mit dem Shortcut "r" ermöglicht. Es wird wieder die obere Fläche am Stamm ausgewählt und eben erwähnte Taste gedrückt. Nun kann ähnlich wie bei der Skalierung die Maus bewegt werden um die obere Fläche zu drehen, der Rest des Zylinders passt sich dieser Rotation an. Um eine genauere Rotation in die gewünschte Richtung zu erzielen, kann nach drücken der "r" Taste ebenfalls "x","y" oder "z" gedrückt werden um die Rotation auf die jeweilige Achse zu begrenzen. Das kann auch für die anderen bereits bekannten Shortcuts angewendet werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53330181-2a073c80-38ee-11e9-9c1e-f8776e5f5d61.png" width="400px"></p>

Als letzter Schritt wird dem Stamm ein Material hinzugefügt um den Stamm einzufärben. Um ein Material zu erstellen gibt es rechts einen Knopf:

Als nächstes müssen die Palmenblätter modelliert werden. Dafür muss wie zu Anfang mit "Shift + A" ein neues Objekt erstellt werden. Macht man das während das alte Objekt noch ausgewählt ist, sind diese miteinander verknüpft und das neue Objekt ist ein Untergeordnetes Objekt zum Stamm:

Diese Fläche muss wieder unterteilt werden. Diesmal wird die Eckenauswahl benutzt. Nun werden die Ecken so verschoben, dass eine Blattform entsteht:

Mit den mittlerweile bekannten Shortcuts kann nun ein Palmenblatt geformt werden:

Auch hier wird wieder ein neues Material erstellt um die grüne Farbe des Palmenblattes zu visualisieren:

Das Palmenblatt kann nun mit "Shift + d" dupliziert werden. Nun werden die Palmenblätter so um den Stamm angefügt, dass eine natürliche Verteilung besteht:

Die fertige Palme kann nun mit "Datei > Exportieren > .fbx" als eine Modelldatei exportiert werden:

Das Filmbox-Format (fbx) kann von Unity ausgelesen werden. Dafür zieht man sie in Unity per Drag and Drop in die Dateien:


# Das Gameplay

Nachdem nun eine ansprechende Spielwelt erstellt wurde, muss der zuvor implementierte Charakter auch mit dieser Interagieren können. Oft erfolgt dies in Form von Quests/Aufgaben, für die der Spieler etwas finden, sammeln oder auf sonstige Weise mit der Welt interagieren. In diesem Fall beschränken sich die Aktionen vor allem auf das finden und sammeln von Objekten. 

### Objekte aufsammeln

Zunächst einmal soll der Charakter möglich sein, Objekte aufzusammeln. Die Logik dahinter lautet wie folgt: Der Charakter soll in der Nähe des Objektes einen Text angezeigt bekommen, dass er fähig ist, ein bestimmtes Objekt aufzusammeln. Dies allerdings nur, wenn das jeweilige Objekt noch existiert. Wenn der Spieler dann die Taste drückt, wird das Objekt zerstört und der Text wieder ausgeblendet.

Zunächst einmal muss ein Objekt erstellt werden, welches dann aufgesammelt wird. In diesem Fall ist dies ein Schlüssel. 

<p align="center"><img width="600px" src="https://user-images.githubusercontent.com/42578917/53263002-7b3de300-36d8-11e9-8bf4-d7bd924536ec.png"></p>

Zudem wird ein ganz normaler Cube unter <b> GameObject > 3D Object > Cube </b>hinzugefügt. Dieser wird genau über den Schlüssel gesetzt und wird später genutzt, um den Abstand zwischen Spieler und Schlüssel zu bestimmen. Von diesem wird dann per Rechtsklick auf den Mesh Renderer und <b> Remove Component </b>der Mesh Renderer entfernt. Damit wird das Objekt zwar durchsichtig, bleibt aber als Objekt in der Szene vorhanden und lässt sich im Spiel verwenden. 

Als nächstes wird ein Script geschrieben, welches all diese Schritte vollzieht. Dafür wird ein neuer Ordner mit einem C#-Script mit dem Namen PickUpScript.cs erstellt.  Dort müssen zunächst einmal alle Objekte selektiert werden. Dafür werden drei neue Variablen für GameObject erstellt:

```
public class PickUpScript:MonoBehaviour {
    public GameObject KeyBox;
    public GameObject Player;
    public GameObject AxeTextUI
    public float Distance;
}
```
Neben dieser wird eine Variable vom Typ float erstellt, in der später der Abstand zwischen Spieler und Objekt gespeichert wird. Da das Ergebnis des nachher verwendeten Objektes eine Gleitkommazahl ist, muss hier statt einer integer eine Variable vom Typ float verwendet werden. 

Um nun weiter zu verfahren wird ein Text benötigt, welcher den Spieler darauf hinweist, den Schlüssel aufzusammeln. Dies wird auf die selbe Weise erstellt, wie das Escape-Menü erstellt wurde. Dies ist <a href="#">hier</a> nachzulesen. In diesem Fall wird im Canvas statt eines Buttons ein Text erstellt. Dieser kann dann rechts im Inspektor bearbeitet werden. 

Als nächstes wird die Start-Funktion gefüllt:

```
void Start() {
    AxeTextUI.SetActive(false);
}
```
Da nämlich aktuell der Schriftzug noch immer dauerhaft angezeigt wird, wird er in dieser Zeile zunächst einmal standartmäßig auf nicht-anzeigen gestellt.

Als nächstes muss dann etwas passieren wenn man sich dem Schlüssel nähert. All die Logik dahinter wird innerhalb der Update() Funktion geschrieben:

```
void Update() {
    Distance = Vector3.Distance(KeyBox.transform.position, Player.transform.position);
}
```
Hier wird nun der Abstand des Objektes KeyBox vom Abstand des Objektes Player in der vorher deklarierten Variable Distance gespeichert. Dafür wird das Unity-interne Vector3.Distance() verwendet. Dieses prüft in einem dreidimensionalen Raum (Vector3) den Abstand von zwei Objekten, die in den nachfolgenden Klammern übergeben werden. In diesem Fall sind das die beiden GameObjekts KeyBox und Player. an diese wird noch das .transform.position angehängt, was deklariert, dass hierbei die Position beider Objekte genommen und an die Vector3.Distance übergeben werden. Wie eingangs erwähnt, wird das Ergebnis dieser Operation dann in der Variable Distance gespeichert.

Nachdem nun die Entfernung geprüft wurde, muss auch etwas mit der Information angefangen werden. Dafür wird wie üblich eine if-Schleife verwendet. In dieser sollen dann mehrere Operationen ausgelöst werden.
```
if(Distance <=3) {
    if(GameObject.Find("Schlüssel") != null) {
        
    }
}
```
In diesem Fall wird zunächst einmal geprüft, ob der Abstand gleich oder kleiner als drei ist, da nur hierbei eine Aktion (das Anzeigen des Textes) ausgeführt werden soll. Danach wird noch eine weitere if-Schleife verwendet, um zu verhindern, dass eine Aktion ausgeführt wird, wenn der Schlüssel schon längs aufgesammelt wurde. Diese if-Schleife prüft also, ob das Objekt "Schlüssel" noch existiert mittels GameObject.Find("Schlüssel"). Wenn diese Operation ungleich (!=) null ist, der Schlüssel also quasi nicht-nicht, also definitiv existiert, wird diese If-Schleife geöffnet. 

In dieser werden dann folgende Befehle verwendet:

```
if(GameObject.Find("Schlüssel") != null) {
    AxeTextUI.SetActive(true);
    if(Input.GetKey(KeyCode.E)) {
        Destroy(gameObject)
        AxeTextUI.SetActive(false);
    }
}
```

Ist nun der Abstand kleiner als 3 und existiert der Schlüssel noch werden diese Aktionen getätigt:

Zuerst wird der Text mit AxeTextUI.SetActive(true) auf "anzeigen" gesetzt, sodass der Spieler diesen auf dem Bildschirm eingeblendet sieht. Als nächstes wird dann geprüft, ob der Spieler E drückt. Wie genau dies funktioniert bzw. was der Code bedeutet, lässt sich <a href="#">hier</a> nachlesen. Wenn der Spieler E drückt, werden zwei Aktionen ausgeführt: Erstens wird der Schlüssel, also das gameObject auf dem das Script drauf ist mittels Destroy(gameObject) zerstört. Zweitens wird der Text, der zum aktuellen Laufzeit-punkt noch eingeblendet ist, ausgeblendet. Der Spieler bekommt also einen Text angezeigt und sobald er E drückt wird dieser wieder ausgeblendet und der Schlüssel zerstört. 

Als letztes muss noch eine Option eingebaut werden, sollte der Spieler sich wieder vom Schlüssel entfernen. Dafür wird ein else an der if-Schleife angebracht, in der geprüft wird, ob der Abstand kleiner als 3 ist. In diese wird folgender Code geschrieben:
```
else {
    AxeTextUI.SetActive(false);
}
```
Der Befehl wurde zuvor bereits erklärt und bewirkt diesmal wieder ein Ausblenden des Textes. Damit ist das Script abgeschlossen. Der gesamte Code sieht dann wie folgt aus:

```
public class PickUpScript : MonoBehaviour {
    public GameObject KeyBox;
    public GameObject Player;
    public GameObject AxeTextUI;
    public float Distance;    
    void Start() {
        AxeTextUI.SetActive(false);
    }
    void Update() {
        Distance = Vector3.Distance(KeyBox.transform.position,Player.transform.position);
        print(Distance);
        if(Distance <= 3) {
            if (GameObject.Find("Schlüssel") != null) {
                AxeTextUI.SetActive(true);
                if (Input.GetKey(KeyCode.E)) {
                    Destroy(gameObject);
                    AxeTextUI.SetActive(false);
                }                   
            }
        }
        else {
            AxeTextUI.SetActive(false);
        }
    }
}

```

Anschließend wird der Code abgespeichert. Dieser muss nun nur noch "wirkend" gemacht werden. Das Script wird also auf den Schlüssel gezogen. Dort sind dann drei Felder zu sehen, eins für Player, eins für KeyBox und eins für AxeTextUI. Auf das KeyBox-Feld wird der vorher erzeugte Cube gezogen, auf das Player-Feld der der Charakter und auf das AxeTextUI-Feld der erstellte Canvas. 

### Das Inventory-System

Als nächstes soll ein Inventory System implementiert werden, in dem Objekte gespeichert werden, die zuvor aufgesammelt wurden

### Das Health-System

Ein weiterer wichtiger Aspekt für das Gameplay ist ein Health-System.


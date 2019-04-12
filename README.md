<img src="https://user-images.githubusercontent.com/42578917/51550957-c19bea00-1e6d-11e9-9baf-56e92610e7fe.png">
<b>Beschreibung: Ein Abenteurer strandet auf einer einsamen Insel, die schon seit Jahren verlassen ist. Nun muss er viele Probleme lösen und Gegenstände sammeln um der Insel zu entkommen und sich selbst zu retten...</b>
<br>
<br>
In diesem Mini-Game strandet ein Junge alleine auf einer kleinen Inselgruppe, die schon seit Jahren verlassen ist. Nun muss er sich den Gefahren und Aufgaben dort stellen, um seinen Weg zurück nach Hause zu finden. Von Feinden umgeben und mit rudimentären Informationen muss der Spieler hier alle Teile finden und sammeln, um ein Boot zu bauen um zurück zur Zivilisation zu gelangen.

<h1>Vorwort</h1>

Diese Dokumentation stellt den Prozess dar, wie mithilfe der Unity Engine und einigen weiteren Programmen das Computerspiel WHYlands erstellt wurde. Wichtig ist dabei zu sagen, dass das Ausmaß der Modellierung, Programmierung und Konfigurierung in diesem Projekt eindeutig zu groß dafür ist, um es hier zu zeigen. Daher sind in dieser Dokumentation alle notwendigen Programmbefehle und Schritte erläutert, die notwendig sind, um dieses Spiel selber zu erstellen, aber nicht alle Schritte die insgesamt notwendig waren, um ein solches Spiel zu erstellen. Daher ist es zwar für jederman möglich, durch Lesen dieser Dokumentation, ein gleichrangiges Spiel zu kreieren, aber nicht möglich, dieses Spiel zu reproduzieren, indem man die Dokumenation 1 zu 1 mitschreibt.  

Wichtig ist zudem, dass in dieser Dokumentation nicht alle verwendeten Scripte gezeigt sind! Da nämlich viele Scripte, die geschrieben wurden und hier nicht dargestellt sind, nur Abwandlungen der Anderen mit teilweise nur winzigen Änderungen sind, war es nicht nötig diese hier darzustellen. Allerdings sind alle Scripte, die in diesem Spiel irgendeine Anwendung finden, in den Dateien dieses Repository zu finden. 

Desweiteren wurde ein Export des letzten Standes des Spieles in dieses Repository gepusht. Alle Dateien lassen sich mit Programmen wie TortoiseGit local klonen bzw. hier online öffnen und lesen.

<h1>Das Making-Off</a>

<h2>Inhaltsverzeichnis</h2>

* <a href="#idee">Die Idee</a>
* <a href="#programme">Die benötigten Programme</a>
* <a href="#spielmechanik">Die Spielmechanik</a>
    + <a href="#charakter">Der Charakter</a>
    + <a href="#animationcontroller">Der Animator-Controller</a>   
    + <a href="#capsulecollider">Der Capsule-Collider</a>
    + <a href="#charactercontroller">Der Character-Controller</a>
    + <a href="#pausemenu">Das Pause-Menü</a>
    + <a href="#mousecursor">Der Mouse-Cursor</a>
    + <a href="#hauptmenu">Das Hauptmenü</a>
* <a href="#gamedesign">Das Game-Design</a>
    + <a href="#border">Die Map-Border</a>
    + <a href="#texturen">Die Texturen</a>
    + <a href="#mapobjekte">Die Map-Objekte</a>
    + <a href="#standartassets">Die Standart Assets</a>
    + <a href="#himmelundlicht">Der Himmel und das Licht</a>
    + <a href="#musik">Die Musik</a>
* <a href="#gameplay">Das Gameplay</a>
    + <a href="#intro">Das Intro</a>
    + <a href="#objektesammeln">Objekte aufsammeln</a>
    + <a href="#haustuer">Die Haustür</a>
    + <a href="#missionen">Missionen</a>
    + <a href="#healthsystem">Das Health-System</a>
    + <a href="#spieltimer">Spiel-Timer und Vulkanausbruch</a>
    + <a href="#outtro">Das Outtro</a>
* <a href="#export">Der Export</a>
    + <a href="#splashscreen">Der Splashscreen und Icons</a>
    + <a href="#sceneeinbindung">Szeneneinbindung</a>
    + <a href="#spielexport">Das Spiel exportieren</a>
* <a href="#ergebnis">Das Ergebnis</a>
* <a href="#nachwort">Nachwort</a>
* <a href="#quellen">Quellen</a>
    


<h1 id="idee">Die Idee</h1>

Die Idee des Projektes bestand darin, ein 3D-Game zu erschaffen, das einer Art Escape-Game gleicht. Dabei sollten sowohl Spielmechanik, als auch Gameplay und Setting des Spiels dem eines anderen Indie-Games in nichts nachstehen. Der Anspruch war dabei, auf so wenig vorgefertigte Assets und Texturen wie möglich zurückzugreifen, um den vollständigen Umfang und Anspruch eines solchen Spiels zu visualiseren. 

<h1 id="programme">Die benötigten Programme</h1>

Entsprechend dem Anspruch werden für die Erstellung eine Reihe von Programmen benötigt. Diese sind hier in Anwendungsgebiete unterteilt:

* Unity
* Blender
* Adobe Photoshop
* Abobe Fuse (Mixamo)
* Fl Studio
* Visual-Studio (kommt mit Unity)
* Audacity

<b>Unity:</b> Unity ist die Grundlage dieses Spiels. Es ist eine GameEngine, die sowohl Grafiken, als auch Scripte verarbeitet und in einem Overlay mit Preview-Modus darstellt. Unity wird in diesem Fall sowohl zur Erstellung des Charakters mit Bewegung, Animationen etc. als auch zur Erstellung von Setting und Programmeinstellungen wie Menüs genutzt.

Unity definiert sich selber als GameEngine, ist allerdings mehr noch eine Art Schnittstelle zwischen den verschiedenen Disziplinen des GameDesign. So ermöglicht es in einem GUI (Grafic User Interface) sowohl grafische Designelemente wie Modelle und Texturen in eine dreidimensionale Umgebung einzufügen, als auch mittels Programmierung das Verhalten der einzelnen Objekte zu steuern.

Programmiertechnisch arbeitet Unity vor allem mittels Scripting. Es wird für jedes "Objekt", in diesem Fall also für jede während der Laufzeit zu verändernde Eigenschaft, eine eigene Klasse mit von anderen Klassen unabhängiger Ausführungsstruktur innerhalb eines Scriptes erstellt. Dies macht es möglich nicht nur serielle, sondern auch parallele Befehlsausführung zu gewährleisten, was es in diesem Fall ermöglicht, ein deutlich größeres Netz an parallelen Aktionen zu erstellen, die sich gegenseitig beeinflussen, voneinander abhängen oder sich behindern. Somit ist die Programmierung in Unity deutlich abstrakter als z.B. auf einem Arduino, da nicht jeder Command einzelnd abgehandelt wird, sondern eine parallele und eben verflochtene Ausführung von Befehlen genutzt werden kann. So werden erst richtige Spielabläufe möglich, da bei einem flüssigen Spielablauf nicht immer gewartet werden kann, bis eine Aktion beendet ist, bevor die Nächste angefangen wird. Daraus folgt dann, dass es  beispielsweise möglich ist gleichzeitig zu laufen und sich umzusehen oder zu springen und ins Menü zu wechseln. 

<a href="https://store.unity.com/download" target="_blank">Hier</a> lässt sich Unity herunterladen

<b>Blender:</b> Blender ist der zweite große Baustein dieses Projektes. Sämtliche Modelle, die nicht in Unity erstellt werden können, bzw. über die Modellierungs-Optionen von Unity (die ziemlich beschränkt sind) hinausgehen, werden in Blender erstellt und dann in Unity importiert</b>

Da Blender ein gratis Modellier-Tool ist, gibt es bei Blender auch eine riesige Community.

<a href="https://www.blender.org/download/">Hier</a> lässt sich Blender herunterladen

<b>Adobe Photoshop:</b> Adobe Photoshop haben wurde benutzt, um Texturen zu malen (z.B. für grünen Boden, Weg, Berge) und das Banner auf der Projektseite anzufertigen. Da Photoshop allgemein sehr gekannt ist, wurde dieses Bildbearbeitungprogramm für diese Aufgaben benutzt.

<a href="https://www.adobe.com/de/products/photoshop.html" target="_blank">Hier</a> lässt sich Adobe Photoshop kaufen

<b>Adobe Fuse:</b> Adobe Fuse ist ein neues Programm aus der Creative Cloud, welches sich aktuell in der Beta befindet. Es ist darauf spezialisiert auf einfachem Wege menschliche 3D Modelle zu kreieren. Adobe Fuse wurde dementsprechend für den vom Spieler gesteuerten Charakter verwendet.

<a href="https://www.adobe.com/de/products/fuse.html" target="_blank">Hier</a> lässt sich Adobe Fuse herunterladen

<b>FL Studio & Audacity:</b> Da jeder Aspekt eines Indie-Games selbst umgesetzt werden sollte, wurde auch geplant Musik einzubauen. FL Studio wurde genutzt um die gedownloadeten Soundtracks in Länge, Lautstärke usw. zu bearbeiten und Audacity um Rauschen aus den Soundtracks herauszufiltern.

<a href="https://support.image-line.com/jshop/shop.php" target="_blank">Hier</a> lässt sich FL Studio kaufen, 
<a href="https://www.audacity.de/download-de/" target="_blank">Hier</a> lässt sich Audacity herunterladen

<h1 id="spielmechanik">Die Spielmechanik</h1>

Zunächst müssen erstmal, um später ein solides Gameplay zu implementieren, die Grundlagen in Unity eingerichtet werden. Dazu gehören unter anderem das Charaktermodel, ein Controller um Bewegungen zu steuern, Animationen für den Charakter, sowie Menüs und weiteres. Daher wird in diesem Bereich zunächst einmal alles "außenrum" um das Spiel erstellt. Das bedeutet Charakter, Menüs, Animationen etc. womit das Spiel am Ende schon einmal in eine grobe Mechanik eingebettet wird. Der genaue Inhalt des Spiels und das Aussehen ist unter "Game-Design" und "Gameplay" zu finden.

<h2 id="charakter">Der Charakter</h2>

In diesem Fall wird, um das Modell später zu animieren, ein Character-Model benötigt, welches ein Exoskelett enthält. Zudem muss das Charakter-Model menschliche Proportionen aufweisen. Dies kann alles in Adobe Fuse (Beta) gestaltet werden. Nach dem Start erhält man dort die Möglichkeit, einen Charakter zu gestalten und sowohl den Körper, als auch das Gesicht sowie die Kleidung selber zu gestalten:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374742-923a5900-05f3-11e9-930f-a08619cca564.png" width="600px"></p>

Sobald der Charakter dann beendet ist, lässt sich oben rechts mit "Save to Maximo" in Maximo exportieren. In Maximo lassen sich dann Animationen auf einen Charakter anwenden bzw. eigene Animationen mithilfe des von Fuse angewandten Exoskelett erstellen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51466760-3e926b00-1d6b-11e9-921a-4b39743ccb33.png" width="600px"></p>

Sobald dann auch die Animationen angewandt sind, lässt sich das Modell sowie die Animationen als .fbx datei exportieren. Diese lässt sich dann per Drag&Drop in Unity importieren.

<h2 id="animationcontroller">Der Animator-Controller</h2>

Als nächstes müssen in Unity die zuvor erstellten Animationen auf das Charakter-Modell angewandt werden. Dafür gibt es in Unity ein einfaches Tool: den Animator-Controller!

In diesem werden sämtliche Animationen hinzugefügt und verwaltet. Man erreicht ihn mittels des Reiters oben neben Scene und Game bzw. über <b>Window > Animation > Animator</b>

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51618452-a7761080-1f2e-11e9-843d-71d63eb24277.png" width="300px"></p>

Als nächstes werden dann Charakter und Animationen unten in die Projektdatein gezogen. Sobald der Charakter dann in der Szene platziert ist, kann in den Dateien eine Animation ausgewählt und auf den Charakter gezogen werden. Damit erstellt Unity einen sogenannten <b>Animator</b>:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51619541-d8efdb80-1f30-11e9-8319-9dd0df862037.png" width="400px">
    
In diesen ist bereits der Controller (wird automatisch hinzugefügt und kann dabei belassen werden) und der Avatar (der in diesem Fall den Charakter mitsamt Animation darstellt. In Unity werden diese zusammen konvertiert, das Endergebnis zeigt aber nur einen Charakter, den aber mit mehreren Animationen, an). Zudem ist zu beobachten, dass im Animator-Controller mit dem Hinzufügen von neuen Animationen auch kleine neue Kästchen entstehen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55874822-c9794980-5b93-11e9-896f-20b43a0ffb0b.png" width="400px"></p>
Das ist die Besonderheit vom Animator in einer Engine wie Unity: die Verwaltung von Animationen erfolgt grafisch! 

Noch ist zu erkennen, dass es ein orangenes Kästchen und mehrere graue gibt. Das Orangene ist dabei der IDLE, also die Standart Animation, und die grauen sind die anderen Animationen. Per <b>Rechtsklick auf ein Kästchen > Set as Layer Default State </b> lässt sich auch ein anderes Kästchen als IDLE/Default bestimmen. In diesem Fall soll die Animation, in der der Charakter einfach dasteht und atmet als IDLE gesetzt werden.

Sobald dann sämtliche Animationen zum Animator-Controller hinzugefügt wurden, sind schon einige Pfeile zwischen den verschiedenen Kästen zu erkennen. Diese stellen "Übergänge" (Transitions) zwischen den Animationen da und lassen sich mit <b> Rechtsklick > Make Transition </b> hinzufügen. Anschließend kann mit einem Klick auf den Pfeil rechts im Inspektor die Bedingung (unter "Conditions") eingefügt werden. Eine solche Condition ist eine Bedingung, die erfüllt werden muss, damit dieser Übergang (Wechsel) zwischen den Animationen ausgeführt wird.

<p align="center"><img width="400" src="https://user-images.githubusercontent.com/42578917/51620344-713a9000-1f32-11e9-8c1e-4dc91c343fa0.png"></p>

Um dort eine Condition auswählen zu können, muss zuerst eine erstellt werden! Eine Condition wird von Unity als ein Script mit einer gleichnamigen Boolean Variable verstanden, welche in Abhängigkeit die Werte true oder false annimmt. Um also eine Condition zu erstellen, muss zunächst ein neues C#-Script erstellt werden. Dies wird "Moving" genannt und geöffnet. 

Da das Script selber von Unity als eine Boolean Variable verstanden wird, muss diese nicht mehr definiert werden. Allerdings muss zuvor noch definiert werden, dass dies ein Script ist, welches im Animator verwendet wird. Dafür muss zunächst ein neuer public Animator namens move definiert werden. Dies holt sich quasi den Animator ins Script und kann in diesem den Zustand von Conditions ändern. Damit dieser auch erreicht wird, muss er zudem in der void Start() initialisiert werden:

```
public class Moving:MonoBehaviour {
    public Animator move;    
    void Start() {
        move = GetComponent<Animator>();
    }
}

```
Das stellt quasi dar: "Ich brauche einen neuen Animator, das ist dieser und in ihm sollen später die Veränderungen Wirkung finden". Als nächstes soll natürlich auch irgendein Ereignis im Script stattfinden. Dafür wird in die void Update() folgendes geschrieben:

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
Es wird wie im Character Controller wieder der Zustand der Taste W abgefragt. Diesmal wird allerding etwas anderes dabei ausgelöst: Undzwar wird auf mittels move.SetBool() im Animator move (der vorher definiert wurde) auf eine Variable zugegriffen und sie "gesetted" (daher das "SetBool"). In den Klammern danach wird zunächst dargestellt, um welche Variable es geht (nämlich "Moving") und auf was sie gesetzt wird (false bzw. true). Der volle Command move.SetBool("Moving", false) nimmt sich (das verhältnis von conditions und variablen in diesem Script wurde zuvor bereits angeschnitten) die Condition "Moving" im move-Animator, und setzt sie als bool false. Andersherum wird das ganze mit true natürlich auch gemacht.

Nachdem das Script gespeichert wurde, kann die Condition im Animator gesetzt werden. Dafür muss zunächst ein neuer Parameter definiert werden: Dafür geht man links unter "Parameters" auf das + und wählt Bool aus (da ja am Ende auch eine Boolean Condition verwendet werden soll). Anschließend wird der Parameter genauso genannt wie das zuvor erstellte Script, in diesem Fall "Moving". Zuletzt kann noch mit klicken auf einen der Pfeile, mit dem Plus bei Condition eine Condition ausgewählt werden, und daneben gewählt, in welchem Zustand diese ausgeführt wird. In diesem Fall soll bei Moving = true der Pfeil von der Idle Animation zur Lauf-Animation getriggered werden. Also wird dies in der Condition definiert: 

<p align="center"><img width="600px" src="https://user-images.githubusercontent.com/42578917/51623012-0e4bf780-1f38-11e9-98ae-08a092c2a803.png"></p>

Das Ganze kann natürlich auch mit Moving = false in die andere Richtung gemacht werden, sodass, wenn der Charakter aufhört zu laufen, zurück in die Idle Animation gewechselt werden. 

Nun ist die Condition erstellt und der Animator Controller eingerichtet. Als Letztes muss noch ein kleiner Haken im Inspektor entfernt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51623180-6551cc80-1f38-11e9-920e-5c2bc512e829.png" width="400px"></p>

Der Haken sorgt dafür, das die Animation, sobald sie beendet ist, aufhört, und der Animator Controller wieder in die Idle Animation wechselt. Da dies nicht erwünscht ist (die Animation soll sich beim Laufen ja schließlich die ganze Zeit wiederholen), muss der Haken entfernt werden.

Sobald dies erledigt ist, ist die Animation für das Laufen eingerichtet und kann verwendet werden. Das Gleiche kann natürlich auch mit anderen Tasten und anderen Animationen ausgeführt werden. Dafür müssen lediglich neue Scripte mit anderem Namen und weitere Conditions erstellt werden. Zudem muss in den Scripten in der If-Schleife die Taste geändert werden, mit der die Animation gestartet werden soll. Nachdem all die Animationen hinzugefügt wurden, kann der Charakter sauber und schön alle Animationen ausführen.

<h2 id="capsulecollider">Der Capsule-Collider</h2>

Nun ist der Charakter erstellt und importiert. Allerdings fällt dieser noch durch das vorhandene Terrain durch. Damit das nicht passiert brauchen alle Objekte, die bei einer Berührung eine Bewegung ausführen sollen (wie z.B. dass der Charakter nicht durch den Boden fällt) einen von Unity bereitgestellten Collider. Dieser wird hinzugefügt, indem man den Charakter auswählt und dann auf Component > Physics > CapsuleCollider geht:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374528-cd3a8d80-05ef-11e9-9d0b-a028d61841c1.png" width="500px"></p>

Damit wird dann ein Collider auf den Charakter hinzugefügt und der Charakter fällt nicht mehr durch den Boden. Als Problem besteht dennoch weiterhin, dass der Charakter, wenn er auf einem Berghang steht, den Berg rückwärts herunterrollt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374574-64074a00-05f0-11e9-973e-3f3b572bebf8.png" width="500px"></p>

Dies geschieht, da der Collider ein Capsule-Collider, also teilweise rund, ist. Eine Lösung wäre, einen BoxCollider auf den Charakter zu setzen. Das würde allerdings nur dafür sorgen, dass der Charakter nicht wie eine Kugel, sondern wie ein Quader nach hinten kippt. Also ist das Problem damit nicht gelöst. Gelöst wird es, indem das Charakter-Model editiert wird. Dafür wird der Charakter ausgewählt und auf dem Rigidbody unter "Constraints" bei "Freeze Rotation" die Box für X, Y und Z ausgewählt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374612-01627e00-05f1-11e9-8dc4-9331b4d3df2b.png" width="500px"></p>

<h3 id="charactercontroller">Der Character-Controller</h3>
    
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

Damit man nun Laufen kann muss zunächst außerhalb der Hauptklasse Folgendes ergänzt werden:

```
[RequireComponent(typeof(Rigidbody))] 

public class PlayerController : MonoBehaviour {
    void Start() {       
    }
    void Update() {
    }
}
```
Dies definiert, dass im Controller von Elementen (wie dem Hauptcharakter) ein Komponent (wie es auch Collider, Scripte etc sind) der Component "Rigidbody" angesprochen werden darf. Der Rigidbody ist verantwortlich dafür, ein Element in Unity, in diesem Fall den Charakter, von A nach B zu bewegen. Die Zeile erlaubt es also,  den Rigidbody auf dem Element, auf dem auch dieses Script liegt, innerhalb des Scriptes zu verändern, sprich, innerhalb des Scriptes dürfen Veränderungen in der Position des Charakters vorgenommen werden.

Als nächstes müssen innerhalb der Funktionen folgende Zeilen ergänzt werden: 

Zunächst werden einige Variablen benötigt:

```
public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    private float mouseX = 0.0f;   
    public float speedX = 2.0f;   
    void Start() {       
    }
    void Update() {
    }
}
```
Da der Controller nicht nur Bewegung sondern auch Rotation des Charakters definieren soll, werden die meisten Variablen für die Rotation benötigt. Die erste float ist die Bewegungsgeschwindigkeit. Da man sie später innerhalb des Unity-Interface noch optimieren können soll, wird sie public definiert. Dann werden für die X Mausbewegung Stärke und Geschwindigkeit der Rotation in vier Variablen definiert. 

Da mouseX später sowieso überschrieben wird, wird sie zunächst auf 0 gesetzt. Der speedX ist für die Geschwindigkeit der Mausbewegung zuständig. Sie wird daher auf 2 gesetzt.

Als nächstes wird die Start() funktion gefüllt: 

```
void Start() {
   moveSpeed = 1.5f;        
}
```
Darin wird der moveSpeed auf 1.5f gesetzt. So schnell soll der Spieler sich am Ende bewegen können. In die Update() Funktion wird dann Folgendes geschrieben:

```
void Update() {
        mouseX += speedX * Input.GetAxis("Mouse X");       
}
```
Darin wird zunächst einmal definiert, wie sich die Maus in X Richtung bewegt. Die mouseX wird dann mit folgendem überschrieben: Da die Geschwindigkeit abhängig von der speedX Variable sein soll, also die Bewegung nur mit dem Geschwindigkeitsfaktor aus speedX ausgeführt werden soll, wird das ganze mit speedX multipliziert. Dahinter steht der Befehl Input.GetAxis("Mouse X"). Dieser fragt ganz einfach einen Input ab, undzwar den der Mouse X, also der X Bewegung (nach links und rechts) der Maus. Das Ergebnis wird dann mit speedX multipliziert und in mouseX gespeichert. 

Dies stellt allerdings nur die Stärke der Bewegung dar, aber nicht die Bewegung selber. Daher wird darunter Folgendes ergänzt:

```
transform.eulerAngles = new Vector3(0.0f, mouseX, 0.0f);
```

Ein transform ist in der Programmierung erst einmal eine Veränderung eines Objektes im zwei- bzw. dreidimensionalen Raum. Oftmals beschreibt dies eine Veränderung in Position, Rotation oder Größe. In diesem Fall soll es eine Rotation sein. Daher wird eine Rotation nach den drei Eulerwinkeln vorgenommen. Also eine transform.eulerAngles. Die Eulerschen Winkel sind ein oft verwendetes Modell bei der Drehung von Objekten in der Programmierung, da es sich hierbei um bestimmte Achsen im Raum handelt. Genaueres lässt sich <a href="https://de.wikipedia.org/wiki/Eulersche_Winkel">hier</a> nachlesen.

Nun muss diese Rotation auch irgendwie ausgeführt werden. Daher wird dieser transform.eulerAngles Folgendes zugewiesen: new Vector3(0.0f, mouseX, 0.0f);

Ein Vector3 ist eine Veränderung in Unity im dreidimensionalen Raum, die ja eine Rotation ist. Würde man ein 2D Spiel programmieren, müsste es Vector2 heißen. Diesem Vector3 werden auf den drei Achsen folgende Werte übergeben. Auf der X Achse (die im Spiel die dritte Achse eines zweidimensionalen Koordinatensystems ist, also beim zweidimensionalen Koordinatensystem "in das Papier hinein") wird 0 übergeben, da hier keine Drehung stattfinden soll (Die Variable heißt zwar mouseX, da sie die X Bewegung im zweidimensionalen Koordinatensystem darstellt, eigentlich ist es aber verantwortlich für die Y-Achse, da im dreidimensionalen Koordinatensystem die X-Achse quasi die Y-Achse ist). Für die Y-Achse wird der zuvor in mouseX gespeicherte Wert übergeben, da die Maus sich ja auf der Y-Achse bewegen soll, und für die z-achse wird wieder 0 übergeben.

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/56040141-0a10c880-5d36-11e9-9a72-71e82ccfd3d5.gif" width="500px"></p>

Das "new" davor bedeutet einfach, dass es sich um eine neue Bewegung handelt und keine kontinuierliche. Würde da kein new stehen, würde sich das Objekt mit jeder Ausführung des Scriptes (also jeden Frame) um den Faktor der Position der Maus drehen, anstatt dies nur dann zu tun, wenn man die Maus bewegt.

Damit ist eine von der Mausbewegung abhängige Rotation in der X (Y) Richtung implementiert. Als nächstes sollen einige Bewegungen innerhalb des Koordinatensystems definiert werden:

```
if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
{
    moveSpeed = 4f;
}

if (Input.GetKey(KeyCode.S))
{
    moveSpeed = 1f;
}
transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

moveSpeed = 1.5f;  
```

Zunächst wird einmal geprüft, ob die W-Taste UND die Shift-Taste gedrückt ist. Da der Charakter beim Drücken beider Tasten sprinten soll und sich damit schneller bewegen soll, wird dann die Variable moveSpeed, also die Variable in der die Laufgeschwindigkeit gespeichert ist, erhöht auf 4. Zudem wird geprüft, ob der Spieler S drückt, also rückwärts läuft. Wenn dies der Fall ist, soll er sich langsamer bewegen, da die Rückwärts-Laufen-Animation auch langsamer ist, also wird die Bewegungsgeschwindigkeit auch niedriger gesetzt als der Default. 

Als nächstes findet die eigentliche Bewegung statt. Da Unity bereits standartmäßig für die Bewegung WASD als Tasten definiert hat, werden hier keine if-schleifen oder Sonstiges benötigt. Nun wird also, wie zuvor bei der Rotation, wieder ein transform, also eine Veränderung im dreidimensionalen Raum gemacht. Statt eines eulerAngle, wird diesmal ein translate verwendet. Dies ist in der Programmierung auch eine SEHR oft verwendete Bezeichnung für die Veränderung der Position eines Objektes. Dieses Translate wird dann mit den Werten, die in der Klammer dahinter übergeben werden, ausgeführt. Wieder findet das Ganze über die einzelnen Achsen statt: Für die X-Achse, also nach vorne und hinten, wird in diesem Fall Folgendes übergeben: Die Bewegungsgeschwindigkeit mulipliziert mit der Input.GetAxis("Horizontal"). Unity verwendet das Input.GetAxis("Horizontal") als 3D-Modell der Tasteneingabe. Die Achse "Horizontal" wird dabei immer verändert, wenn W oder S gedrückt werden. Wenn also Input.GetAxis("Horizontal") abgefragt wird, wird die Veränderung in der W-S-Achse, also das Drücken der W und S Taste abgefragt. Im Klartext bedeutet das, dass die Bewegung auf der X Achse, also nach vorne und hinten, abhängig von der Veränderung der "Horizontal" Achse, also vom Drücken der W und der S Taste, verändert werden soll. Damit das Ganze auch z.B. beim Pause-Drücken des Spiels pausiert werden kann, wird es noch mit Time.deltaTime multipliziert (Was das ist, wird später auch nocheinmal erläutert). Damit ist die ganze Bewegung abhängig von der spielinternen Zeit und wird damit gestoppt oder eben wieder gestartet. 

Da sich der Charakter nicht auf der Y-Achse, also nach oben und unten, bewegen soll (zumindest nicht in diesem Fall, später allerdings mit einem Sprungscript schon), wird diese auf 0 gesetzt. Als Letztes wird das selbe mit der Z-Achse wie mit der X-Achse gemacht. Nur dieses mal mit der "Vertical"-Achse, also der Achse für links und rechts, also A- und D-Tasten.

Als Letztes muss noch das ergänzt werden:

```
moveSpeed = 1.5f;  
``` 

Dies setzt den moveSpeed wieder auf 1.5. Dies muss getan werden, da sonst, wenn der Spieler z.B. gesprintet ist, die moveSpeed auf 4 ist. Im nächsten Frame würde die Variable dann weiterhin auf 4 stehen, obwohl der Spieler vielleicht gar nicht mehr sprintet. Daher muss sie vor Ende des Frames noch einmal wieder auf 1.5 gesetzt werden, damit quasi wieder die selbe "Ausgangslage" geschaffen wird.

Das war soweit die Bewegung und Rotation auf der X-Achse. Das gesamte Script wird dann auf das Charaktermodell gezogen. Im Feld "Rigidbody" muss dann noch der Charakter selbst zugewiesen werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55975096-7e416280-5c89-11e9-932d-d104d340f8a0.png" width="400px"></p>

Nun muss der Charakter allerdings noch nach oben und unten schauen können. Dafür wird ein neues Script names VerticalCameraMovement.cs erstellt.

```
public class VerticalCameraMovement : MonoBehaviour
{
    public float speedY = 2.0f; 
    private float mouseY = 0.0f;
    void Update()
    {         
        mouseY = Mathf.Min(50, Mathf.Max(-50, mouseY -= speedY * Input.GetAxis("Mouse Y")));
        transform.eulerAngles = new Vector3(mouseY, 0.0f, 0.0f);     
    }
}
```
Die Funktionsweise ist sehr ähnlich der von der X-Achsen Bewegung, daher soll diesmal nur das erläutert werden, was sich geändert hat. Und zwar soll sich die Kamera nach oben und unten ebenfalls mit der Maus bewegen. Nur diesmal soll die Rotation nur bis zu einem bestimmten Winkel stattfinden. Darüber hinaus soll die Rotation geblockt werden, damit man die Kamera nicht "obenrum" im Kreis drehen kann. 

Um das zu erreichen wird Folgendes gemacht: mouseY wird wieder ein bestimmter Wert zugewiesen. Diesmal soll der Wert von mouseY allerdings nicht über 50 gehen. Also wird ein Mathf.Min() verwendet. Dieser Befehl macht nun dies: er nimmt die zwei Werte, die in der Klammer dahinter stehen, und vergleicht sie. Dann gibt der Befehl den kleineren der zwei Werte zurück. Wenn nun also das Ergebnis aus Mathf.Max(-50, mouseY -= speedY * Input.GetAxis("Mouse Y")) (wird gleich noch erläutert) größer als 50 ist, liefert Mathf.Min einfach 50 zurück. Dies dient also dazu, eine Zahl zu limitieren. Natürlich könnte man auch eine if-schleife verwenden, aber diese Funktion ist deutlich eleganter, da hierbei direkt, wenn der Wert über 50 steigt, 50 geliefert wird und nicht nochmal per if-schleife irgendwas geprüft werden muss. 

Der zweite Wert in der Klammer ist Mathf.Max(-50, mouseY -= speedY * Input.GetAxis("Mouse Y")). Dies ist quasi das Gleiche wie die Mathf.Min außer, dass es den größten statt den niedrigesten Wert zurückgibt. Das bedeutet wenn der Wert von mouseY -= speedY * Input.GetAxis("Mouse Y") größer als -50 wird, wird er zurückgegeben. Das Ergebnis von mouseY -= speedY * Input.GetAxis("Mouse Y") ist dabei die speedY multipliziert mit der Mauseingabe. Zur Vereinfachung der Erklärung ein paar Szenarien:

Man geht davon aus dass mouseY für den Anfang 0 ist:

1. Die Maus wird stark nach oben bewegt: Dann ist das Ergebnis von Mathf.Max(-50, mouseY -= speedY * Input.GetAxis("Mouse Y")) dass mouseY sehr klein ist. Kleiner als -50. Also wird -50 zurückgegeben. Dann wird in der Klammer von Mathf.Min(50 und -50) verglichen und entsprechend -50 zurückgeliefert. Daher ist die Ausgabe wenn man die Kamera start nach oben bewegt -50 und damit ist -50 der maximal mögliche Drehwinkel nach oben.

2. Die Maus wird leicht nach oben bewegt: Dann ist mouseY in der Mathf.Max Klammer größer als -50 und wird daher zurückgeliefert. Da es aber immernoch im Minusbereich liegt, wird es bei der Mathf.Min Klammer auch zurückgeliefert. Daher wird es also um den Faktor der Mausbewegung gedreht, der ja aber größer als -50 aber kleiner als 0 sein muss. 

3. Die Maus wird leicht nach unten bewegt: Dann ist mouseY positiv. Dadurch wird auch dieser positive Wert von Mathf.Max zurückgegeben. Verglichen werden in Mathf.Min dann ein die Werte 50 und X < 50. Es wird also X zurückgeliefert und die Kamera um den Wert X gedreht

4. Die Maus wird stark nach unten bewegt: mouseY wird über +50, wird daher in der Mathf.Max Klammer als Ergebnis geliefert. Da aber dann 50 und X > 50 in der Mathf.Min Klammer verglichen werden, wird 50 geliefert und die Kamera wird um +50 gedreht.

Die Ergebnisse der Szenarien sind also:

1. Stark nach oben: Kamera wird um -50 gedreht
2. Leicht nach oben: Kamera wird um  0 > X > -50 gedreht
3. Leicht nach unten: Kamera wird um 0 < X < 50 gedreht
4. Stark nach unten:  Kamera wird um +50 gedreht

Wie zu erkennen, ist, egal welche Eingabe der Maus vorgenommen wird, die Rotation der Kamera immer auf den Faktor X zwischen +50 und -50 begrenzt ist. So wird dann also auch die gesamte Kamerabewegung begrenzt.

Der Rest wird genauso gehändelt, wie die X-Bewegung der Kamera. Nur wird das Script diesmal nicht auf den Charakter, sondern auf die MainCamera gezogen. Dies wird gemacht, da nicht der Charakter, mit angehängter Kamera gedreht werden soll, sondern nur die Kamera. 

<h2 id="pausemenu">Das Pause-Menü</h2>

Als Nächstes soll ein Pause Menü zum Spiel hinzugefügt werden. Dafür kann in Unity ein Element namens Canvas genutzt werden. Dies lässt sich mittels <b>Rechtsklick in die Hierachie > UI > Canvas</b> zu den Elementen hinzufügen.

Das Canvas ist ein von Unity bereitgestelltes User Interface Element, welches einen Screen über den gesamten Bildschirm spannt.

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51204982-34084980-1905-11e9-9889-b57a4e006873.png" width="300px"></p>

Anschließend wird unter diesem mittels <b>Rechtsklick > UI > Panel</b> ein Panel erstellt. Dies füllt den Canvas farbig aus und stellt dadurch quasi die Oberfläche des Menüs dar. Rechts im Inspektor lässt sich nun einiges daran verstellen, in diesem Falle wurde nur die Hintergrundfarbe von weiß auf schwarz verändert.

Im Anschluss wird unter diesem Panel mit <b>Rechtsklick > UI > Button</b> ein Button erstellt.

<p align="center"><img width="300px" src="https://user-images.githubusercontent.com/42578917/51205414-24d5cb80-1906-11e9-9a3a-44e1af32befe.png"></p>

Die Buttons sind aktuell noch nicht besonders ansehnlich. Damit diese nun schöner sind, werden sie noch etwas verändert. Dafür muss zunächst einmal die Schrift verändert werden. Im Buttons-Element wird also das untergeordnete Text-Element ausgewählt und rechts im Inspektor Folgendes verändert:

Im Text(Script) wird zunächst einmal folgendes eingestellt: Das Font-Style wird auf Bold gestellt, die Font-Size wird auf 50 gestellt und die Color auf weiß:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55875660-e151cd00-5b95-11e9-973a-2b2df7a516c1.png" width="400px"></p>

Als nächstes soll auf den Text ein Schatten angewendet werden. Dafür wird das für Texte vorbereitete Shadow-Script von Unity verwendet. Beim Text wird also über <b>Add Component > Shadow</b> das Script hinzugefügt und folgendes eingestellt:

Die Effekt Distance wird für X und Y auf 4 bzw. -4 gestellt. Zudem wird für die Effekt Color die Farbe schwarz ausgewählt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55876152-36daa980-5b97-11e9-857b-c2c995d003c4.png" width="400px"></p>

Als letztes müssen noch am Button-Element einige Einstellungen vorgenommen werden:

Im Image(Script) wird die Color auf schwarz gestellt und im Button(Script) werden diese Farbeinstellungen vorgenommen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55876424-e6b01700-5b97-11e9-8d9d-ee844e0f3661.png" width="400px"></p>

Anschließend kann im Text Element noch im Text-Feld der Text eingegeben werden, der im Button angezeigt werden soll. Damit sehen die Buttons im Menü wie folgt aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55876608-4d353500-5b98-11e9-9b6b-61d0d303cc12.png" width="400px"></p>

Nun ist das Menü allerdings dauerhaft geöffnet und die Buttons haben keine Funktion. Um dies zu ändern, wird auf dem Canvas ein neues Script namens "EscapeMenu" erstellt. In diesem werden dann alle Bedingungen geschrieben, nach denen das Menü geöffnet wird und alle Aktionen definiert, die die erstellten Buttons ausführen sollen.

Wie alle C# Scripte in Unity hat auch dieses zu Beginn eine Start() und eine Update() Funktion. Die Start()-Funktion kann gelöscht werden, da sie in diesem Fall nicht benötigt wird.

Zu Beginn des Scripts werden wieder außerhalb der Funktion aber innerhalb der Klasse, alle Variablen und Objekte definiert, die benötigt werden. In diesem Fall sind das nur zwei:

```
public class EscapeMenu:MonoBehaviour {
    public static bool GamePaused = false;
    public GameObject pauseMenuUI
}
```
Die erste Variable ist vom Typ boolean (also Wahrheitsaussagen) und soll als Überprüfung dienen, ob sich das Spiel aktuell im Pause-Modus befindet oder nicht (da ja abhängig davon das Menü entweder geschlossen, oder eben geöffnet wird). Zudem wird sie zu Beginn auf false gesetzt, da das Spiel zu Anfang nicht im Pause Modus ist. Die zweite Initialisierung ist ein GameObject. Auch dies ist public, weil später nocheinmal aus dem Unity-Inspector drauf zugegriffen werden muss. Dieses GameObject heißt pauseMenuUI, stellt also das Canvas dar. Die Logik dahinter ist, dass diesem GameObject das vorher initialisierte Canvas, also das Menü, zugewiesen wird und dieses dann abhängig vom Tastendruck (in diesem Falle die Escape-Taste) angezeigt oder eben nicht angezeigt wird.

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

Als Nächstes müssen dann die Pause() und die Resume() Funktion geschrieben werden. Diese werden unter der Update Funktion geschrieben und enthalten Folgendes: 

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
Diese hat den Ausgangspunkt, dass das Menü geschlossen ist. Um es daher zu öffnen (da ja beim pausieren das Pausemenü geöffnet werden muss) wird das zu Beginn gesetzte GameObject pauseMenuUI mit dem Befehl pauseMenuUI.SetActive(true) auf aktiv gesetzt, wodurch es dem Spieler sichtbar wird. Als nächsten Schritt muss dafür gesorgt werden, dass das Spiel währenddessen nicht weiterläuft. Dies geschieht, indem die im Spiel vorhandene Zeit auf null gesetzt wird. Das geschieht mithilfe des Befehls Time.timeScale = 0f; - die Time.timeScale (also die "Spielzeit") wird auf null gesetzt, sie wird angehalten. Als letzten Schritt muss noch die Variable GamePaused auf true gesetzt werden, um beim nächsten Escape-drücken signalisiert wird, dass das Spiel sich aktuell im Pause-Modus befindet. 

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

Als Letztes soll natürlich auch alles im Spiel gestoppt werden, wenn das Spiel gestoppt wird. Also muss noch, wenn das Escape-Menü geöffnet ist, die Bewegung des Charakters und die Bewegung der Kamera blockiert werden. Daher wird in beiden Scripten noch Folgendes eingefügt:

Im PlayerController:

```
bool isPaused = EscapeMenu.GamePaused;
if (isPaused == false) 
{
    mouseX += speedX * Input.GetAxis("Mouse X");
    mouseY -= speedY * 0f;
}
```
Damit wird abgefragt, ob das Spiel im EscapeMenu Script pausiert ist. Durch die if-Schleife wird die Rotation des Charakters nur dann erlaubt, wenn das Spiel nicht pausiert wird.

Und im VerticalCameraMovement Script:

```
bool isPaused = EscapeMenu.GamePaused;     
if(isPaused == false)
{
    mouseX += speedX * Input.GetAxis("Mouse X");
    mouseY = Mathf.Min(50, Mathf.Max(-50,
    mouseY -= speedY * Input.GetAxis("Mouse Y")));
    transform.eulerAngles = new Vector3(mouseY, mouseX, 0.0f);
}
```
Auch hier wird abgefragt ob das Spiel pausiert ist und dann mittels einer if-schleife im Zweifel die Kamera-Bewegung blockiert.

<h2 id="mousecursor">Der Mouse Cursor</h2>

Nachdem nun ein Pause-Menü eingerichtet wurde, lässt sich dies auch normal bedienen. Allerdings fällt noch auf, dass die Maus sowohl im Menü, als auch inGame zu sehen ist. Dies soll natürlich nicht sein, die Maus soll inGame nicht zu sehen sein. Das Problem daran, sie einfach auszublenden, ist, dass sie im Menü ja weiterhin sichtbar sein soll. Also muss in einem Script, abhängig davon ob das Menü geöffnet ist, die Maus aus- oder eben eingeblendet werden. Dafür wird zunächst ein neues C#-Script erstellt und Folgendes hinzugefügt:

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

Zunächst wird erstmal eine Variable vom Typ Boolean mit dem Namen CursorIsLocked erzeugt. Mit dieser soll später der aktuelle Zustand überprüft werden, ob der Mauszeiger aktuell an oder aus ist. Als Nächstes wird in der void Start ein Grundzustand erzeugt, also wie die Maus zu Beginn des Spiels aussehen soll:
```
void Start() {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    CursorIsLocked = true;
}
```
Grundsätzlich soll der Cursor unsichtbar sein, und die Varibale CursorIsLocked soll true sagen. Der Befehl Cursor.lockState=CursorLockMode.Locked setzt den Cursor zunächst einmal auf locked, also unbeweglich auf dem Bildschirm. Dann wird mit Cursor.visible=false der Cursor unsichtbar gesetzt. Als Nächstes muss dem Programm natürlich noch gesagt dass der Cursor jetzt gerade gelockt/unsichtbar ist. Die Variable wird also auf true gesetzt.

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
Der Zustand der Maus (ob sie unsichtbar oder sichtbar ist) soll natürlich nur mit dem Öffnen des Menüs beeinflusst werden. Da das Menü mit der Escape Taste geöffnet wird, kann auch der Mauszeiger vom Drücken der Escape-Taste abhängig gemacht. Also wird mit der If-Schleife überprüft, ob die Escape-Taste gedrückt wird. Wie genau das funktioniert, lässt sich <a href="#pausemenu">hier</a> nachlesen. Gleichzeitig muss allerdings auch geguckt werden, ob der Mauszeiger aktuell "gelocked" ist. Zuvor wurde ja eine Variable namens CursorIsLocked erstellt, in der der aktuelle Zustand der Maus gespeichert ist, welche daher dafür ausgelesen werden kann. Also wird in die If-Schleife noch eine zweite Bedingung hinzugefügt, nämlich ob der Cursor NICHT gelocked ist (Nicht-true wird durch ein Ausrufezeichen (!) vor der Bedingung symbolisiert).

Wenn nun also Escape gedrückt wird UND der Cursor nicht gelocked ist, wird die If-Schleife ausgeführt. Die If-Schleife enthält nun alle zuvor in der Start() Funktion verwendeten Befehle, die den Cursor festsetzen, unsichtbar machen und die Variable auf true setzen. Die Schleife würde also ausgeführt werden, wenn man sich im Menü befindet (Die Maus also sichtbar und NICHT gelocked ist = CursorIsLocked auf false ist) und dann mit Escape zurück ins Spiel wechselt.

Andersrum muss natürlich auch der Fall abgedeckt werden, dass man aus dem Spiel ins Menü wechselt, der Cursor also von der Locked-Position in die nicht-LockedPosition wechselt. Dies wird mit einem else if, also einem an eine if-Schleife gebundenen else ausgeführt. In dieser wird überprüft, ob der Escape-Button gedrückt wird, sowie ob der Cursor aktuell gelockt ist. Ist dies der Fall wird die if-Schleife ausgeführt. In dieser wird eigentlich nur genau das Gegenteil von den Befehlen in der ersten if-Schleife ausgeführt. Statt CursorLockMode.Locked, wird CursorLockMode.None gesetzt, sodass der Cursor NICHT mehr gelockt ist. Genauso wird Cursor.visible auf true, also auf sichtbar gesetzt. Und die CursorIsLocked wird auf false gesetzt, da der Cursor ja von nun an nicht mehr locked ist.

Als Nächstes muss das Script auf die MainCamera gezogen werden. Wenn man nun das Game ausprobiert, sieht man, dass die Maus genau das macht, was erwünscht ist.

Nun kommt allerdings noch ein weiteres Problem auf. Wenn man im zuvor erstellten Menü auf Fortsetzen klickt, verschwindet die Maus nicht.

HIER FEHLT WAS!!!!

<h2 id="hauptmenu">Das Hauptmenü</h2>

Als nächstes soll nun ein Hauptmenü erstellt werden. In diesem soll man dann das Spiel Starten, Beenden und die Credits anschauen können. Dafür muss zunächst eine neue Szene in Unity erstellt werden. Dies geht oben links unter <b>File > New Scene</b>. In dieser kann nun das Menü erstellt werden. Wie beim Pausemenü wird zunächst ein Canvas erstellt, das dann MainMenu genannt wird. Als nächstes wird mit <b> Rechtsklick > UI > Panel</b> ein Hintergrund erstellt. Dann soll ein Hintergrund erstellt werden. Dafür wurde in diesem Fall einfach ein Screenshot erstellt, in Photoshop etwas bearbeitet und per Drag and Drop in die Unity Dateien gezogen. Anschließend wird dieses Bild ausgewählt und rechts im Inspektor unter "Texture Type" der Punkt "Sprite 2D and UI" ausgewählt. Damit wird das Bild zu einem Sprite gemacht. Anschließend kann man auf das zuvor erstellte Panel gehen und unter Background Image das zuvor erstellte Sprite auswählen. Danach müssen nur noch 3 Buttons erstellt und richtig beschriftet werden. Wie das geht, lässt sich unter dem Punkt <a href="pausemenu">Pausemenü</a> nachlesen.

Nun wird noch ein abschließendes Script benötigt, welches den Buttons ihre Funktion gibt. Dafür wird ein C#-Script namens "MainMenu" erstellt und folgendes reingeschrieben:

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Quit()
    {
        Debug.Log("Schließe Spiel...");
        Application.Quit();
    }
    public void Credits() {
        SceneManager.LoadScene("Credits");
    }
}
```

Wichtig dabei ist vor allem, oben das "using UnityEngine.SceneManagement" hinzuzufügen. Damit wird das SceneManagement von Unity aktiviert, es wird also möglich innerhalb eines Scriptes zwischen zwei Szenen zu wechseln. 

Dann werden noch drei Funktionen geschrieben. Eine namens Continue(), eine namens Quit() und eine namens Credits(). In der Continue()-Funktion wird festgelegt, was passiert, wenn der "Spiel-Starten"-Button gedrückt wird. In der Quit Funktion das gleiche für den "Spiel-beenden"-Button. Bei der Credits-Funktion soll leztlich die Credits-Szene geöffnet werden. Bei Continue wird ganz einfach "SceneManager.LoadScene("Intro");" geschrieben. Damit wird einfach die Szene geöffnet, welche den Namen hat, der in den Klammern dahinter festgelegt ist. In diesem Fall ist es die Szene namens "Intro", was genau diese macht, wird später noch einmal festgelegt. In Quit() wird nun das selbe geschrieben, wie im "Beenden"-Button im Pausemenü. Damit wird einfach das Spiel beendet. Bei Credits() wird ebenfalls eine andere Szene geladen, in diesem Fall die mit dem Namen "Credits". 

Als nächstes muss das ganze wirksam gemacht. Dafür wird das Hauptmenü-Script in der MainMenu-Szene auf ein neues Objekt gezogen. Es wird also unter Create > Empty Object ein neues leeres Objekt erstellt. Dies wird "SceneSwitcher" genannt. Nun wird darauf das MainMenu Script gezogen. Als nächstes wird auf dem Menü-Canvas der Continue() - Button ausgewählt. Unten bei der Condition wird bei "None" das GameSwitcher-Objekt ausgewählt. Dann wird rechts daneben im Dropdown-Menü das "Main-Menu"-Script ausgewählt. In dem dann ausklappenden Dropdown-Menü wird dann die jeweilige Funktion ausgewählt: Beim Spiel-Starten-Button die Continue()-Funktion und beim Spiel-Beenden-Button die Quit()-Funktion. Das gleiche gilt für den Credits-Button.

Damit wäre das Hauptmenü abgeschlossen. Um die Credits zu öffnen, wird nun lediglich eine neue Szene erstellt namens "Credits" und in dieser ebenfalls ein Menü erstellt. Bloß wird hier unter UI statt eines Panels, einfach ein Text, sowie ein zurück-Button implementiert. Der Text wird dann mit dem Credit-Text gefüllt und auf dem Zurück-Button wird ein Script platziert, in dem steht:


```
public class Credits : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
```

<h1 id="gamedesign">Das Game-Design</h1>

Natürlich ist für ein gutes Computerspiel nicht nur eine funktionierende GameEngine mit Animationen und einem Charakter notwendig, sondern es wird auch eine ansprechende Spielwelt benötigt. Dafür wird zunächst einmal ein Untergrund zum Laufen benötigt. Diesen stellt Unity unter <b>GameObject > 3d Object > Terrain</b> bereit. 

<p align="center"><img width="300px" src="https://user-images.githubusercontent.com/42578917/51617903-7812d400-1f2d-11e9-8c47-add51e198616.png"></p>

Nun kann man rechts auf <b>Paint Texture > Raise or Lower Terrain</b> mit einem Pinsel das Terrain quasi nach oben und unten "malen". Damit lassen sich verschiedene Landschaften erzeugen, auf denen das Spiel dann stattfindet. 

Im selben Menü lässt sich zudem der Punkt "Smooth Height" auswählen, womit sich scharfe Kanten im Terrain abrunden lassen. Außerdem lassen sich importierte Bäume und Gräser auf dem Terrain platzieren.

<h2 id="border">Die Map-Border</h2>

Aktuell kann der Charakter noch am Rande des zuvor erstellten Terrains runterfallen. Um das zu verhindern implementieren viele Spiele einen Respawn sobald man aus der Map rausläuft. In diesem Fall soll auf eine einfachere Lösung zurückgegriffen werden, auf die ebenfalls oft zurückgegriffen wird: Eine unsichtbare Wand. Damit verhindert man, dass der Charakter am Rand runterläuft. Dadurch, dass die Border unsichtbar ist wird zudem verhindert, dass sich der Spieler fühlt, als wenn er in einer großen Kiste herumläuft. Dafür werden in Unity zunächst einmal vier neue Cubes, also Würfel, erstellt. Das geht oben links unter <b> GameObject > 3D Object > Cube</b>. 

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55874085-a3eb4080-5b91-11e9-8adc-3edfe54323c4.png" width="600px"></p>

Nun werden die Würfel so lang und so hoch gezogen, wie es nötig ist, um vier Wände für die Map zu erstellen. Die Würfel müssen also in der Größe verändert werden. Das geht, wenn man den Würfel ausgewählt hat, oben links:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55874176-e9a80900-5b91-11e9-8d94-0f8b218a08dd.png" width="400px"></p>

Damit kann man dann die Größe der Würfel verändern. Als letztes müssel die Würfel noch unsichtbar gemacht werden. Dafür muss der sogenannte Mesh Renderer auf ihnen entfernt werden, der dafür sorgt, dass eine Textur auf dem Würfel gerendert wird. Dafür wählt man den Würfel aus, geht mit Rechtsklick rechts im Inspektor auf den Mesh Renderer und wählt "Remove Component" aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55874364-718e1300-5b92-11e9-8e5f-582874db5e1e.png" width="500px"></p>

Da der Collider weiterhin auf dem Würfel bleibt, hat man weiterhin den Collisionswiederstand auf ihnen. Nun hat man also unsichtbare Wände, durch die man NICHT hindurchlaufen kann. Als Letztes werden die Würfel noch als Wände angeordnet und schaffen so eine Border für den Charakter und die Spielwelt.

<h2 id="texturen">Die Texturen</h2>

Damit das Terrain auch einigermaßen aussieht, muss es auch mit Texturen ausgestattet werden. Dafür geht man unter <b>Terrain > Paint Terrain > Paint Texture </b> unten auf einen der Brushes und darüber unter <b>Edit Terrain Layers</b> weitere Texturen hinzufügen. Die Texturen werden in diesem Fall in Microsoft Photoshop erstellt.

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51914562-70de4100-23d9-11e9-8a49-0fe9f11eaaaf.png" width="600px"></p>

Dafür wird in Photoshop eine neue Datei erstellt, diese Fläche dann in der jeweiligen Farbe eingefärbt, und anschließend mit einem beliebigen Pinsel die Unregelmäßigkeiten hinzugefügt.

Sobald dann mehrere Texturen erstellt sind, können diese per Drag&Drop in die Unity Dateien hinzugefügt werden und unter <b> Edit Terrain Layers > Add Layer</b> zu den Terrain Layers hinzugefügt werden. Sobald dann ein Brush ausgewählt und unten die Brush Größe (Brush Size) sowie die Deckkraft (Opacity) eigestellt ist, kann auch der Karte wie auf einem Blatt Papier gemalt werden und die Karte so gefärbt werden, wie man will.

Zuden lassen sich auf dem Terrain unter <b> Paint Trees bzw. Paint Details</b> auch Map-Objekte wie Bäume oder Gras hinzufügen. Diese lassen sich entweder aus dem Unity Store als Standart Asset herunterladen oder als eigene Modelle hinzufügen, wie zum Beispiel so:
<br>
<p align="center"><img src="https://user-images.githubusercontent.com/42578917/51916309-560dcb80-23dd-11e9-9570-ca86b3bcdd7c.png" width="600px"></p>

<h2 id="mapobjekte">Die Map-Objekte</h2>

Nun kann man natürlich, wie schon bei den Texturen gesagt, nicht nur mit Unity-Internen Modellen und Texturen arbeiten, sondern kann auch unter anderem Objekte wie Bäume oder Steine extern modellieren und dann anschließend in Unity für den Map-Bau verwenden. In diesem Projekt wurden folgende Objekte in Blender modelliert:

* Berge
* Bäume/Baumstümpfe
* Steine
* Krabbe + Animation
* Haus + Innenraum
* Büsche
* Kakteen
* Treppen
* Gras

Daher dass die Objekt-Modellierung von Unity ziemlich begrenzt ist und sich vor allem auf simple geometrische Formen bezieht, muss für die Modellierung dieser Objekte ein spezielles Modellierungs-Programm, in diesem Fall Blender, zu Rate gezogen werden. 

In diesem Fall soll einmal beispielhaft gezeigt werden, wie man eine Palme in Blender modelliert. Die Vorgehensweise ist dann für andere Objekte die selbe, nur dass man Form und Farbe etwas anders gestaltet. Da allerdings die Modellierung jedes Objektes hier den Rahmen sprengen würde, und wie gesagt das ganze letztlich in Blender relativ gleich abläuft, wird in diesem Fall nur die Modellierung der Palme gezeigt:

Um Objekte zu modellieren startet man zunächst mit einem simplen geometrischen Körper wie z.B. einem Würfel, einem Zylinder oder einer Icosphäre. Mithilfe verschiedener Shortcuts, kann nun jeder möglicher Körper erschaffen werden.
Im Fall einer Palme wird mit einem Zylinder begonnen aus dem ein Palmenstamm entstehen soll. Um ein Objekt zu erstellen muss der Shortcut "Shift + A" gedrückt werden und danach der Zylinder ausgewählt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53328827-1d351980-38eb-11e9-8d07-3266a260eecc.png" width="400px"></p>

Wie viele Seiten der Zylinder hat, also wie rund dieser im Prinzip ist, kann über sogenannte "Subdivides" gesteuert werden. In diesem Spiel wird ein gröberer und reduzierter Stil verfolgt, der Stamm der Palme soll also nicht exakt rund sein, aber auch nicht nur 4 Seiten haben:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53328969-5ec5c480-38eb-11e9-9d33-d91af5bbffa2.png" width="400px"></p>

Um den Zylinder nun wie gewünscht zu bearbeiten muss das richtige Selektionswerkzeug ausgewählt sein. Im nächsten Schritt soll der Zylinder in die Länge gezogen werden um mehr den Maßstäben eines Palmenstamms zu entsprechen, daher muss die Flächenauswahl eingeschaltet werden. Nun ist es möglich die obere Fläche des Zylinders auszuwählen und diese nach oben zu ziehen. Damit ist der Zylinder in die Länge gezogen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329436-5de16280-38ec-11e9-8685-36825acd2408.png" width="800px"></p>

Damit der Stamm ein wenig natürlicher aussieht, soll er nicht überall den gleichen Durchmesser haben. Um diesen Effekt zu erreichen, kann die obere Fläche weiterhin ausgewählt bleiben. Mit dem Shortcut "s" wird das Skalierungswerkzeug aktiviert und durch verschieben der Maus kann der Durchmesser der oberen Fläche vergrößert und verkleinert werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329653-d516f680-38ec-11e9-9fee-889c19910acd.png" width="400px"></p>

Um die typische Stufen im Stamm zu Formen muss der Zylinder weiter unterteilt werden. Mit einem Shortcut "strg + r" kann dies durchgeführt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329822-4656a980-38ed-11e9-8fe9-627d33d8d2a3.png" width="400px"></p>

Nun muss von der Flächenauswahl in die Kantenauswahl umgestellt werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329890-7bfb9280-38ed-11e9-805d-1a4621728772.png" width="400px"></p>

Dann kann die gesamte Kante, welche eben hinzugefügt wurde, mit "Shift + Rechtsklick" ausgewählt werden. Mit dem Shortcut "s" kann nun diese Schnittfläche im Durchmesser vergrößert werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53329947-9fbed880-38ed-11e9-97f8-423a8520d9ab.png" width="400px"></p>

Das muss so lange wiederholt werden bis der gesamte Stamm diese Form hat:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53330043-d268d100-38ed-11e9-8998-648f37d2f6a7.png" width="400px"></p>

Was den Stamm ebenfalls dynamischer aussehen lässt ist eine leichte Krümmung. Um diese zu erzielen wird der Teil des Stammes ausgewählt, welcher verformt werden soll und die Taste "g" betätigt. Nun kann man mit dem Mausrad den Kreis vergrößern/verkleinern der an Stelle der Maus angezeigt wird. Wenn man nun die Maus bzw. den Kreis bewegt verformt sich der Stamm der Palme in Richtung der Maus im Bereich des Kreises:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53330106-f88e7100-38ed-11e9-923c-0e84120b896c.png" width="400px"></p>

Das letzte Detail am Stamm wird mit dem Shortcut "r" ermöglicht. Es wird wieder die obere Fläche am Stamm ausgewählt und eben erwähnte Taste gedrückt. Nun kann ähnlich wie bei der Skalierung die Maus bewegt werden um die obere Fläche zu drehen, der Rest des Zylinders passt sich dieser Rotation an. Um eine genauere Rotation in die gewünschte Richtung zu erzielen, kann nach drücken der "r" Taste ebenfalls "x","y" oder "z" gedrückt werden um die Rotation auf die jeweilige Achse zu begrenzen. Das kann auch für die anderen bereits bekannten Shortcuts angewendet werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53330181-2a073c80-38ee-11e9-9c1e-f8776e5f5d61.png" width="400px"></p>

Als letzter Schritt wird dem Stamm ein Material hinzugefügt um den Stamm einzufärben. Um ein Material zu erstellen gibt es rechts einen Knopf:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53724498-4c5b0600-3e6a-11e9-8e83-b9cce06d14db.png" width="400px"></p>

Als nächstes müssen die Palmenblätter modelliert werden. Dafür muss wie zu Anfang mit "Shift + A" ein neues Objekt erstellt werden. Macht man das während das alte Objekt noch ausgewählt ist, sind diese miteinander verknüpft und das neue Objekt ist ein Untergeordnetes Objekt zum Stamm:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53724754-e02cd200-3e6a-11e9-8157-c3f95e232ada.png" width="400px"></p>

Diese Fläche muss wieder unterteilt werden. Diesmal wird die Eckenauswahl benutzt. Nun werden die Ecken so verschoben, dass eine Blattform entsteht:

Mit den mittlerweile bekannten Shortcuts kann nun ein Palmenblatt geformt werden. Auch hier wird wieder ein neues Material erstellt um die grüne Farbe des Palmenblattes zu erzeugen. Das Palmenblatt kann nun mit "Shift + d" dupliziert werden. Die Palmenblätter werden so um den Stamm angefügt, dass eine natürliche Verteilung besteht.

Die fertige Palme kann nun mit "Datei > Exportieren > .fbx" als eine Modelldatei exportiert werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53724931-49144a00-3e6b-11e9-9343-d40b76d90bc1.png" width="400px"></p>

Das Filmbox-Format (.fbx) kann von Unity ausgelesen werden. Dafür zieht man sie in Unity per Drag and Drop in die Dateien:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/53724852-1a966f00-3e6b-11e9-9cc7-cddf614d398e.png" width="400px"></p>

<h2 id="standartassets">Die Standart Assets</h2>

In Unity gibt es natürlich nicht nur die Möglichkeit, eigene Modelle importieren, sondern es lassen sich auch Modelle von anderen kaufen bzw. einbinden. Dies geht über den Unity Asset Store. Diesen ruft man auf über <b> Window > Asset Store</b>. Hier kann man nun oben in der Suchleiste dann alle möglichen Assets und Modelle suchen, die von anderen erstellt wurden. 

<p align="center"><img width="400px" src="https://user-images.githubusercontent.com/42578917/55880497-1c0d3280-5ba1-11e9-997d-6101e39a1aea.png"></p>

Die Standart Assets lassen sich hier finden: <a href="https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-32351">Link</a>

In diesem Projekt wurde auf mehrere Dateien aus den Standart Assets zurückgegriffen. Die Modelle finden sich nach dem Importieren der Standart Assets unter <b>Assets > Samples > Standart Assets</b>

Wie bereits erwähnt wurden in diesem Projekt mehrere Standart Assets verwendet: Zum einen das Wasser Asset. Dieses muss einfach per Drag and Drop in die Szene gezogen und dann die Größe angepasst werden. Nach dem Auswählen lassen sich zudem rechts im Inspektor die Texturen der einzelnen Schichten des Wassers anpassen. In diesem Fall wurde eine andere Textur verwendet um das Wasser dem Stil des Projektes anzugleichen. Dies wurde auch noch einmal vorgenommen, um aus dem Wasser Lava für den Vulkan zu machen.

Desweiteren wurde, wie später zu sehen, eine Explosion sowie Rauch für den Vulkan und Feuer für eine Kerze verwendet. Die Explosion findet sich unter <b>Assets > Standart Assets > ParticleSystems > Prefabs > Explosion</b> ,der Rauch unter <b>Assets > Standart Assets > ParticleSystems > Prefabs > Smoke</b> und das Feuer unter <b>Assets > Standart Assets > ParticleSystems > Prefabs > Fire</b>.
Die Einstellungen der Partikel, wie die Skalierung, Geschwindigkeit und Menge der Partikel, werden angepasst bis das gewünschte Ergebnis erreicht wird. So kann aus kleinen Rauchpartikel der Rauch für einen Vulkan entstehen und aus Feuerpartikeln eine brennende Kerze.

Als letztes wurde noch ein Dust Storm verwendet. Diesen findet man unter <b>Assets > Standart Assets > ParticleSystems > DustStorm</b> und er kann einfach per Drag and Drop in die Szene gezogen werden. Im Scene-Screen taucht dann ein Feld auf, mit dem man Dichte und Anzahl der Partikel variieren kann.
    
Zwar wurden diese in diesem Projekt nicht verwendet, aber die Standart Assets bieten auch noch einen Third Person und einen First Person Controller, Fahrzeuge, mehrere Effekte wie Feuerwerk sowie Flugzeuge usw. 

<h2 id="himmelundlicht">Der Himmel und das Licht</h2>

Als nächstes soll ein wenig Atmosphäre in das Spiel gebracht werden. Um das zu erreichen, lässt sich in Unity die Farbe des Lichtes und die Textur des Himmels anpassen. 

Um die Farbe des Lichts zu verändern, wählt man in den Elementen das "Directional Light" aus, welches standartmäßig in jeder Szene vorhanden ist. Links im Inspektor lässt sich dann im Reiter "Light" unter "Color" die Farbe auswählen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55971757-6a463280-5c82-11e9-9eef-6d3f951c5b34.png" width="400px"></p>

Zudem kann in Unity die Textur und das Verhalten des Himmels verändert werden. Dafür wurde erneut auf ein gedownloadetes Asset zurückgegriffen. Der Himmel kann durch Drag n' Drop in den Himmel der Szene hinzugefügt werden. Die dazugehörige Animation ist automatisch aktiviert.

<h2 id="musik">Die Musik</h2>

Nun soll ein wenig Musik in das Spiel hinein. Dafür wird natürlich zunächst einmal Musik benötigt. In diesem Fall wurde online Musik verwendet, die bei Verlinkung der Quelle zur öffentlichen Nutzung steht. 

Dies ist die Quelle für die Verwendete Musik: <a href="https://www.zapsplat.com/">https://www.zapsplat.com/</a>

Die Besonderheit bei der Einbindung in diesem Fall ist, dass das Hören der Musik nur in einem begrenzten Radius verfügbar sein soll. Vereinfacht also: Wenn sich der Spieler in einem bestimmten Umkreis um die Quelle befindet, soll die Musik abgespielt werden.

Um dies zu erreichen, wird zunächst einmal ein neues leeres Element erstellt. Dies geschieht unter <b>GameObject > Create Empty</b>. Dieses Empty GameObject wird nun ins Zentrum einer der Inseln positioniert. Als nächstes wird ein neues Script erstellt namens InselZentrum1.cs. In diesem werden erst einmal folgende Variablen definiert:

```
    public GameObject Player;
    public AudioClip Insel1;
    static AudioSource audioSrc1;
    public string AudioName1;
    public float MinDis1;
    public float MaxDis1;
    public float Distance1;
```

Zunächst einmal der Spieler, denn von diesem wird der Abstand zur MusikQuelle abhängig gemacht. Dann wird ein neuer AudioClip definiert. Also ein Element vom Typ AudioClip. Dieses wird public gesetzt, um es später in Unity zuweisen zu können. Dann wird eine AudioSource, also ein Objekt, welches auf dem Empty-Element in Unity liegt, definiert. Dieses AudioObjekt wird dem Element zugewiesen und in ihm können Musik und die Quelle verwaltet werden. Es wird hiermit, vom Element auf dem auch dieses Script liegt, selektiert. Zudem wird ein public string gesetzt, wo später der Name des Musiktitels eingetragen wird. Da nämlich ein später verwendetes Element einen string braucht, um den Titel zu finden, und nicht einfach einen AudioClip, wie er vorher definiert wurde, ist dies noch einmal notwendig zu definieren. Dann werden noch drei float Variablen definiert: Eine für den Minimalen und Maximalen Abstand, die nötig sind, um das Audio abzuspielen und eine Distance Variable, in der der Abstand zwischen Spieler und Musik-Objekt, welche später dauerhaft geprüft wird, gespeichert wird.

Nun wird folgendes in der Start() Funktion definiert:

```
void Start()
    {
        Insel1 = Resources.Load<AudioClip>(AudioName1);
        audioSrc1 = GetComponent<AudioSource>();
    }
```

Damit wird dem AudioClip Insel1 ein Titel zugeordnet, der aus dem Ordner Resources und mit dem Namen AudioName1, welcher später noch zugeordnet wird, geladen wird. Zudem wird noch der Variable audioSrc1 die AudioSource-Komponente, die auf dem selben Objekt liegt, zugeordnet.

Als nächstes wird folgendes in die Update() Funktion geschrieben:

```
void Update()
    {
        Distance1 = Vector3.Distance(InselZentrum1.transform.position, Player.transform.position);
        if (Distance1 > MinDis1 && Distance1 < MaxDis1)
        {
            playSound();
        }
        if (Distance1 > MaxDis1)
        {
            stopSound();
        }
    }
```

Darin wird der Variable Distance1 das Ergebnis der Abfrage: Vector3.Distance(InselZentrum1.transform.position, Player.transform.position) zugeordnet. Diese Abfrage bedeutet Folgendes: 

Es wird das Unity-interne Vector3.Distance() verwendet. Dieses prüft in einem dreidimensionalen Raum (Vector3) den Abstand von zwei Objekten, die in den nachfolgenden Klammern übergeben werden. In diesem Fall sind das die beiden GameObjekts Insel1Zentrum und Player. An diese wird noch das .transform.position angehängt, was deklariert, dass hierbei die Position beider Objekte genommen und an die Vector3.Distance übergeben werden. Im Klartext bedeutet dies also: führe eine Abstands-Abfrage (Distance) im dreidimensionalen Raum (Vector3) aus, in der du die zwei Eigenschaften (transform.position) der nachfolgenden Elemente (Insel1Zentrum und Player) vergleichst und das Ergebnis dieser Abfrage in der Variable Distance1 speicherst.

Als nächstes wird in einer if-Schleife (was die Bedingung bedeutet wurde bereits mehrfach erläutert) Folgendes ausgeführt:
```
playSound()
```
Dies ist der Abruf einer Funktion namens playSound. Diese Funktion wird später noch definiert. Das selbe gilt für die zweite if-Schleife, in der die Funktion stopSound() ausgeführt wird.

Da die Funktionen abgerufen werden sollen, müssen sie nun auch definiert werden. Also wird unter der Update()-Funktion folendes ergänzt:

```
public static void playSound()
    {
        audioSrc1.Play(0);
    }
     public static void stopSound()
    {
        audioSrc1.Stop();
    } 
```
Dies sind im Grund genommen zwei simple Kommandos: In der Funktion playSound() wird ausgeführt: audioSrc1.Play(0). Dies spielt einfach nur den AudioClip ab, der in der Variable audioSrc1 gespeichert wurde. Die null hinter dem Play bedeutet, dass die Datei von Anfang an abgespielt werden soll.

Das zweite Kommando in der void StopSound() führt einen ähnlichen Befehl aus: audioSrc1.Stop(). Wie vielleicht schon zu erahnen ist, stoppt dies einfach nur das Audio.

Das wäre auch schon das komplette Script. Zusammen sieht es wie folgt aus:

```
public GameObject InselZentrum1;
    public GameObject Player;
    public static AudioClip Insel1;
    static AudioSource audioSrc1;
    public string AudioName1;
    public float MinDis1;
    public float MaxDis1;
    public float Distance1;
    void Start()
    {
        Insel1 = Resources.Load<AudioClip>(AudioName1);
        audioSrc1 = GetComponent<AudioSource>();
    }
    void Update()
    {
        Distance1 = Vector3.Distance(InselZentrum1.transform.position, Player.transform.position);
        if (Distance1 > MinDis1 && Distance1 < MaxDis1)
        {
            playSound();
        }
        if (Distance1 > MaxDis1)
        {
            stopSound();
        }
    }
    public static void playSound()
    {
        audioSrc1.Play(0);
    }
     public static void stopSound()
    {
        audioSrc1.Stop();
    } 
```
Damit nun was passiert, muss das ganze implementiert werden. Das Script wird auf das vorher erstellte Objekt gezogen. Als nächstes wird unter Add Components eine AudioSource hinzugefügt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55887426-c8551600-5bad-11e9-8c89-501fbe11ca4d.png" width="400px"></p>

Wie zu erkennen wurde die MinDistance auf 124 und die MaxDistance auf 125 gesetzt. Zudem wurde dem Player Objekt der Hauptcharakter zugeordnet, das EmptyObject dem Insel1Zentrum zugeordnet und der Name des AudioTracks ("Insel1") eingegeben. Wie schon erwähnt, wird der AudioClip aus einem Ordner namens Resources geladen. Dieser wird also nun im selben Ordner angelegt, in dem das Script liegt. Darein wird dann der AudioClip abgelegt.

<h1 id="gameplay">Das Gameplay</h1>

Nachdem nun eine ansprechende Spielwelt erstellt wurde, muss der zuvor implementierte Charakter auch mit dieser interagieren können. Oft erfolgt dies in Form von Quests/Aufgaben, für die der Spieler etwas finden, sammeln oder auf sonstige Weise mit der Welt interagieren muss. In diesem Fall beschränken sich die Aktionen vor allem auf das Finden und Sammeln von Objekten. 

<h2 id="intro">Intro</h2>

Nun soll für das Spiel ein Intro, also eine Einleitung erstellt werden. Bei diesem Projekt soll der Charakter an den Strand angespült werden, eine Krabbe soll zu ihm laufen und ihm die Informationen die der Spieler braucht mitteilen. Dafür muss zunächst einmal eine neue Szene erstellt werden. Diesmal wird allerdings, um die erstellte Umgebung beizubehalten, die normale Szene in den Dateien einfach kopiert und in "Intro" umbenannt. Als nächstes kann erstmal alles, was nicht benötigt wird, gelöscht werden. Zudem wird die Kamera umpositioniert, und zwar so, dass sie den Strand seitlich von oben zeigt.

Als Nächstes wurde eine Krabbe in Blender modelliert und mit einer Animation ausgestattet. Diese wird dann in Unity importiert und mit einem Animator ausgestattet. Zudem wird ein neuer AnimatorController namens "crap" erstellt und zusammen mit der Animation auf dem Animator der Krabbe platziert. Das alles wurde bereits einmal beim Hauptcharakter gemacht und lässt sich <a href="#charakter">hier</a> nachlesen. Im Animator Controller wird mit <b> Rechtsklick > Create Empty</b> eine neue leere Animation erstellt. Diese wird dann mit <b>Rechtsklick > Set Layer as Default State</b> zum Default gemacht, der sofort gestartet wird, wenn das Spiel gestartet wird.

Als Nächstes wird mit <b>Rechtsklick > Make Transition</b> eine neue Transition von der Empty State zur Krabben-Bewegungsanimation gemacht. Wie dies geht lässt sich auch unter dem Punkt "Der Charakter" nachlesen. Dafür wird dann links ein neuer Parameter erstellt namens crapMove vom Typ Bool. Die Transition vom Empty State zur Bewegung wird mit der Condition crapMove = true ausgestattet und die andere mit der Condition crapMove = false. 

Das ganze sieht dann so aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55882402-c5095c80-5ba4-11e9-886a-fb8b7dcdcbbc.png" width="400px"></p>

Nun muss ein Script geschrieben werden, welches diesen Parameter bearbeitet. Dafür wird ein neues C#-Script mit dem Namen crapMove.cs erstellt. In dieses wird dann folgender Code geschrieben:

```
public class crapMove : MonoBehaviour
{
    public Animator crap;
    public float timer;
    void Start()
    {
        crap = GetComponent<Animator>();
        crap.SetBool("crapMove", true);
        timer = 0.0f;
    }    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 40)
        {
            crap.SetBool("crapMove", false);
        }
    }
}
```
Die Funktionsweise der einzelnen Kommandos wurde bereits zuvor in dieser Dokumentation erläutert, daher in Kurzform: Der crap-Animator wird ausgewählt und angesprochen. In diesem wird unter bestimmten Bedingungen die crapMove-Condition auf true oder false gesetzt. Nun noch einmal zum timer. In diesem Script wird das Schalten der Variable von einem Timer abhängig gemacht. Die timer Variable wird zunächst in der Start() Funktion auf null gesetzt. Anschließend wird sie während der Update() Funktion mit dem += Operator mit Time.deltaTime hochgezählt. Der Operator macht in C# quasi eine Zuordnung, in der er den alten Wert nimmt und einen neuen draufaddiert. Er ist im Grunde genommen eine Kurzform hiervon:
```
timer = timer + Time.deltaTime;

timer += Time.deltaTime
```
Beide Zeilen machen im Script theoretisch das Gleiche. 

Time.deltaTime ist die Unity-Interne Zeitangabe. Time.deltaTime ist quasi eine Stoppuhr, die in Unity ab dem Start des Spiels anfängt  zu laufen. Sie kann aber auch mittels Script manipuliert oder angehalten werden. In diesem Fall wird damit einfach ein Timer initialisiert. Der Vorteil davon, diesen zu verwenden ist, dass im PauseScript ja Time.deltaTime auf null gesetzt wird. Da der Timer in diesem Fall von Time.deltaTime abhängig ist, wird auch dieser Timer gestoppt, wenn das PauseMenü geöffnet wird. In diesem Projekt wurden alle Timer mit Time.deltaTime gesteuert. Daher stoppen die Timer alle, wenn auch das Spiel mittels Esc.-Taste gestoppt wird.

Nun soll sich die Krabbe aber auch fortbewegen. Dies aber nicht einfach so oder auch dauerhaft, sondern sie soll einen bestimmten Weg eine bestimmte Zeit lang entlanglaufen. Um das zu erreichen, wurde in diesem Fall auf ein bereits bestehendes Script zurückgegriffen. 

Der Youtuber kinan gh hat in einem Tutorial auf Youtube ein Script verfasst, welches genutzt werden kann, um ein GameObjekt in Unity bestimmte zuvor manuell gesetzte Waypoints ablaufen zu lassen und dann stehenzubleiben. Die Quelle für dieses Video ist unten in dieser Dokumentation unter <a href="#quellen">Quellen</a> bzw. dieser <a href="https://www.youtube.com/channel/UCGOgRqMyWE6VPSCG-qxVkmw">Link</a>

Quelle: https://www.youtube.com/channel/UCGOgRqMyWE6VPSCG-qxVkmw (kinan gh) 

In diesem Video ist das verwendete Script inklusive einer Erläuterung zu sehen. Die Konfiguration für die Krabbe wurde wie folgt vorgenommen: Es wurden zunächst einmal vier neue Empty Objects in Unity erstellt. Diese stellen die Waypoints dar, die die Krabbe entlangläuft. Diese wurden dann an die richtigen Stellen (also die Stellen die die Krabbe entlang laufen soll) platziert und korrekt benannt. Anschließend wurde das Script von kinan gh auf die Krabbe gezogen. Nun ist folgendes am Script zu erkennen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55965825-9f995300-5c77-11e9-937b-0752034514ee.png" width="400px"></p>

Mittels einer Eingabe unter "Size" lässt sich die Menge an Objekten einstellen, die das Objekt (die Krabbe) entlang laufen soll. Hier wird, da zuvor vier Objekte als Waypoints erstellt wurden, eine vier eingetragen. Dadurch erstellen sich automatisch vier Felder, in die man die GameObjects, die als Waypoints dienen sollen, zuweisen kann. Diese werden also nun zugewiesen. Darunter lässt sich zudem die Geschwindigkeit einstellen, mit der sich das Objekt fortbewegen soll. In diesem Fall wurde sie auf 1.2 gestellt. Richtig konfiguriert sieht das Script auf der Krabbe dann wie folgt aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55965917-c6f02000-5c77-11e9-8dba-aee0292899df.png" width="400px"></p>

Damit wäre die Bewegung der Krabbe abgeschlossen. Um nun das Intro so hinzubekommen, wie es im Spiel vorhanden ist, wird das gleiche noch einmal auf den Hauptcharakter (diesmal in der Position, dass er quasi "angespült" wird) und einmal auf die Kamera angewandt. So hat man dann eine Kamerafahrt hin zum Charakter. 

Als nächstes soll die Krabbe etwas zum Spieler sagen. Der Text wird dabei verfasst und in drei Text-Elemente aufgeteilt, die hintereinander angezeigt werden sollen. Zudem soll ein viertes Textelement eine "Überschrift" darstellen. Also werden nun vier Textelemente erstellt und richtig positioniert.  Als nächstes wird dann ein Script namens crapTalk erstellt. Hier wird folgendes hineingeschrieben:

```
public class crapTalk : MonoBehaviour
{
    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public GameObject title;
    public float timer;
    void Start()  {
        Talk1.SetActive(false);
        Talk2.SetActive(false);
        Talk3.SetActive(false);
        title.SetActive(false);
        timer = 0.0f;
    }    
    void Update()  {
        timer += Time.deltaTime;
        if(timer > 40)
        {
            title.SetActive(true);
            Talk1.SetActive(true);
            if(timer > 50)
            {
                Talk1.SetActive(false);
                Talk2.SetActive(true);
                if(timer > 60)
                {
                    Talk2.SetActive(false);
                    Talk3.SetActive(true);
                    if(timer == 70)
                    {
                        Talk3.SetActive(false);
                        title.SetActive(false);
                    }
                }                
            }
        }
    }
}

```

Die Funktionsweise ist relativ simpel. Was die einzelnen Befehle bedeuten bzw. was sie machen wird im Kapitel <a href="#objektesammeln">Objekte aufsammeln</a> ausführlich erläutert. In diesem Fall wird von Beginn an ein Timer hochgezählt (Timer wurde bereits zuvor erläutert) und abhängig von dem Timer werden die einzelnen Texte ein und ausgeblendet. Zuletzt muss das erstellte Script noch auf die Krabbe gezogen und alle Texte und Objekte zugeordnet werden.

Wenn die Krabbe fertig mit dem Reden ist, soll die Szene auf die Hauptszene geändert werden. Dafür wird ein neues Script namens IntroTimer.cs erstellt und folgender Code eingefügt:

```
public class IntroTimer : MonoBehaviour
{
    public float timer;
    void Start()
    {
        timer = 0.0f;
    }    
    void Update()
    {
        timer += Time.deltaTime;
        print(timer);
        if(timer > 70)
        {
            SceneManager.LoadScene("MainScene");
        }

    }
}
```
Auch hier wird ein Timer hochgezählt und bei einem bestimmten Wert die Hauptszene geladen. Damit das Script funktioniert, wird ein neues Empty GameObject erstellt und das Script draufgezogen. Das reicht aus um es wirksam zu machen.

Als allerletztes soll, nach dem Wechsel von Intro zur Hauptszene zunächst ein Blackscreen erscheinen, der langsam ausgeblendet wird, also ein Fade-Out hat. Dafür wird auf die Hauptszene gewechselt und dort ein neues Canvas erstellt. Dann wird ein Panel erstellt und dem Canvas untergeordnet. Die Farbe des Panels wird auf komplett schwarz geändert. Zudem wird der AlphaKanal komplett hochgestellt, damit der Bildschirm komplett schwarz ist. Als nächstes wird ein neues Script namens mainSceneBlack.cs erstellt:

```
using UnityEngine.UI;

public class mainSceneBlack : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float timer;
    void Start()
    {        
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 13)
        {            
            if (canvasGroup.alpha > 0)
            {
                canvasGroup.alpha -= Time.deltaTime / 10;
            }            
        }
    }
}
```
Zunächst wird definiert, dass von diesem Script aus die UnityEngine UI, also UI Objekte (wie das zuvor erstellte Panel) bearbeitet werden kann. Als Nächstes wird eine Variable erstellt. Dies ist eine CanvasGroup. Das ist eine Variable, die später eine CanvasGroup, welche auf dem Objekt liegt, speichert. Dann wird eine Timer Variable erstellt. In der Start()-Funktion wird der CanvasGroup Variable der Component CanvasGroup zugeordnet. CanvasGroup ist ein Komponent von GameObjects, wie es auch Collider und Mesh Renderer sind. Mit diesem Befehl wird die CanvasGroup-Komponente auf dem GameObject ausgewählt, auf dem auch dieses Script liegt, also von dem Panel. Als Nächstes wird der Alphakanal von der CanvasGroup auf 1, also auf den höchsten Wert gesetzt. Damit ist der Screen mit einem schwarzen Bild bedeckt. 

Dann wird die Update Funtktion gefüllt. Hier wird ein Timer initialisiert. Es wird in einer if-schleife geprüft, ob der Timer über 13 Sekunden ist, weil der BlackScreen so lange eingeblendet bleiben soll. In dieser if-Schleife wird eine weitere if-Schleife geprüft, ob der AlphaKanal des Panel noch über 0 ist, also quasi noch ein bisschen "schwarz" auf dem Bildschirm zu sehen ist. Wenn das der Fall ist, wird der Alphakanal um Time.deltaTime/10 also pro sekunde um 0.1 (1/10 = 0.1) verringert. Somit wird der Alphakanal Stück für Stück auf null verringert. Damit ist der Fade-Out-Effekt erstellt. 

Nun muss noch die CanvasGroup zugeordnet werden, welche im Script angesprochen wird. Diese ist zu finden unter <b> Add Component > CanvasGroup</b>. 

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55969129-901d0880-5c7d-11e9-849c-a10a07220959.png" width="400px"></p>

Daran muss nichts mehr konfiguriert werden. CanvasGroup ist simpel gesagt eine Komponente, die zur Verwaltung bestimmter Eigenschaften eines Canvas (wie z.b. dem Alphakanal) vorgesehen ist. Sie lässt sich durch ein Script sehr simpel ansprechen und manipulieren, wodurch Effekte wie der eben erstellte Fade-Out entstehen können.

Mit dem Script, der CanvasGroup-Komponente und der richtigen Farbe sieht das Panel dann wie folgt aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55969208-b04cc780-5c7d-11e9-82b5-67b6daec1f3d.png" width="400px"></p>

<h2 id="objektesammeln">Objekte aufsammeln</h2>

Zunächst einmal soll der Charakter fähig sein, Objekte aufzusammeln. Die Logik dahinter lautet wie folgt: Der Charakter soll in der Nähe des Objektes einen Text angezeigt bekommen, dass es möglich ist, ein bestimmtes Objekt aufzusammeln. Dies allerdings nur, wenn das jeweilige Objekt noch existiert. Wenn der Spieler dann die Taste drückt, wird das Objekt zerstört und der Text wieder ausgeblendet.

Zunächst einmal muss ein Objekt erstellt werden, welches dann aufgesammelt wird. In diesem Fall ist dies ein Schlüssel. 

<p align="center"><img width="600px" src="https://user-images.githubusercontent.com/42578917/53263002-7b3de300-36d8-11e9-8bf4-d7bd924536ec.png"></p>

Zudem wird ein ganz normaler Cube unter <b> GameObject > 3D Object > Cube </b>hinzugefügt. Dieser wird genau über den Schlüssel gesetzt und wird später genutzt, um den Abstand zwischen Spieler und Schlüssel zu bestimmen. Von diesem wird dann per Rechtsklick auf den Mesh Renderer und <b> Remove Component </b>der Mesh Renderer entfernt. Damit wird das Objekt zwar durchsichtig, bleibt aber als Objekt in der Szene vorhanden und lässt sich im Spiel verwenden. Ein extra Cube wird benötigt, da nämlich eine Distance zwischen dem Charakter und dem Objekt geprüft wird. Wird das Objekt dann durch das Aufsammeln zerstört, existiert es nicht mehr und es kann keine Distance mehr gemessen werden. Dies würde eine Fehlermeldung erzeugen. Daher wird hier ein extra Würfel verwendet. 

Nun wird ein Script geschrieben, welches all diese Schritte vollzieht. Dafür wird ein neuer Ordner mit einem C#-Script mit dem Namen PickUpScript.cs erstellt.  Dort müssen zunächst einmal alle Objekte selektiert werden. Dafür werden drei neue Variablen für GameObject erstellt:

```
public class PickUpScript:MonoBehaviour {
    public GameObject KeyBox;
    public GameObject Player;
    public GameObject KeyTextUI
    public float Distance;
}
```
Neben dieser wird eine Variable vom Typ float erstellt, in der später der Abstand zwischen Spieler und Objekt gespeichert wird. Da das Ergebnis des nachher verwendeten Objektes eine Gleitkommazahl ist, muss hier statt einer integer eine Variable vom Typ float verwendet werden. 

Um nun weiter zu verfahren wird ein Text benötigt, welcher den Spieler darauf hinweist, den Schlüssel aufzusammeln. Dies wird auf die selbe Weise erstellt, wie das Escape-Menü erstellt wurde. Dies ist <a href="#pausemenu">hier</a> nachzulesen. In diesem Fall wird im Canvas statt eines Buttons ein Text erstellt. Dieser kann dann rechts im Inspektor bearbeitet werden. 

Als nächstes wird die Start-Funktion gefüllt:

```
void Start() {
    KeyTextUI.SetActive(false);
}
```
Da nämlich aktuell der Schriftzug noch immer dauerhaft angezeigt wird, wird er in dieser Zeile zunächst einmal standartmäßig auf nicht-anzeigen gestellt.

Als Nächstes muss dann etwas passieren, wenn man sich dem Schlüssel nähert. All die Logik dahinter wird innerhalb der Update() Funktion geschrieben:

```
void Update() {
    Distance = Vector3.Distance(KeyBox.transform.position, Player.transform.position);
}
```
Hier wird nun der Abstand des Objektes KeyBox vom Abstand des Objektes Player in der vorher deklarierten Variable Distance gespeichert. Wie dies funktioniert, wurde bereits im Abschnitt <a href="#musik">Musik</a> erläutert

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
    KeyTextUI.SetActive(true);
    if(Input.GetKey(KeyCode.E)) {
        Destroy(gameObject)
        KeyTextUI.SetActive(false);
    }
}
```

Ist nun der Abstand kleiner als 3 und existiert der Schlüssel noch werden diese Aktionen getätigt:

Zuerst wird der Text mit KeyTextUI.SetActive(true) auf "anzeigen" gesetzt, sodass der Spieler diesen auf dem Bildschirm eingeblendet sieht. Als nächstes wird dann geprüft, ob der Spieler E drückt. Wie genau dies funktioniert bzw. was der Code bedeutet, lässt sich <a href="#pausemenu">hier</a> nachlesen. Wenn der Spieler E drückt, werden zwei Aktionen ausgeführt: Erstens wird der Schlüssel, also das gameObject auf dem das Script drauf ist, mittels Destroy(gameObject) zerstört. Zweitens wird der Text, der zum aktuellen Laufzeit-punkt noch eingeblendet ist, ausgeblendet. Der Spieler bekommt also einen Text angezeigt und sobald er E drückt wird dieser wieder ausgeblendet und der Schlüssel zerstört. 

Als Letztes muss noch eine Option eingebaut werden, sollte der Spieler sich wieder vom Schlüssel entfernen. Dafür wird ein else an der if-Schleife angebracht, in der geschrieben wird, was passiert, wenn der Abstand größer als 3 ist. In diese wird folgender Code geschrieben:

```
else {
    KeyTextUI.SetActive(false);
}
```
Der Befehl wurde zuvor bereits erklärt und bewirkt diesmal wieder ein Ausblenden des Textes. Damit ist das Script abgeschlossen. Der gesamte Code sieht dann wie folgt aus:

```
public class PickUpScript : MonoBehaviour {
    public GameObject KeyBox;
    public GameObject Player;
    public GameObject KeyTextUI;
    public float Distance;    
    void Start() {
        KeyTextUI.SetActive(false);
    }
    void Update() {
        Distance = Vector3.Distance(KeyBox.transform.position,Player.transform.position);
        print(Distance);
        if(Distance <= 3) {
            if (GameObject.Find("Schlüssel") != null) {
                AxeTextUI.SetActive(true);
                if (Input.GetKey(KeyCode.E)) {
                    Destroy(gameObject);
                    KeyTextUI.SetActive(false);
                }                   
            }
        }
        else {
            KeyTextUI.SetActive(false);
        }
    }
}
```

Anschließend wird der Code abgespeichert. Dieser muss nun nur noch "wirkend" gemacht werden. Das Script wird also auf den Schlüssel gezogen. Dort sind dann drei Felder zu sehen, eins für Player, eins für KeyBox und eins für AxeTextUI. Auf das KeyBox-Feld wird der vorher erzeugte Cube gezogen, auf das Player-Feld der der Charakter und auf das AxeTextUI-Feld der erstellte Canvas. 

<h2 id="haustuer">Die Haustür</h2>

Damit nun das Aufsammeln des Schlüssels auch etwas bringt, muss irgendwas passieren, nachdem man ihn aufgesammelt hat. In diesem Fall soll es möglich sein, wenn der Schlüssel aufgesammelt wurde, eine Tür damit zu öffnen. Dafür muss natürlich zunächst einmal ein Haus mit Tür erstellt und in Unity platziert werden:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55969895-d9218c80-5c7e-11e9-9ef3-75500f4fe662.png" width="500px"></p>

Dafür muss natürlich auch in Blender eine Animation erstellt werden, in der sich die Tür öffnet. Das ganze wird dann in Unity implementiert. Danach wird ein neuer Animator erstellt. Mit <b> Rechtsklick > Create > Animator Controller </b> lässt sich dieser erstellen. Als Nächstes muss auf das erstellte Objekt (die Hütte) ein Animator angeheftet werden. Dafür muss man einfach die zuvor in Blender erstellte Animation auf das Modell der Hütte ziehen. Damit wird automatisch einer erstellt. Auf diesen Animator muss nun im Feld Controller der neu erstellte Animator Controller platziert werden. 

Als Nächstes wird der Animator Controller geöffnet. In diesem wird eine neue Transition erstellt und ein Parameter namens openDoor.(Für eine Erläuterung s.h. <a href="#animationcontroller">Der Animator-Controller</a>). Nun wird ein gleichnamiges Script erstellt mit folgendem Inhalt:

```
public class openDoor : MonoBehaviour
{
    public Animator HouseAnimation;
    public GameObject door;
    public float Distance;
    public GameObject Player;
    void Start()
    {
        HouseAnimation = GetComponent<Animator>();
    }
    void Update()
    {
        Distance = Vector3.Distance(door.transform.position, Player.transform.position);
        if (GameObject.Find("Schlüssel") == null && Distance <= 8) { 
            if(Input.GetKey(KeyCode.E))
            {
                HouseAnimatiomn.SetBool("openDoor", true);
            }            
        }
    }
}
```
Es wird wieder der Animator Controller selektiert und darin die Boolean Condition "openDoor" geschaltet. Diesmal ist es allerdings nicht abhängig von einem Tastendruck oder Timer, sondern davon, ob der Schlüssel, den man ja erst einsammeln muss, um die Tür zu öffnen, noch existiert. Dafür ist der Befehl GameObject.Find("Schlüssel") == null zuständig. Zudem wird wieder geprüft, ob der Spieler sich in einem gewissen Umkreis um die Tür befindet, damit er nicht einfach so die Tür von 200 Metern weit weg öffnen kann. Wenn das der Fall ist, und der Spieler dann E drückt, wird die Variable auf true geschaltet und somit die Animation der Tür ausgeführt. Eine Erläuterung der Distance und des GameObject.Find("Schlüssel") == null findet sich im Kapitel <a href="objektesammeln">Objekte aufsammeln</a>.

Als Letztes soll noch ein Text ein und ausgeblendet werden wenn es möglich ist, die Tür zu öffnen. Dafür kann allerdings auch das Script für das Aufsammeln des Schlüssels (<a href="objektesammeln">Objekte aufsammeln</a>) verwendet werden, da es nahezu identisch in der Funktionsweise ist. Es wird lediglich um folgende if-Schleife ergänzt:

```
if (GameObject.Find("Schlüssel") == null && Distance <= 8) {
}        
```
Damit wird geprüft, ob der Schlüssel noch existiert. Mit dieser Ergänzung sieht das Script zum Öffnen der Tür wie folgt aus:

```
public class openDoorText : MonoBehaviour
{
    public GameObject GameTextUI;
    public GameObject door;
    public float Distance;
    public GameObject Player;
    public bool doorOpen;    
    void Update()
    {
        Distance = Vector3.Distance(door.transform.position, Player.transform.position);
        if (GameObject.Find("Schlüssel") == null && Distance <= 8) {
            if(doorOpen == false)
            {
                GameTextUI.SetActive(true);
            }            
            if(Input.GetKey(KeyCode.E))
            {
                doorOpen = true;
            }
        }
        if(Distance > 8 || doorOpen == true)
        {
            GameTextUI.SetActive(false);
        }
    }
}
```

Zuletzt muss natürlich wieder ein Text erstellt, gestyled und positioniert, sowie richtig zugeordnet werden. 

<h2 id="missionen">Missionen</h2>

Nun soll der Spieler auch wissen, was er machen soll, um im Spiel weiter zu kommen. Dafür wird zunächst ein Missionstext erstellt. Wie man das Canvas und diesen Text erstellt, lässt sich im Kapitel <a href="#">Objekte aufsammeln</a> nachlesen. Dieser wird nun oben rechts am Bildschirmrand platziert und mit dem benötigten Text gefüllt. Als Nächstes wird ein neues Script erstellt namens keyMission.cs. Dort kommt folgender Text hinein:

```
public class keyMission : MonoBehaviour
{
    public GameObject missionText;
    public string gameObjectName;
    void Start()
    {
        missionText.SetActive(true);
    }
    void Update()
    {
        if(GameObject.Find(gameObjectName) == null)
        {
            missionText.SetActive(false);
        }        
    }
}
```
Dies ist einfach ein ganz simples Script, mit dem das zuvor erstellte Canvas ein und ausgeblendet wird. Dies wird darüber gelöst, dass in einer if-Schleife mittels des Befehls: GameObject.Find(gameObjectName) == null geprüft wird, ob das Objekt noch da ist. In diesem Fall wird der Missionstext zu Beginn des Spiels eingeblendet. Wenn nun der Schlüssel aufgesammelt, also das Element zerstört wird, ist das Ergebnis der Abfrage GameObject.Find(gameObjectName) null, also dass es nicht mehr da ist. Wenn es also = null ist, wird der Missionstext ausgeblendet. 

Das Ganze lässt sich nun auf alle Missionen im Spiel anwenden. Dafür prüft man einfach, ob das Missionsobjekt von Mission 1 zerstört wurde. Wenn das der Fall ist, wird der Text für Mission 2 eingeblendet. Sobald dieses dann zerstört ist, wird der Text für Mission 2 wieder ausgeblendet und der Text für Mission 3 eingeblendet. Das ganze lässt sich dann immer weiter so fortführen, bis man eine ordentliche Reihe von Missionen hat. 

In diesem Fall soll hier nur eine Mission erläutert werden. Das Ganze lässt sich aber auch auf alle anderen Missionen ganz einfach anwenden. Hier wurde das Script für mehrere Missionen zum Sammeln von Floß-Bestandteilen verwendet.

<h2 id="healthsystem">Das Health-System</h2>

Ein weiterer wichtiger Aspekt für das Gameplay ist ein Health-System. Um dies zu implementieren, wird zunächst ein neues Script mit dem Namen healthScript erstellt. In diesem werden dann zunächst folgende Variablen eingeführt: 

```
    public GameObject ozean;
    public GameObject gameOverScreen;
    public static float healthTime;
    bool touchesWater = false;
    bool gameIsOver;
``` 

In diesem Fall soll der Charakter leben verlieren, wenn er sich im Wasser befindet. Dann soll ein GameOverScreen eingeblendet werden und das Spiel, sowie jegliche spielinterne Bewegungen blockiert werden. Dafür werden zunächst einmal die GameObjekte ozean und gameOverScreen definiert. Dann wird zudem eine Variable definiert, die den aktuellen Zustand des Lebens definieren soll. In diesem Fall wird das Health von der Zeit im Wasser abhängig gemacht und daher healthTime genannt. Dann wird noch eine Variable benötigt, in der angegeben wird, ob das Spiel vorbei ist oder nicht.

```
private void Start()  {
    healthTime = 10.0f;
    gameOverScreen.SetActive(false);
    gameIsOver = false;
}
```

Als allererstes wird das "Leben" auf 10 gesetzt, mittels healthTime = 10.0f;. Anschließend wird der gameOverScreen auf nicht mehr aktiv gesetzt. Was es damit auf sich hat, lässt sich <a href="#setuiactive">hier</a> nachlesen

HIER FEHLT NOCH WAS



Nun sind allerdings auch in anderen Scripten schon die Maussichtbarkeit und Kamerabewegung etc. beeinflusst worden. Wenn darauf keine Rücksicht genommen wird, blocken sich die Scripte gegenseitig und es passiert am Ende nicht das gewünschte. Deshalb muss nun nocheinmal in einige vorige Scripte gewechselt werden: 

Zunächst im CursorScript.cs: 

Hier muss eine Variable erstellt werden, mit der geprüft wird, ob das GameOver schon ausgelöst wurde. Dies wird ganz simpel mit der healthTime Variable gemacht. Es werden also folgende Code Zeilen hinzugefügt:

```
public class CursorScript : MonoBehaviour
{
    public float checkHealth;
    void Update()
    {
        checkHealth = healthScript.healthTime;
    }
}
```
Damit wird der Wert aus dem healthScript geholt. Anschließend muss geprüft werden, ob der Wert den "Grenzwert" für GameOver unterschritten hat, da dann die Ereignisse in diesem Script nicht ausgeführt werden sollen. Denn der ganze Cursor-Mechanismus basiert ja aktuell darauf, dass der Spieler sich inGame befindet. Wenn nun das healthScript nicht beachtet wird, tut das Script immer wieder das, was vorgegeben ist. Und achtet dabei nicht darauf, ob vielleicht schon GameOver ist. Da im healthScript der MouseCursor wieder sichtbar gemacht wurde, soll dies natürlich nicht einfach so vom CursorScript wieder rückgängig gemacht werden. Die vorhandene if-Schleife wird also wie folgt ergänzt:

``` 
if (isPaused == false && checkHealth > 1) {
...
}
else if (isPaused == true || checkHealth <= 1) {
...
}
```
Damit werden die ausgeübten Aktionen nur ausgeführt, wenn der Spieler sich noch im Spiel befindet. Dann wird die if-schleife ausgeführt. Ansonsten wird geguckt, ob der Spieler im GameOver ist. Dann muss nicht nochmal im HealthScript der Cursor sichtbar gemacht werden, sondern es kann dieser Code einfach wiederverwendet werden. Dafür wird mittels des oder-Operator || einfach noch  hinzugefügt, dass sobald entweder das gamePaused ist ODER das Game vorbei ist, die Maus wieder sichtbar gemacht wird.

Damit das Ganze nun auch in Unity wirksam wird, müssen noch einige Einstellungen im GUI getroffen werden. Als erstes muss das healthScript auf den Player gezogen werden. Als Nächstes müssen die vorhandenen Variablen zugewiesen werden. Dafür wird auf "Ozean" das Wasser-Objekt gezogen. Dann muss der GameOverScreen zugewiesen werden. Dafür muss zunächst ein solcher Screen erstellt weden. Dafür wird ein neues Canvas mit einem Text und einem Button erstellt und so eingestellt, wie es benötigt wird. Wie das ganze geht, ist <a href="#createbuttons">hier</a> nachzulesen. Dieser Screen wird dann auf das GameOverScreen-Feld gezogen und damit zugewiesen.

Das Selbe gilt für das VerticalCameraMovement Script und den PlayerController. Hier wurde bereits als Rücksicht auf das Pause-Menü eine if-Schleife eingefügt. Diese if-Schleife muss um folgendes ergänzt werden:

```
 float checkHealth = healthScript.healthTime;
 if(isPaused == false && checkHealth > 1)
 {
      ...
 }
```

In beiden Scripten sorgt das dafür, dass die Aktionen in der if-Schleife nur dann erlaubt sind, wenn das Spiel nicht pausiert ist UND der Spieler noch lebt. 

<h2 id="spieltimer">Spiel-Timer und Vulkanausbruch</h2>

Um das ganze etwas spannender zu machen, soll das Spiel auf Zeit laufen. Wie zuvor im healthScript und Intro wird auch diesmal ein Timer dafür verwendet. Es wird also ein neues Script erstellt und Folgendes hineingeschrieben:

```
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vulcanoCounter : MonoBehaviour
{
    public static float counter;
    public Text vulcanotext;
    public static string vulcanoSekunden;
    public static string vulcanoMinuten;
    float counterMinutes;
    float counterSeconds;
    void Start()
    {
        counter = 1800.0f;
    }
    void Update()
    {        
        counter -= Time.deltaTime;
        counterMinutes = counter / 60;
        counterSeconds = counter % 60;
        
        if(counterSeconds < 10)
        {
            vulcanoSekunden = "0" + ((int)counterSeconds).ToString();
        }   
        else
        {
            vulcanoSekunden = ((int)counterSeconds).ToString();
        }
        if(counterMinutes < 10)
        {
            vulcanoMinuten = "0" + ((int)counterMinutes).ToString();
        }
        else
        {
            vulcanoMinuten = ((int)counterMinutes).ToString();
        }        
        vulcanotext.text = vulcanoMinuten + ":" + vulcanoSekunden;
        if(counter < 1)
        {
            SceneManager.LoadScene("Vulkan");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
```
Ganz oben wird zunächst einmal definiert, dass sowohl auf das Unity User Interface und auf das Unity SceneManagement im Script zurückgegriffen werden kann. Als Nächstes werden einige Variablen definiert. Eine für den Counter, eine für den Text vom Typ Text, der den Counter auf dem User-Screen anzeigt, eine für Sekunden und eine für Minuten, die noch im Timer übrig ist, und noch einmal zwei Stück die das Ergebnis einer Rechenaufgabe speichern. 

In der Start() Funktion wird der Timer auf 30 Minuten, also 1800 Sekunden gesetzt. In der Update-Funktion wird zunächst, ähnlich wie beim healthSystem, der counter Variable mit -= (das Gegenteil von +=) runtergezählt. Wie das funktioniert, wurde bereits im Kapitel für das <a href="#intro">Intro</a> erläutert. Als Nächstes sollen die 1800 Sekunden, die ja für den Spieler relativ schlecht zu erkennen sind, in Minuten und Sekunden-Schreibweise aufgeteilt werden. Dafür wird zuerst einmal der Counter, der aktuell Sekunden enthält durch 60 geteilt. Das Ergebnis gibt die Anzahl an vollen Minuten wieder und wird in der Variable counterMinutes gespeichert. Als Nächstes sollen die restlichen Sekunden ermittelt werden. Also alle Sekunden, die nicht eine volle Minute ergeben. Dafür wird der Operator Modulo (%) verwendet. Dieser teilt eine Zahl durch eine andere, aber anstatt das Ergebnis (wie der durch-Operator) zurückzugeben, gibt er den dabei übrig bleibenden Rest zurück. 8 % 3 wäre dann also 2, weil 8/3 = 6 und der Rest 2 ist. In diesem Fall stellt Modulo die Sekunden dar. Bei 125 Sekunden würde damit bei der durch-Rechnung 2 und bei der Modulo-Rechnung 5 rauskommen. Daraus setzt sich aus 125 Sekunden 2 Minuten und 5 Sekunden zusammen.

Da im Text auf dem Screen vom Spieler von einem Script aus nur eine String Variable dargestellt werden kann und keine float Variable, muss der Counter zum String konvertiert werden. Daher werden im Folgenden alle Ergebnisse für Minuten und Sekunden den zuvor erstellten String Variablen zugeordnet. 

In den nächsten if-Schleifen wird nun geprüft, wie hoch der counter ist. In der ersten if-schleife wird geprüft, ob der Sekunden counter unter 10 ist. Wenn dies der Fall ist, wird der Sekunden Counter mittels dem Befehl ((int)counterSeconds).ToString() zu einem String konvertiert. Da der Spieler aber nicht einfach so einen einstelligen Sekundenwert haben soll (also so: 15:1), sondern das normale Stunden und Sekundenformat (also so: 15:01), wird vor dem Befehl, sollte der SekundenCounter unter 10 sein, mittels "0" + eine Null an den String drangehängt. Damit wäre die Zahlenfolge, wenn der Sekundencounter unter 10 läuft wie folgt: 12...11...10...09...08..., also genau wie es benötigt wird. In der nächsten else-Schleife wird der Fall abgedeckt, dass der Counter ÜBER 10 ist, denn dann soll ja nur der Wert des SekundenCounters, OHNE die extra 0 als String zugeordnet werden. Im Anschluss wird das Ganze noch einmal für die Minuten wiederholt.

Als Nächstes werden Sekunden und Minuten zu einem gemeinsamen String erstellt, welcher folgendes Format hat: 10:45. Dafür werden die zuvor MinutenText und SekundenText strings mit einem + hintereinander "geheftet" dazwischen wird allerdings noch ein Doppelpunkt gesetzt. 

```
vulcanotext.text = vulcanoMinuten + ":" + vulcanoSekunden;
```
Das Ganze funktioniert wie folgt. Zuvor wurde eine Variable vom Typ Text mit dem Namen vulcanotext erstellt. Dieser wird später im Unity-Overlay der jeweilige Text zugeordnet. Was nun passiert ist Folgendes: mit vulcanotext.text, wird das Text-Script, was von Beginn an auf jedem Textelement ist, angesprochen, genauer gesagt das Textfeld, in dem normalerweise der Text eingegeben wird. In dieses Feld wird der String eingefügt der zuvor aus Minuten und Sekunden erstellt wurde. Also der erstellte Counter im Minuten:Sekunden-Format wird jeden Frame mit dem aktuellen Sekunden- und Minutenwert in das Textelement auf dem Spieler-Screen eingefügt. Somit kann der Spieler ihn sehen. 

In der letzten If-Schleife wird dann der Fall abgedeckt, dass der Counter abgelaufen ist:

```
if(counter < 1)
{
     SceneManager.LoadScene("Vulkan");
     Cursor.lockState = CursorLockMode.None;
     Cursor.visible = true;
}
```

Der Szenenwechsel wurde bereits beim Kapitel für das Intro erklärt. Im Anschluss wird noch, damit man auch den Mauszeiger sieht, wenn das Spiel vorbei ist, der Mauszeiger noch auf "ungelocked" und auf sichtbar gesetzt. Damit wäre das Script vollständig. 

Als nächstes muss ein Canvas mit einem TextElement erstellt werden. Dieses wird dann unten am Rand über der Lebensanzeige platziert. Der Text wird wie gewünscht verändert. Das Script wird nun auf das Textelement gezogen. Anschließend wird der Variable Vulcanotext der zuvor erstellte Text zugeordnet. 

<h2 id="outtro">Das Outtro</h2>

Das Outtro wurde im Grunde genommen wie das Intro gestaltet. Diesmal wurden das Floß und die Kamera dafür bewegt. Wie sich das einrichten lässt, lässt sich <a href="#intro">hier</a> nachlesen.

In diesem Fall wurde statt eines Fade-Out eines schwarzen Bildes ein Fade-In gewählt, also ein langsames Einblenden mit einem darauffolgenden Szenenwechsel. Der Szenenwechsel wurde bereits mehrfach erläutert. Für einen Fade-Out wird alles so eingerichtet wie in einem Fade-In im Intro, aber es wird folgendes Script verwendet:

```
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Outtro : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float timer;
    public string restZeitMin;
    public string restZeitSec;
    public string restZeit;
    public Text restText;
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        timer = 0;
    }
    void Update()
    {
        restZeitMin = vulcanoCounter.vulcanoMinuten;
        restZeitSec = vulcanoCounter.vulcanoSekunden;
        restZeit = "Du hattest noch " + restZeitMin + ":" + restZeitSec + " um dich vor dem Vulkanausbruch zu retten!";
        restText.text = restZeit;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        timer += Time.deltaTime;
        if(timer > 20)
        {
            if (canvasGroup.alpha < 1)
            {
                canvasGroup.alpha += Time.deltaTime / 6;
                print(canvasGroup.alpha);
            }
            if(timer > 30)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }        
    }    
}

```

Die Besonderheit ist, dass in diesem Fall noch die Restzeit angezeigt werden soll. Dafür wurde ein Text erstellt, der mit dem Text aus dem Script gefüllt werden soll. Wie das geht lässt sich unter <a href="#spieltimer">Spiel-Timer und Vulkanausbruch</a> nachlesen. Im Grund genommen werden einfach die restlichen Sekunden und Minuten aus dem vulcanoCounter Script geholt und so aufbereitet, dass sie in einem Satz sichtbar sind. Wieder wird ein timer verwendet, womit diesmal der Alphakanal von 0 zu 1 HOCHgezählt wird und der bei 30 Sekunden einen Szenenwechsel zurück zum Hauptmenü veranlasst. All dies ist im Kapitel für den <a href="#spieltimer">Vulkan</a> und für das <a href="#intro">Intro</a> nachzulesen.

<h1 id="export">Der Export</h1>

Das ganze Spiel ist jetzt nun fertig und lässt sich auch in Unity sehr gut spielen. Allerdings soll der Nutzer am Ende nicht jedes Mal Unity installieren und das Ganze darin importieren müssen. Daher sollen im Folgenden alle Einstellungen getroffen und das Spiel für den Nutzer spielbar gemacht, also exportiert werden.

<h2 id="splashscreen">Der Splashscreen und Icons</h2>

Zunächst einmal sollen die Einstellungen getroffen werden, womit das Spiel als Programm auf dem Desktop gut aussieht. Also Desktop-Icon, Splashscreen und Startbildschirm. 

Dafür werden zunächst einmal unter <b>File > Build Settings</b> die Exporteinstellungen geöffnet:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55891432-d9555580-5bb4-11e9-8cd7-523e690ce896.png" width="200px"></p>

Dann werden unten links die Player Settings geöffnet:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55891542-06a20380-5bb5-11e9-8835-1c21b887e4b9.png" width="200px"></p>

In diesen ist dann rechts im Inspektor ein Icon-Reiter zu sehen. Um nun ein Desktop-Icon zu erstellen wird dieser aufgeklappt. Dann wird mittels "Select" bei 1024x1024 ein Fenster geöffnet, in dem das Desktop-Icon geöffnet wird:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55891769-6d272180-5bb5-11e9-80ca-2bccee2e68ca.png" width="300px"></p>

Dieses Bild wird dann für alle Größen übernommen. Damit ist ein Desktop-Icon für das exportierte Spiel eingebunden. Es muss allerdings noch als default icon übernommen werden. Dies lässt sich im selben Fenster darüber vornehmen. Da drüber lässt sich zudem der Name für das Spiel vergeben:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55894564-95fde580-5bba-11e9-9521-fb610e8e3d49.png" width="400px"></p>

Als Nächstes sollen der Splashscreen und das Hauptlogo beim Spielstart verändert werden. Für den Splashscreen muss einfach der Reiter "Splash Image" geöffnet werden. Dort kann bei "Application Config Dialog Bar" und "Virtual Reality Splash Image" das Bild selektiert werden. Damit sieht das Ganze dann wie folgt aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55895048-b1b5bb80-5bbb-11e9-859e-25576791f1a6.png" width="600px"></p>

Als letztes soll nun ein Start_image erstellt werden. Das wird ebenfalls im Splash Image - Reiter festgelegt. Dort kann unter "Logos" ein Logo hinzugefügt werden, was zum Start des Spiels angezeigt werden soll. Zudem können einige Einstellungen vorgenommen werden, mit denen die Dauer und Farbe dieses Startbildschirms verändert werden können. In diesem Fall wurde dies nicht vorgenommen. Bei dem Logo lässt sich ein zusätzliches Logo importieren. In diesem Fall wurde ein PNG ohne Hintergrund verwendet, um einen Schriftzug auf dem dunklen Hintergrund zu erzeugen:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55895609-c3e42980-5bbc-11e9-9a49-c7c569894224.png" width="600px"></p>

<h2 id="sceneeinbindung">Sceneneinbindung</h2>

Damit das Spiel dann exportiert werden kann und alle Szenen, die zuvor erstellt werden, auf korrekte Weise geladen und verwendet werden, muss zunächst der Export-Funktion von Unity gesagt werden, welche Szenen dabei mit eingebunden werden sollen. Dafür werden, wie zuvor bei der Erstellung eines Desktop-Icons und Splashscreens, die Build Settings geöffnet. Als Nächstes müssen alle vorhanden Szenen in den Build hinzugefügt werden. Dafür werden die Szenen nacheinander geöffnet und jedesmal in den Build Settings oben rechts bei "Add Open Scene" in die Build Settings eingefügt. Als Letztes müssen die Szenen noch in die richtige Reihenfolge gebracht werden. Soll z.B. das Hauptmenü als erstes geladen werden, muss die jeweilige Szene auch die links zu sehende ID 0 haben. Die Szenen können dabei frei beweglich mit der Maus in ihrer Reihenfolge geändert werden. In den Build Settings sieht das dann wie folgt aus:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55892639-effcac00-5bb6-11e9-9b20-864286ca1bfc.png" width="400px"></p>

<h2 id="spielexport">Das Spiel exportieren</h2>

Da nun alle Einstellungen getroffen wurden, kann das Spiel final exportiert werden. Dafür muss zunächst auf dem Desktop, in den Dateien, oder eben wo man das Spiel am Ende hin haben will, ein Ordner für den Export erstellt werden. Im Anschluss daran wird das Spiel exportiert.

Dafür geht man in den Build Settings unten rechts auf "Build". Damit öffnet sich dann ein Fenster, in dem der zuvor erstellte Ordner für den Export ausgewählt werden kann. Dieser muss dann ausgewählt werden und der Knopf "Ordner auswählen" wird betätigt:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/55893886-6e5a4d80-5bb9-11e9-88a8-4b2dd185fb6e.png" width="400px"></p>

Sobald der Ordner ausgewählt wurde, beginnt der Export. Wenn vor dem Export alle in der Konsole angezeigten Fehler korrigiert wurden, müsste der Export nach etwa 2-3 Minuten beendet sein. Anschließend daran öffnet sich der Ordner, in der Export gespeichert wurde. In dieser sind dann alle Dateien vorhanden, die für den Start des Spiels benötigt werden und eine .exe Datei. Wenn diese gestartet wird, öffnet sich ein kleines Fenster, in der man zuvor Bildschirmgröße und Auflösung ausgewählt werden können und wo man das Spiel starten kann. 

<h1 id="ergebnis">Das Ergebnis</h1>

<a href="https://www.youtube.com/watch?v=K6oZPDii_Wo&feature=youtu.be"><p align="center"><img src="https://user-images.githubusercontent.com/42578917/55962567-7249a680-5c71-11e9-8959-c22bffc1c31e.png"></p></a>
<p>(Zum Ansehen des Walkthrough vom fertigen Spiel bitte auf das Bild oder <a href="https://www.youtube.com/watch?v=K6oZPDii_Wo&feature=youtu.be">hier</a> klicken!)</p>

<h1 id="nachwort">Nachwort</h1>

Diese Dokumentation soll nur einen kleinen Einblick in die Arbeit der letzten Wochen am Spiel WHYlands geben. Natürlich spiegelt sie nicht die komplette Arbeitszeit von über 100 Stunden an diesem Projekt dar, aber sie erläutert gut die Mechanismen und Vorgehensweise, wie ein Dritter dieses Projekt reproduzieren oder als Grundlage für sein eigenes Projekt nutzen kann. Der Umfang von der Unity Engine ist natürlich ersichtlich und es ist zu erkennen, welche Möglichkeiten sie gibt für Anfänger, ein erstes eigenes Spiel zu produzieren. Auch umfangreichere Spiele lassen sich eindeutig mit Unity umsetzen. Dennoch ist auch auffällig, dass bereits in diesem Projekt Unity an seine Grenzen gestoßen ist. Dies könnte einerseits an der in diesem Projekt verwendeten Gratis-Version und dessen limitierter Engine-Leistung liegen, andererseits auch an der Ausrichtung von Unity auf vor allem Mini-Games und Anfängerprojekte. Zudem wurden natürlich alle in diesem Projekt verwendete Audio-, fbx- und Bilddateien nicht kompromiert, was natürlich ebenfalls die Ladezeiten erhöht. Daher kann sie gut genutzt werden, um Mini-Games oder kleine Projekte für den Anfang umzusetzten, aber es sollte auch darauf geachtet werden, dass bei der Umsetzung von deutlich größeren Projekten vielleicht eine andere Engine wie die Unreal Engine oder die CryEngine verwendet werden muss.

Dennoch war es sie für dieses Projekt mehr als ausreichend und kann Anfängern sehr gut die  Anfänge der Spiele-Entwicklung nahebringen und zeigen, wo die Grenzen sind und was ein Einzelner für ein Spiel realisieren kann. 

<h1 id="quellen">Quellen</h1>

* Musik: www.zapsplat.com
* Design-Inspiration: https://www.artstation.com/emekozben
* Tutorial Objektbewegung: https://www.youtube.com/channel/UCGOgRqMyWE6VPSCG-qxVkmw (kinan gh) 
* Unity Dokumentation: https://docs.unity3d.com/Manual/index.html

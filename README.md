# 3D-Game-Docu
<h2 id="charakter">Der Charakter</h2>

<h2 id="capsulecollider">Der Capsule-Collider</h2>

Nun ist der Charakter erstellt und importiert. Allerdings fällt dieser noch durch das vorhandene Terrain durch. Damit dies nicht passiert brauchen alle Objekte, die bei einer Berührung eine Bewegung ausführen sollen (wie z.B. dass der Charakter nicht durch den Boden fällt) einen von Unity bereitgestellten Collider. Dieser wird hinzugefügt, indem man den Charakter auswählt und dann auf Component > Physics > SphereCollider geht:

<p align="center"><img src="https://user-images.githubusercontent.com/42578917/50374528-cd3a8d80-05ef-11e9-9d0b-a028d61841c1.png" width="300px"></p>

Damit wird dann ein Collider auf den Charakter hinzugefügt und der Charakter fällt nicht mehr durch den Boden. Als Problem besteht dennoch weiterhin, dass der Charakter, wenn er auf einen Berg zugesteuert wird, den Berg rückwärts herunterrollt:

<p align="center"><img src="#" width="500px"></p>

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

Der Controller hat die Haupt-Klasse: PlayerController. Diese ist vom Typ MonoBehaviour, die Klassenart, die Funktionen wie Start() und Update() bereitsstellt. In der Klasse sind die Funktionen Start() und Update(). Beide sind void, haben also keinen Rückgabewert. Die Start() Funktion wird zu Beginn des Programmablaufs nur ein einziges Mal aufgerufen. Die Update Funktion wird dann dauerhaft Frame by Frame aufgerufen. Daher werden in dieser die Abfragen wie Tastatureingaben oder Maus-Bewegungen abgerufen und auf das zu bewegende Objekt übertragen. 



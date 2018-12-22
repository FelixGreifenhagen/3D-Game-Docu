# 3D-Game-Docu
<h2 id="charakter">Der Charakter</h2>

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

Der Controller hat die Haupt-Klasse: PlayerController. Diese ist vom Typ MonoBehaviour, die Klassenart, die Funktionen wie Start() und Update() bereitsstellt. In der Klasse sind die Funktionen Start() und Update(). Beide sind void, haben also keinen Rückgabewert. Die Start() Funktion wird zu Beginn des Programmablaufs nur ein einziges Mal aufgerufen. Die Update Funktion wird dann dauerhaft Frame by Frame aufgerufen. Daher werden in dieser die Abfragen wie Tastatureingaben oder Maus-Bewegungen abgerufen und auf das zu bewegende Objekt übertragen. 



using System.Collections;
using UnityEngine;

public class FinishGame : MonoBehaviour {

    public GameObject spawn;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Finish")
            gameObject.transform.position = spawn.transform.position;

    }
}

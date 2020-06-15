using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject player;
    public static GameObject lastWaypoint;
    Coroutine lastCoroutine;

    public void Teleport(){

        lastCoroutine = StartCoroutine(StartTeleport());

    }

    public void CancelTeleport(){

        StopCoroutine(lastCoroutine);

    }

    IEnumerator StartTeleport(){
        yield return new WaitForSeconds(3);
        
        if(lastWaypoint != null) lastWaypoint.SetActive(true);
        lastWaypoint = this.gameObject;
        lastWaypoint.SetActive(false);

        player.transform.position = new Vector3(this.gameObject.transform.position.x, 
        this.gameObject.transform.position.y * 1.2f, this.gameObject.transform.position.z);

    }

}

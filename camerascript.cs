using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class camerascript : MonoBehaviour
{
   public  GameObject player;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        //gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,new Vector3(0,gameObject.transform.position.y,player.gameObject.transform.position.z - 10),Time.deltaTime*100);

        transform.position = player.transform.position + offset;
    
    }

}

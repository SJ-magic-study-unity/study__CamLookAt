/************************************************************
description
	本scriptをcameraにattachし、動かしたいobjectをtargetに設定.
************************************************************/
using UnityEngine;
using System.Collections;

/************************************************************
************************************************************/
public class CamWork : MonoBehaviour {
    // [SerializeField] private GameObject target = null;
	public GameObject target = null;
    
    void Update ()
    {
        var y = (float)(Mathf.Sin(Time.time) * 3);
        target.transform.position = new Vector3(0, y , 0);
        transform.LookAt(target.transform);
    }
}

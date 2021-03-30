using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject target;

    public GameObject Dojo;
    public GameObject Garden;
    public GameObject Bridge;
    public GameObject Temple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportToDojo()
    {
        target.gameObject.transform.position = Dojo.gameObject.transform.position;
    }
    public void TeleportToGarden()
    {
        target.gameObject.transform.position = Garden.gameObject.transform.position;
    }
    public void TeleportToBridge()
    {
        target.gameObject.transform.position = Bridge.gameObject.transform.position;
    }
    public void TeleportToTemple()
    {
        target.gameObject.transform.position = Temple.gameObject.transform.position;
    }
}

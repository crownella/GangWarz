using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "GangMember" && !other.gameObject.GetComponent<CubeController>().lastInfluenceLeader == GetComponentInParent<Transform>().gameObject) //if you collide with a gang member and u werent the last leadre to influence them
        {
            GetComponentInParent<PlayerController>().InfluenceSubject(other.gameObject);
            other.gameObject.GetComponent<CubeController>().lastInfluenceLeader = GetComponentInParent<Transform>().gameObject;
        }else if (other.name == "GangLeader")
        {
            GetComponentInParent<PlayerController>().Fight(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CubeController>().willing &&  other.gameObject.GetComponent<CubeController>().inGang )
        {
            other.gameObject.GetComponent<CubeController>().willing = false;
            other.gameObject.GetComponent<CubeController>().influencedAmount = 0;
        }
    }
}

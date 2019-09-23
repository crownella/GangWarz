using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GangLeaderController : MonoBehaviour
{
    public Material gangColor;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        gangColor = new Material(source: gangColor);
        int ran = Random.Range(0, 101);
        if (ran > 0)
        {
            gangColor.color = Color.green;
            GetComponent<MeshRenderer>().material = gangColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

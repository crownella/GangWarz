using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float influence;

    public Material gangColor;

    public GameObject[] followers = new GameObject[100];

    public int followerCount = 0;

    public GameObject[] positions = new GameObject[100];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0,0,-speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0,0,speed * Time.deltaTime);
        }
        
        if ( Input.GetMouseButtonDown (0)){ 
            RaycastHit hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if ( Physics.Raycast (ray,out hit,100.0f)) {
                Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
                if (hit.transform.tag == "GangMember")
                {
                    if (!hit.transform.gameObject.GetComponent<CubeController>().inGang && //not in gang
                        hit.transform.gameObject.GetComponent<CubeController>().willing) //is willing to join
                    {
                        hit.transform.gameObject.GetComponent<CubeController>().JoinGang(gameObject);
                    }
                }
            }
        }

        for (int i = 0; i < followerCount; i++)
        {
            followers[i].transform.position = positions[i].transform.position;
        }
        
        
    }
    

    public void InfluenceSubject(GameObject subject) //increases influenced amount of a gang member, so he will be willing to join
    {
        subject.GetComponent<CubeController>().influencedAmount += influence;


    }

    public void Fight(GameObject gangLeader)
    {
        
    }

    public void addFollower(GameObject gangMember) //adds followers to players list, cant have more than 100
    {
        if(followerCount < 100)
        {
            followers[followerCount] = gangMember;
            followerCount++;
        }
    }
}

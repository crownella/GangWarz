using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update

    public bool inGang = false;
    public GameObject gangLeader;
    public float influence;
    public bool willing = false;
    public float influencedAmount;
    public float influenceThreshold;
    public GameObject lastInfluenceLeader;
    public GameObject CubeLeader;
    public Material black;
    public Material red;
    
    public GameObject[] placements = new GameObject[9];
    public GameObject[] gangmembers = new GameObject[9];
    void Start()
    {
        int rand = Random.Range(0, 101);
        if (rand > 100) //make this 75 later
        {
            Instantiate(CubeLeader, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (influencedAmount >= influenceThreshold && !inGang)  //if the member has enough influnece it will be willing to join
        {
            willing = true;
        }
        if (gangLeader == null)
        {
            //inGang = false;
        }else if (inGang)
        {
            willing = false;
        }


        if (willing)
        {
            GetComponent<MeshRenderer>().material = red;
            //JoinGang(lastInfluenceLeader);  //automatically join gang choice
        }
        else
        {
            if (inGang)
            {
                if (gangLeader.transform.tag == "Player")
                {
                    GetComponent<MeshRenderer>().material = gangLeader.GetComponent<PlayerController>().gangColor;
                }else if (gangLeader.transform.tag == "GangLeader")
                {
                    GetComponent<MeshRenderer>().material = gangLeader.GetComponent<GangLeaderController>().gangColor;
                }
            }
            else
            {
                GetComponent<MeshRenderer>().material = black;
            }
            
        }
    }

    public void JoinGang(GameObject leader)
    {
        gangLeader = leader;
        //gameObject.transform.SetParent(gangLeader.transform);
        if (gangLeader.transform.tag == "Player" && !inGang)
        {
            gangLeader.GetComponent<PlayerController>().addFollower(gameObject);
            inGang = true;

        }
    }

    public void InfluenceOthers(GameObject other)
    {
        other.GetComponent<CubeController>().influencedAmount += influence; 

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}

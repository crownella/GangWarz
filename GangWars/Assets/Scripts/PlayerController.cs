using System.Collections;
using System.Collections.Generic;
using instinctai.usr.behaviours;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float rotateSpeed;

    public float influence;

    public Material gangColor;

    public GameObject[] followers = new GameObject[100];

    public int followerCount = 0;

    public GameObject[] positions = new GameObject[100];

    public Camera mainCamera;
    public float cameraIncrease;

    public float minX = -75;
    public float maxX = 0;
    public float minZ = -35;
    public float maxZ = 35;

    public GameObject EnemyPos;

    public bool inFight = false;

    public bool gameOver = false;

    public Text endGameText;


    // Start is called before the first frame update
    void Start()
    {
        endGameText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            print("Game Over");
        }
        if (Input.GetKey(KeyCode.W) && !inFight)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) && !inFight)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) && !inFight)
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            //transform.Translate(0,0,-speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && !inFight)
        {
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
            //transform.Translate(0,0,speed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0) && !inFight)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f, 1 << 8))
            {
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
            followers[i].transform.rotation = gameObject.transform.rotation;
        }




    }


    public void InfluenceSubject(GameObject subject) //increases influenced amount of a gang member, so he will be willing to join
    {
        subject.GetComponent<CubeController>().influencedAmount += influence;


    }

    public void Fight(GameObject gangLeader, int enemyFollowers)
    {
        gangLeader.transform.position = EnemyPos.transform.position;
        if (followerCount > enemyFollowers)
        {
            DestroyFollowers(enemyFollowers / 2);
            
            for (int i = 0; i < gangLeader.GetComponent<GangLeaderBehavior>().followers.Length; i++)
            {
                Destroy(gangLeader.GetComponent<GangLeaderBehavior>().followers[i]);
                gangLeader.GetComponent<GangLeaderBehavior>().followers[i] = null;

            }
            
            Destroy(gangLeader);
            endGameText.text = " You Win";
        }
        else
        {
            gameOver = true;
            endGameText.text = "You Lose";
        }

    }

    public void addFollower(GameObject gangMember) //adds followers to players list, cant have more than 100
    {
        if (followerCount < 100)
        {
            followers[followerCount] = gangMember;
            followerCount++;
            //camera increase amounts 
            //7
            //16
            if (followerCount == 7)
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, cameraIncrease, mainCamera.transform.position.z);
            }
            else if (followerCount == 16)
            {
                mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, cameraIncrease + 5, mainCamera.transform.position.z);
            }
        }
    }

    public void DestroyFollowers(int amount)
    {
        for (int i = followerCount; i > followerCount - amount; i--)
        {
            Destroy(followers[i].gameObject);

        }
        followerCount = followerCount - amount;

    }
}

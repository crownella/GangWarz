
//%GenSrc:1:uwiErlMF00601FVXlizvHw
/*
 * This code was generated by InstinctAI.
 *
 * It is safe to edit this file.
 */

using System.Collections;

namespace instinctai.usr.behaviours
{
    using UnityEngine;
    using com.kupio.instinctai;

    public partial class GangLeaderBehavior : MonoBehaviour
    {
        
        public Material gangColor;

        //wander variables
        public float minX = -75;
        public float maxX = 0;
        public float minZ = -35;
        public float maxZ = 35;
        Vector3 direction;

        //member hunting vaiables
        public bool memberHunting = false;
        public GameObject targetMember;
        public Transform targetLocation;

        //member infleuncing variables
        public int maxMembers;
        public int minMembers;
        public bool hasMax;
        public bool hasMin;
        public float influence;
        public bool targetIsWilling;

        //fight vairables
        public bool inFight = false;

        //gang members
        public GameObject[] followers = new GameObject[100];
        public int followerCount = 0;
        public GameObject[] positions = new GameObject[100];

        //player variables
        public GameObject targetPlayer;
        public bool foundPlayer = false;

        void Update()
        {
            for (int i = 0; i < followerCount; i++)
            {
                followers[i].transform.position = positions[i].transform.position;
                followers[i].transform.rotation = gameObject.transform.rotation;
            }
           transform.LookAt(targetLocation);

        }

        public NodeVal Wander()
        {
            float newXval = Random.Range(-75, 0f);
            float newZval = Random.Range(-35, 35f);
            if(newXval < minX)
            {
                newXval = minX;
            }else if(newXval > maxX)
            {
                newXval = maxX;
            }
            if (newZval < minZ)
            {
                newZval = minZ;
            }
            else if (newZval > maxZ)
            {
                newZval = maxZ;
            }
            direction = new Vector3(newXval, -6, newZval);
            //targetLocation.position = direction;
           // print("wander: " + direction + " TargetLoc: " + targetLocation.position);
            return NodeVal.Success;
        }

        public NodeVal FindMember()
        {
            Collider[] nearbyEnemies = Physics.OverlapSphere(transform.position, 20f, 1<<8);
            if(nearbyEnemies.Length > 0)
            {
                //print("found one");
                for(int i = 0; i < nearbyEnemies.Length; i++)
                {
                    CubeController possibleTarget = nearbyEnemies[i].GetComponent<CubeController>();
                    if (!possibleTarget.inGang && !possibleTarget.willing)
                    {
                        if (targetMember == null)
                        {
                            targetMember = possibleTarget.gameObject;
                            targetLocation = targetMember.transform;
                            if (nearbyEnemies.Length == 1)
                            {
                                memberHunting = false;
                            }
                        }else if (Vector3.Distance(transform.position, targetMember.transform.position) >
                                  Vector3.Distance(transform.position, possibleTarget.transform.position))
                        {
                            targetMember = possibleTarget.gameObject;
                            targetLocation = targetMember.transform;
                            memberHunting = false;
                        }
                    }
                    
                }
            }
            return NodeVal.Success;
        }

        public NodeVal FindPlayer()
        {
            Collider[] nearbyPlayer = Physics.OverlapSphere(transform.position, 20f, 1<<9);
            for (int i = 0; i < nearbyPlayer.Length; i++)
            {
                print(nearbyPlayer[i].transform.name);
            }
            if(nearbyPlayer.Length > 0 && nearbyPlayer[0].transform.tag == "Player")
            {
                print("found player");
                targetPlayer = nearbyPlayer[0].gameObject;
                targetLocation = targetPlayer.transform;
                memberHunting = false;
                foundPlayer = true;
            }
            return NodeVal.Success;
        }

        public NodeVal Infleunce()
        {
            if(targetMember == null)
            {
                return NodeVal.Error;
            }
            if(targetMember.GetComponent<CubeController>() != null)
            {
                targetMember.GetComponent<CubeController>().influencedAmount += influence;
            }
            if (targetMember.GetComponent<CubeController>().willing)
            {
                targetIsWilling = true;
            }
            return NodeVal.Success;
        }

        public NodeVal AddToGang()
        {
            if (targetMember == null)
            {
                return NodeVal.Error;
            }
            if (targetMember.GetComponent<CubeController>() != null)
            {
                if(followerCount > maxMembers)
                {
                    hasMax = true;
                    return NodeVal.Success;
                }
                followers[followerCount] = targetMember;
                followerCount++;
                targetMember.GetComponent<CubeController>().JoinGang(gameObject);
                memberHunting = true;
                if(followerCount > minMembers)
                {
                    hasMin = true;
                }
            }

            targetMember = null;
            targetLocation = null;
            return NodeVal.Success;
        }

        public NodeVal FightPlayer()
        {
            targetPlayer.GetComponent<PlayerController>().Fight(gameObject, followerCount);
            inFight = true;
            foundPlayer = false;
            memberHunting = true;
            return NodeVal.Success;
        }

    }
}

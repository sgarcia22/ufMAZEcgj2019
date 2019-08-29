using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public NavMeshAgent agent;
    private GameObject player;
    private PlayerController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<PlayerController>();
        StartCoroutine("FollowPlayer");
    }

    IEnumerator FollowPlayer ()
    {
        while (playerScript.alive) {
            Vector3 pos = player.transform.position;
            pos.y = gameObject.transform.position.y;
            agent.SetDestination(pos);
            //Wait for 2 seconds before calculating shortest distance
            yield return new WaitForSeconds(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

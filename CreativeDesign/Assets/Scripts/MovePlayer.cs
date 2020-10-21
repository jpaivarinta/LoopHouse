using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Transform target;
    public CharacterController player;
    public GameObject posObjLeft;
    public GameObject posObjRight;
    private Vector3 startposition;
    Quaternion rotationPlus = Quaternion.Euler(0, 90f, 0);
    Quaternion rotationMinus = Quaternion.Euler(0, -90f, 0);

    // Start is called before the first frame update
    void Start()
    {

       startposition = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.x >= 3.5f)
        {
            player.GetComponent<CharacterController>().enabled = false;

            //set matching teleport position
            player.transform.position = new Vector3(posObjLeft.transform.position.x, 1, 0);
            player.transform.rotation = target.rotation * rotationPlus;
            
            player.GetComponent<CharacterController>().enabled = true;
        }

        if (target.position.x <= -3.5f)
        {
            player.GetComponent<CharacterController>().enabled = false;

            //set matching teleport position
            player.transform.position = new Vector3(posObjRight.transform.position.x, 1, 0);
            player.transform.rotation = target.rotation * rotationMinus;

            player.GetComponent<CharacterController>().enabled = true;
        }


    }
}

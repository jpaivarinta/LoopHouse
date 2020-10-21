using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositioningLeft : MonoBehaviour
{
    public Transform player;
    public CharacterController Controller;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    { 
        Vector3 lateralPosition = new Vector3(player.position.z + 9.5f, 0, 0);
        Controller.transform.position = lateralPosition;
    }
}

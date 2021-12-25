using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereHeath : MonoBehaviour
{
    public GameObject Player;
    private Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Player.transform.position, transform.position);
        if (dist > 5)
        {
            newPosition = new Vector3(Player.transform.localPosition.x, Player.transform.localPosition.y + 6, Player.transform.localPosition.z - 1);
            
        }
    }
}

using DG.Tweening;
using UnityEngine;
using Lightbug.Utilities;
using Lightbug.CharacterControllerPro.Core;
using Lightbug.CharacterControllerPro.Demo;

public class CameraPlanetCorrigePos : MonoBehaviour
{
    public GameObject follower;
    private Vector3 newPos;
    private Vector3 newRot;
    public float Height = 8f;
    public float Distance = -3f;


    [Header("Character")]

    [SerializeField]
    CharacterActor characterActor = null;

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(follower.transform.position, transform.position);
        transform.LookAt(follower.transform);

        newPos = new Vector3(follower.transform.position.x, follower.transform.position.y, follower.transform.position.z);
        newRot = new Vector3(follower.transform.eulerAngles.x, follower.transform.eulerAngles.y, follower.transform.eulerAngles.z);
        
        print(characterActor.PlanarVelocity.magnitude);

        if (characterActor.PlanarVelocity.magnitude == 0) {
            transform.DOMove(newPos, 2f, false);
            transform.rotation = follower.transform.rotation;
        }       
    }
}

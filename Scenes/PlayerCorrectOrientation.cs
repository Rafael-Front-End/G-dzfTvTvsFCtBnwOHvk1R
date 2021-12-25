using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lightbug.CharacterControllerPro.Implementation;
public class PlayerCorrectOrientation : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameObject Reference;
    [SerializeField] public CharacterStateController CStateController;
    private Transform currentReference;
    #endregion

    #region MonoBehaviour

    // Start is called before the first frame update
    void Start()
    {
        currentReference = CStateController.ExternalReference;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CStateController.ExternalReference = Reference.transform;
            GameObject ReferenceTXT = GameObject.Find("ReferenceTXT");
            ReferenceTXT.GetComponent<Text>().text = CStateController.ExternalReference.name;
        }
    }

    private void OnValidate()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    #endregion
}

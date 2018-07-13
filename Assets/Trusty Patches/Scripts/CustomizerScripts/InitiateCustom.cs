using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateCustom : MonoBehaviour
{
    private GameObject playerHands;
    public GameObject CustomizerUI, creatorBody, mainBody;
    public bool isEnabled;

    //added from uneccicary inheriting   
    private Vector3 charSpawnpoint = new Vector3(528.99f, 519.17f, 520.09f);
    private Quaternion charSpawnRotation = Quaternion.Euler(0f, 37f, 0f);
    private Quaternion tempRotation = Quaternion.Euler(0f, 37.726f, 0f);
    private GameObject currChar;
    public GameObject changedChar, charPosition;



    void Awake ()
    {
        this.playerHands = GameObject.FindGameObjectWithTag("Player");      //all player tag objects?
        this.GetComponent<CameraRotate>();

        this.currChar = GameObject.FindGameObjectWithTag("Player");//add
    }

    void Start()
    {
        this.CustomizerUI.SetActive(false);
        this.creatorBody.SetActive(false);//
        this.isEnabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Collider>().isTrigger = true;
            this.CustomizerUI.SetActive(true);
            this.creatorBody.SetActive(true);

            this.mainBody = other.gameObject;       //changes

            this.mainBody.SetActive(false);
            this.isEnabled = true;

            this.charPosition = other.gameObject;
        }
    }

    public void SaveChanges()
    {
        this.currChar = changedChar;

        this.charPosition.transform.position = this.charSpawnpoint;
        this.charPosition.transform.rotation = this.charSpawnRotation;
        CustomizerUI.SetActive(false);
        creatorBody.transform.rotation = this.tempRotation;
        creatorBody.SetActive(false);
        isEnabled = false;
        mainBody.SetActive(true);
    }

    void CancelChanges()
    {

    }

}//class

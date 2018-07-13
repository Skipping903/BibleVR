using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject currAngel;

    public GameObject throne;
    public GameObject seraphim;
    public GameObject cherubim;

    private Vector3 cameraDifference = new Vector3(0, 1, 0);

	void Awake ()
    {
        //this.currAngel = GameObject.Find("UI Controller");//empty game object
        this.currAngel = GameObject.Find("Ghost");

        this.throne = GameObject.Find("Throne");
        this.seraphim = GameObject.Find("Seraphim");
        this.cherubim = GameObject.Find("Cherubim");
	}
	
	void Update ()
    {
        //ChangeAngel();
        Follow(this.currAngel);
	}

    void Follow(GameObject angel) //camera is slightly behind character movement because of follow and not moving directly with input
    {
        this.transform.position = angel.transform.position + this.cameraDifference;
        this.transform.rotation = angel.transform.rotation;
    }

    void ChangeAngel()//change to else if?
    {
        if (this.throne.transform.position != this.throne.GetComponent<SwapClass>().home)
        {
            this.currAngel = this.throne;
        }

        if(this.seraphim.transform.position != this.seraphim.GetComponent<SwapClass>().home)
        {
            this.currAngel = this.seraphim;
        }

        if(this.cherubim.transform.position != this.cherubim.GetComponent<SwapClass>().home)
        {
            this.currAngel = this.cherubim;
        }
    }
}

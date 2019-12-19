
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;


public class CopyScript : MonoBehaviourPunCallbacks
{
    public int index = 1;

    void Update()
    {

        if (photonView.IsMine)
        {
            Debug.Log(photonView.IsMine);
            switch (index)
            {
                case 1://head
                    transform.position = ViveManager.Instance.head.transform.position;
                    transform.rotation = ViveManager.Instance.head.transform.rotation;
                    break;
                case 2://left
                    transform.position = ViveManager.Instance.leftHand.transform.position;
                    transform.rotation = ViveManager.Instance.leftHand.transform.rotation;
                    break;
                case 3://right
                    transform.position = ViveManager.Instance.rightHand.transform.position;
                    transform.rotation = ViveManager.Instance.rightHand.transform.rotation;
                    break;
            }

        }
    }
}

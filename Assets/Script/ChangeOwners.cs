using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOwners: MonoBehaviourPunCallbacks
{
    public VRTK.VRTK_InteractableObject toss;

    void Start()
    {
        toss.InteractableObjectGrabbed += Toss_InteractableObjectGrabbed;
        StartCoroutine(Pop());
    }

    private void Toss_InteractableObjectGrabbed(object sender, VRTK.InteractableObjectEventArgs e)
    {
        toss.GetComponent<PhotonView>().TransferOwnership(PhotonNetwork.LocalPlayer);
    }

    IEnumerator Pop()
    {
        yield return new WaitForSeconds(50f);
        PhotonNetwork.Destroy(this.gameObject);
    }

}

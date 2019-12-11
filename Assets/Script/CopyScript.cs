
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;


public class CopyScript : MonoBehaviourPunCallbacks
{
    public int index = 1;


    // Update is called once per frame
    void Update()
    {
        // this.transform.position = ViveManager.Instance.head.transform.position;
        // this.transform.rotation = ViveManager.Instance.head.transform.rotation;
        // Debug.Log(this.transform.position);

        // this.transform.position = ViveManager.Instance.head.transform.position;
        // this.transform.rotation = ViveManager.Instance.head.transform.rotation;
        // Debug.Log(transform.position);
        // Transform avatarTransform = this.transform;

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
            //相手がＶＲ使えないときの挙動確認のため
 		    // キーボード入力による移動処理
		  //var v = Input.GetAxis ("Vertical");
		   // Vector3 velocity = new Vector3 (0, 0, v);
		    //velocity = transform.TransformDirection (velocity);
		    //velocity *= 5f;
		    //transform.localPosition += velocity * Time.fixedDeltaTime;

		    // キーボード入力による回転処理
		   // var h = Input.GetAxis ("Horizontal");
		    //transform.Rotate (0, h * 3f, 0);

        }
    }
}

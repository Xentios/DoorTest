using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class DoorController : NetworkBehaviour
{
    [Networked]
    NetworkBool isOpen { set; get; } = true;


    
    [Rpc(RpcSources.Proxies, RpcTargets.StateAuthority)]
    public void RPCToggleDoor()
    {
        toggDoor();
    }

    public  void toggDoor()
    {
        isOpen = !isOpen;
        var degree = isOpen ? 0 : 90;
        transform.rotation = Quaternion.Euler(0, degree, 0);
    }   

    //private void OnGUI()
    //{
    //    if (Runner == null) return;

    //    if (Runner.IsSharedModeMasterClient == false)
    //    {
    //        if(GUI.Button(new Rect(0,0,100,100),"Toggle Door"))
    //        {
    //            RPCToggleDoor();
    //        }
    //    }
    //    else
    //    {
    //        if (GUI.Button(new Rect(Screen.width-100, 0, 100, 100), "Toggle Door For MasterClient"))
    //        {
    //            toggDoor();
    //        }
    //    }
    //}
}
